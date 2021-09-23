using System;
using System.Drawing;
using System.Windows.Forms;
using System.Media;

namespace brosok
{
    public partial class Form1 : Form
    {
        const float Pi = 3.14F;
        const float g = 9.8F;
        float x;
        float y;
        float x0;
        float y0;
        float v;
        float v0;
        float vx0;
        float vy0;
        float vx;
        float vy;
        float alpha0;
        float ax;
        float ay;
        float t;
        float dt;

        Color PixColor;
        private void Perezapusk_Click(object sender, EventArgs e)//перезапуск
        {
            timer1.Enabled = false;
            timer2.Enabled = false;
            int z = 0;
            ygol_alpha.Text = Convert.ToString(z);
            Speed_0.Text = Convert.ToString(z);
            time_dt.Text = Convert.ToString(z);
            Hight.Text = Convert.ToString(z);
            axis1.ClearDin();
            axis1.ClearPic();            //очистка axis, 
            x = 0;
            y = 0;
            t = 0;
        }

        public Form1()
        {
            InitializeComponent();
        }
       

        private void axis1_Load(object sender, EventArgs e)
        {
            
            axis1.PixDraw(2, 2, Color.Navy, 1);
            axis1.Axis_Type = 1;
            axis1.x_Name = "Ox";
            axis1.y_Name = "Oy"; //если поменять фон на белый, то надписи будут видны, но цвет шрифта не удалось поменять
            axis1.x_Base = 1000;                     //поэтому в моем варианте написано сверху axis(мне больше нравиться темная тема, однако если надо будет - исправлю на норму)
            axis1.y_Base = 1000;
            axis1.AxisDraw();
            axis1.DinToPic();
            axis1.StatToDin();
            
           
        }
        public void playExclamation()
        {
            SystemSounds.Exclamation.Play();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            
            try
            {
                alpha0 = Convert.ToSingle(ygol_alpha.Text);
                v0 = Convert.ToSingle(Speed_0.Text);
                dt = Convert.ToSingle(time_dt.Text);
                t = 0;
                v = v0;
                vx0 = v0 * (float)(Math.Cos(alpha0 * Pi / 180));
                vy0 = v0 * (float)(Math.Sin(alpha0 * Pi / 180))-g*t;
                x0 = 0;
                y0 = Convert.ToSingle(Hight.Text);
            
                if (alpha0 < 0 || dt < 0 || v0 < 0|| y0 < 0)
                {
                    timer2.Stop();
                    timer1.Stop();
                    playExclamation();
                    MessageBox.Show("ВВЕДИ ДАННЫЕ НОРМАЛЬНО, МЕШОК ИЗ МЯСА!!!");
                    
                }
            }
            catch (FormatException)
            {
                timer1.Stop();
                timer2.Stop();
                playExclamation();
                MessageBox.Show("Эй, слющай, ЧИСЛА нормально сдэлай");
                ygol_alpha.Select();
                Speed_0.Select();
                int z = 0;
                ygol_alpha.Text = Convert.ToString(z);
                Speed_0.Text = Convert.ToString(z);
                time_dt.Text = Convert.ToString(z);
                Hight.Text = Convert.ToString(z);
                return;
            }
            timer1.Enabled = true;
            timer2.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            t = t + dt;
        if (Sopritivleni_on_off.Checked)
            {
                ax = -v * vx;
                ay = -1 - v * vy;
                PixColor = Color.Red;
            }
            else
            { 
                ax = 0;
                ay = -1;
                PixColor = Color.Green; 
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
      
        private void sozdanie_osey_Click(object sender, EventArgs e)
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
        private void Stop_Click(object sender, EventArgs e)//стоп
        {
            timer1.Enabled = false;
            timer2.Enabled = false;
        }
    }
}

