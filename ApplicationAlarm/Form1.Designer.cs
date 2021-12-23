namespace ApplicationAlarm
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
            System.Windows.Forms.Timer timer1;
            this.ButtonAddAlarm = new System.Windows.Forms.Button();
            this.ChoiceSound = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.FileNameBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.DeleteAlarm = new System.Windows.Forms.Button();
            this.ButtonOffAlarm = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.OnAlarm = new System.Windows.Forms.Button();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.timer5 = new System.Windows.Forms.Timer(this.components);
            this.timer6 = new System.Windows.Forms.Timer(this.components);
            this.timer7 = new System.Windows.Forms.Timer(this.components);
            this.timer8 = new System.Windows.Forms.Timer(this.components);
            this.timer9 = new System.Windows.Forms.Timer(this.components);
            this.timer10 = new System.Windows.Forms.Timer(this.components);
            this.timer11 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.button2 = new System.Windows.Forms.Button();
            timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ButtonAddAlarm
            // 
            this.ButtonAddAlarm.Location = new System.Drawing.Point(208, 15);
            this.ButtonAddAlarm.Name = "ButtonAddAlarm";
            this.ButtonAddAlarm.Size = new System.Drawing.Size(75, 42);
            this.ButtonAddAlarm.TabIndex = 5;
            this.ButtonAddAlarm.Text = "Добавить будильник";
            this.ButtonAddAlarm.UseVisualStyleBackColor = true;
            this.ButtonAddAlarm.Click += new System.EventHandler(this.ButtonAddAlarm_Click);
            // 
            // ChoiceSound
            // 
            this.ChoiceSound.Location = new System.Drawing.Point(208, 64);
            this.ChoiceSound.Name = "ChoiceSound";
            this.ChoiceSound.Size = new System.Drawing.Size(75, 42);
            this.ChoiceSound.TabIndex = 7;
            this.ChoiceSound.Text = "Выбрать мелодию";
            this.ChoiceSound.UseVisualStyleBackColor = true;
            this.ChoiceSound.Click += new System.EventHandler(this.ChoiceSound_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Время:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Час:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(133, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Минута:";
            // 
            // FileNameBox
            // 
            this.FileNameBox.BackColor = System.Drawing.Color.White;
            this.FileNameBox.Enabled = false;
            this.FileNameBox.ForeColor = System.Drawing.Color.Black;
            this.FileNameBox.Location = new System.Drawing.Point(4, 76);
            this.FileNameBox.Name = "FileNameBox";
            this.FileNameBox.Size = new System.Drawing.Size(198, 20);
            this.FileNameBox.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Путь к мелодии будильника:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(297, 44);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(352, 186);
            this.listBox1.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(294, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Будильники:";
            // 
            // DeleteAlarm
            // 
            this.DeleteAlarm.Location = new System.Drawing.Point(459, 232);
            this.DeleteAlarm.Name = "DeleteAlarm";
            this.DeleteAlarm.Size = new System.Drawing.Size(75, 47);
            this.DeleteAlarm.TabIndex = 17;
            this.DeleteAlarm.Text = "Удалить будильник";
            this.DeleteAlarm.UseVisualStyleBackColor = true;
            this.DeleteAlarm.Click += new System.EventHandler(this.DeleteAlarm_Click);
            // 
            // ButtonOffAlarm
            // 
            this.ButtonOffAlarm.Location = new System.Drawing.Point(378, 232);
            this.ButtonOffAlarm.Name = "ButtonOffAlarm";
            this.ButtonOffAlarm.Size = new System.Drawing.Size(75, 41);
            this.ButtonOffAlarm.TabIndex = 18;
            this.ButtonOffAlarm.Text = "Отключить будильник";
            this.ButtonOffAlarm.UseVisualStyleBackColor = true;
            this.ButtonOffAlarm.Click += new System.EventHandler(this.ButtonOffAlarm_Click);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(418, 9);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "label8";
            // 
            // OnAlarm
            // 
            this.OnAlarm.Location = new System.Drawing.Point(297, 232);
            this.OnAlarm.Name = "OnAlarm";
            this.OnAlarm.Size = new System.Drawing.Size(75, 44);
            this.OnAlarm.TabIndex = 22;
            this.OnAlarm.Text = "Включить будильник";
            this.OnAlarm.UseVisualStyleBackColor = true;
            this.OnAlarm.Click += new System.EventHandler(this.OnAlarm_Click);
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // timer4
            // 
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // timer5
            // 
            this.timer5.Tick += new System.EventHandler(this.timer5_Tick);
            // 
            // timer6
            // 
            this.timer6.Tick += new System.EventHandler(this.timer6_Tick);
            // 
            // timer7
            // 
            this.timer7.Tick += new System.EventHandler(this.timer7_Tick);
            // 
            // timer8
            // 
            this.timer8.Tick += new System.EventHandler(this.timer8_Tick);
            // 
            // timer9
            // 
            this.timer9.Tick += new System.EventHandler(this.timer9_Tick);
            // 
            // timer10
            // 
            this.timer10.Tick += new System.EventHandler(this.timer10_Tick);
            // 
            // timer11
            // 
            this.timer11.Tick += new System.EventHandler(this.timer11_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(559, -1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 42);
            this.button1.TabIndex = 23;
            this.button1.Text = "ВЫКЛЮЧИТЬ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(50, 28);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(73, 20);
            this.numericUpDown1.TabIndex = 24;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(129, 28);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(73, 20);
            this.numericUpDown2.TabIndex = 25;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 264);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(151, 23);
            this.button2.TabIndex = 26;
            this.button2.Text = "Получение данных";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 299);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.OnAlarm);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ButtonOffAlarm);
            this.Controls.Add(this.DeleteAlarm);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.FileNameBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ChoiceSound);
            this.Controls.Add(this.ButtonAddAlarm);
            this.Name = "Form1";
            this.Text = "Будильник";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ButtonAddAlarm;
        private System.Windows.Forms.Button ChoiceSound;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox FileNameBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button DeleteAlarm;
        private System.Windows.Forms.Button ButtonOffAlarm;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button OnAlarm;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Timer timer5;
        private System.Windows.Forms.Timer timer6;
        private System.Windows.Forms.Timer timer7;
        private System.Windows.Forms.Timer timer8;
        private System.Windows.Forms.Timer timer9;
        private System.Windows.Forms.Timer timer10;
        private System.Windows.Forms.Timer timer11;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Button button2;
    }
}

