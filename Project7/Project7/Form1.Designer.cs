namespace Project7
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            comboBox1 = new ComboBox();
            label1 = new Label();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            comboBox4 = new ComboBox();
            comboBox5 = new ComboBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(267, 35);
            button1.Name = "button1";
            button1.Size = new Size(312, 39);
            button1.TabIndex = 0;
            button1.Text = "Добавление данных способ 1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(267, 80);
            button2.Name = "button2";
            button2.Size = new Size(312, 39);
            button2.TabIndex = 0;
            button2.Text = "Добавление данных способ 2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(267, 125);
            button3.Name = "button3";
            button3.Size = new Size(312, 39);
            button3.TabIndex = 0;
            button3.Text = "Добавление данных способ 3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(267, 170);
            button4.Name = "button4";
            button4.Size = new Size(312, 39);
            button4.TabIndex = 0;
            button4.Text = "Очищение списка";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(267, 215);
            button5.Name = "button5";
            button5.Size = new Size(312, 39);
            button5.TabIndex = 0;
            button5.Text = "Получение выбранного значения";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(267, 260);
            button6.Name = "button6";
            button6.Size = new Size(312, 39);
            button6.TabIndex = 0;
            button6.Text = "Получение индекса выбранного пункта";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(267, 305);
            button7.Name = "button7";
            button7.Size = new Size(312, 39);
            button7.TabIndex = 0;
            button7.Text = "Удаление из списка выбранной строки";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(267, 350);
            button8.Name = "button8";
            button8.Size = new Size(312, 39);
            button8.TabIndex = 0;
            button8.Text = "Удаление определенного значения";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Location = new Point(267, 395);
            button9.Name = "button9";
            button9.Size = new Size(312, 39);
            button9.TabIndex = 0;
            button9.Text = "Удаление значения по индексу";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 42);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(234, 28);
            comboBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 2;
            label1.Text = "Данные";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Первая строка", "Второая строка", "Третья строка", "Четвертая строка", "Пятая строка" });
            comboBox2.Location = new Point(12, 222);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(234, 28);
            comboBox2.TabIndex = 1;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "Значение 1", "Значение 2", "Значение 3", "Значение 4" });
            comboBox3.Location = new Point(611, 35);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(234, 28);
            comboBox3.TabIndex = 1;
            comboBox3.Click += comboBox3_Click;
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { "Значение 1", "Значение 2", "Значение 3", "Значение 4" });
            comboBox4.Location = new Point(611, 80);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(234, 28);
            comboBox4.TabIndex = 1;
            comboBox4.Click += comboBox4_Click;
            // 
            // comboBox5
            // 
            comboBox5.FormattingEnabled = true;
            comboBox5.Items.AddRange(new object[] { "Значение 1", "Значение 2", "Значение 3", "Значение 4" });
            comboBox5.Location = new Point(611, 131);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(234, 28);
            comboBox5.TabIndex = 1;
            comboBox5.TabStopChanged += comboBox5_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(889, 465);
            Controls.Add(label1);
            Controls.Add(comboBox5);
            Controls.Add(comboBox4);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private ComboBox comboBox1;
        private Label label1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private ComboBox comboBox4;
        private ComboBox comboBox5;
    }
}