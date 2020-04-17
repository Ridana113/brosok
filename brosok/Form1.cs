using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace brosok
{
    public partial class Form1 : Form
    {
       const float Pi = 3.14F, g = 9.8F;
         float x, y, x0, y0, v, v0, vx0, vy0, vx, vy, alpha0, ax, ay, t, dt, Xmax, Ymax, Vmax;

        Color PixColor;
        private void button4_Click(object sender, EventArgs e)//перезапуск
        {
            timer1.Enabled = false;
            timer2.Enabled = false;
            int z = 0;
            textBox1.Text = Convert.ToString(z);
            textBox2.Text = Convert.ToString(z);
            textBox3.Text = Convert.ToString(z);
            textBox4.Text = Convert.ToString(z);
            axis1.Dispose(); //попытка очистить axis, к сожелению неуспешная, поэтому перезапуск формы
            Application.Restart();
        }

        public Form1()
        {
            InitializeComponent();
        }
       

        private void axis1_Load(object sender, EventArgs e)
        {
            
            axis1.PixDraw(2, 2, Color.Aqua, 1);
            axis1.Axis_Type = 1;
            axis1.x_Name = "Ox";
            axis1.y_Name = "Oy"; //если поменять фон на белый, то надписи будут видны, но цвет шрифта не удалось поменять
            axis1.x_Base = 1000;                     //поэтому в моем варианте написано сверху axis(мне больше нравиться темная тема, однако если надо будет - исправлю на норму)
            axis1.y_Base = 1000;
            axis1.AxisDraw();
            axis1.DinToPic();
            axis1.StatToDin();
            
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
               alpha0 = Convert.ToSingle(textBox1.Text);
            v0 = Convert.ToSingle(textBox2.Text);
            dt = Convert.ToSingle(textBox3.Text);
            t = 0;
            v = v0;
            vx0 = v0 * (float)(Math.Cos(alpha0 * Pi / 180));
            vy0 = v0 * (float)(Math.Sin(alpha0 * Pi / 180))-g*t;
        x0 = 0;
            y0 = Convert.ToSingle(textBox4.Text);
            Vmax = v0;
            Xmax = x0;
            Ymax = y0;
                if (alpha0 < 0 || dt < 0 || v0 < 0|| y0 < 0)
                {
                    timer2.Stop();
                    timer1.Stop();
                    MessageBox.Show("Уважаемый пользователь, пожалуйста, введите все величины в виде положительного числа");
                }
            }
            catch (FormatException)
            {
                timer1.Stop();
                timer2.Stop();
                MessageBox.Show("Уважаемый пользователь, пожалуйста, введите ЧИСЛО!");
                textBox1.Select();
                textBox2.Select();
                int z = 0;
                textBox1.Text = Convert.ToString(z);
                textBox2.Text = Convert.ToString(z);
                textBox3.Text = Convert.ToString(z);
                textBox4.Text = Convert.ToString(z);
                return;
            }
            timer1.Enabled = true;
            timer2.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            t = t + dt;
        if (checkBox1.Checked)
            {
                ax = -v * vx;
                ay = -1 - v * vy;
                PixColor = Color.Magenta;
            }
            else
            { 
                ax = 0;
                ay = -1;
                PixColor = Color.Aqua; 
            }
            vx = vx0 + ax * dt;
                vy = vy0 + ay * dt;
                x = x0 + (vx0 + vx)/2 * dt + ax * dt * dt / 2;
                y = y0 + (vy0 + vy)/2 * dt + ay *g* dt * dt / 2;
            x0 = x;
            y0 = y;
            vx0 = vx;
            vy0 = vy;
            v = (float)Math.Sqrt(vx *vx + vy *vy);
          if (y< 0)
            {
                timer1.Enabled = false;
                timer2.Enabled = false;
                    }
            }
      
        private void button3_Click(object sender, EventArgs e)
        {
            timer2.Enabled = true;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            t += 0.01F;
            this.Text = x.ToString() + " " + y.ToString();
            Invalidate();
            axis1.Pix_Size = 0.007f;       //след траектории
            axis1.PixDraw(x, y, PixColor, 1);
            axis1.StatToDin();
            axis1.Pix_Size = 0.023f;   //размер тела
            axis1.PixDraw(x, y, Color.Yellow, 2);
            axis1.DinToPic();
        }
        private void button2_Click(object sender, EventArgs e)//стоп
        {
            timer1.Enabled = false;
            timer2.Enabled = false;
        }
    }
}

