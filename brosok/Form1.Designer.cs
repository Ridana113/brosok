namespace brosok
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.axis1 = new myUCLib.Axis();
            this.Start = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ygol_alpha = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Speed_0 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.time_dt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Hight = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Stop = new System.Windows.Forms.Button();
            this.sozdanie_osey = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.Perezapusk = new System.Windows.Forms.Button();
            this.Sopritivleni_on_off = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // axis1
            // 
            this.axis1.axis_bkcolor = System.Drawing.Color.Gainsboro;
            this.axis1.axis_color = System.Drawing.Color.Black;
            this.axis1.Axis_Type = ((byte)(1));
            this.axis1.BackColor = System.Drawing.Color.White;
            this.axis1.E_x = 0;
            this.axis1.E_y = 0;
            this.axis1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.axis1.ForeColor = System.Drawing.Color.DimGray;
            this.axis1.Location = new System.Drawing.Point(339, 37);
            this.axis1.Name = "axis1";
            this.axis1.Pix_color = System.Drawing.Color.Maroon;
            this.axis1.Pix_Size = 2F;
            this.axis1.Pix_type = ((byte)(1));
            this.axis1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.axis1.Size = new System.Drawing.Size(855, 668);
            this.axis1.TabIndex = 0;
            this.axis1.x_Base = 1F;
            this.axis1.x_Name = "X";
            this.axis1.y_Base = 1F;
            this.axis1.y_Name = "Y";
            this.axis1.Load += new System.EventHandler(this.axis1_Load);
            // 
            // Start
            // 
            this.Start.BackColor = System.Drawing.Color.White;
            this.Start.ForeColor = System.Drawing.Color.Black;
            this.Start.Location = new System.Drawing.Point(184, 88);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(100, 29);
            this.Start.TabIndex = 1;
            this.Start.Text = "Старт";
            this.Start.UseVisualStyleBackColor = false;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(129, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Начальная скорость тела";
            // 
            // ygol_alpha
            // 
            this.ygol_alpha.BackColor = System.Drawing.Color.White;
            this.ygol_alpha.ForeColor = System.Drawing.Color.Black;
            this.ygol_alpha.Location = new System.Drawing.Point(17, 178);
            this.ygol_alpha.Name = "ygol_alpha";
            this.ygol_alpha.Size = new System.Drawing.Size(100, 20);
            this.ygol_alpha.TabIndex = 3;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Speed_0
            // 
            this.Speed_0.BackColor = System.Drawing.Color.White;
            this.Speed_0.ForeColor = System.Drawing.Color.Black;
            this.Speed_0.Location = new System.Drawing.Point(17, 214);
            this.Speed_0.Name = "Speed_0";
            this.Speed_0.Size = new System.Drawing.Size(100, 20);
            this.Speed_0.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(129, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Угол броска тела  α";
            // 
            // time_dt
            // 
            this.time_dt.BackColor = System.Drawing.Color.White;
            this.time_dt.ForeColor = System.Drawing.Color.Black;
            this.time_dt.Location = new System.Drawing.Point(17, 250);
            this.time_dt.Name = "time_dt";
            this.time_dt.Size = new System.Drawing.Size(100, 20);
            this.time_dt.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(129, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "dt (рекомендуется 0,1)";
            // 
            // Hight
            // 
            this.Hight.BackColor = System.Drawing.Color.White;
            this.Hight.ForeColor = System.Drawing.Color.Black;
            this.Hight.Location = new System.Drawing.Point(17, 286);
            this.Hight.Name = "Hight";
            this.Hight.Size = new System.Drawing.Size(100, 20);
            this.Hight.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(129, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Высота";
            // 
            // Stop
            // 
            this.Stop.BackColor = System.Drawing.Color.White;
            this.Stop.ForeColor = System.Drawing.Color.Red;
            this.Stop.Location = new System.Drawing.Point(17, 392);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(95, 29);
            this.Stop.TabIndex = 11;
            this.Stop.Text = "Стоп";
            this.Stop.UseVisualStyleBackColor = false;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // sozdanie_osey
            // 
            this.sozdanie_osey.BackColor = System.Drawing.Color.White;
            this.sozdanie_osey.ForeColor = System.Drawing.Color.Black;
            this.sozdanie_osey.Location = new System.Drawing.Point(17, 81);
            this.sozdanie_osey.Name = "sozdanie_osey";
            this.sozdanie_osey.Size = new System.Drawing.Size(122, 43);
            this.sozdanie_osey.TabIndex = 12;
            this.sozdanie_osey.Text = "Создание осей и тела";
            this.sozdanie_osey.UseVisualStyleBackColor = false;
            this.sozdanie_osey.Click += new System.EventHandler(this.sozdanie_osey_Click);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Perezapusk
            // 
            this.Perezapusk.BackColor = System.Drawing.Color.White;
            this.Perezapusk.ForeColor = System.Drawing.Color.Navy;
            this.Perezapusk.Location = new System.Drawing.Point(17, 439);
            this.Perezapusk.Name = "Perezapusk";
            this.Perezapusk.Size = new System.Drawing.Size(95, 29);
            this.Perezapusk.TabIndex = 13;
            this.Perezapusk.Text = "Перезапуск";
            this.Perezapusk.UseVisualStyleBackColor = false;
            this.Perezapusk.Click += new System.EventHandler(this.Perezapusk_Click);
            // 
            // Sopritivleni_on_off
            // 
            this.Sopritivleni_on_off.AutoSize = true;
            this.Sopritivleni_on_off.ForeColor = System.Drawing.Color.Black;
            this.Sopritivleni_on_off.Location = new System.Drawing.Point(17, 344);
            this.Sopritivleni_on_off.Name = "Sopritivleni_on_off";
            this.Sopritivleni_on_off.Size = new System.Drawing.Size(147, 17);
            this.Sopritivleni_on_off.TabIndex = 14;
            this.Sopritivleni_on_off.Text = "Сопротивление воздуха";
            this.Sopritivleni_on_off.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(908, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Ох, 1000";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(1128, 381);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Оу 1000";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(26, 505);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(287, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "При запуске в названии форм видны координаты тела";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(-4, 527);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(339, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = " Так что при остановке можно узнать точное расположение тела";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1206, 736);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Sopritivleni_on_off);
            this.Controls.Add(this.Perezapusk);
            this.Controls.Add(this.sozdanie_osey);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Hight);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.time_dt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Speed_0);
            this.Controls.Add(this.ygol_alpha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.axis1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Бросок тела под углом к горизонту";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private myUCLib.Axis axis1;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ygol_alpha;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox Speed_0;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox time_dt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Hight;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.Button sozdanie_osey;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button Perezapusk;
        private System.Windows.Forms.CheckBox Sopritivleni_on_off;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

