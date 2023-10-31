namespace Project6
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
            listBox1 = new ListBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Items.AddRange(new object[] { "Первая строка", "Второая строка", "Третья строка", "Четвертая строка", "Пятая строка", "Шестая строка" });
            listBox1.Location = new Point(24, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(367, 404);
            listBox1.TabIndex = 0;
            listBox1.Click += listBox1_Click;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(421, 12);
            button1.Name = "button1";
            button1.Size = new Size(334, 30);
            button1.TabIndex = 1;
            button1.Text = "Добавление програмно строк";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(421, 48);
            button2.Name = "button2";
            button2.Size = new Size(334, 30);
            button2.TabIndex = 1;
            button2.Text = "Добавление из массива строк";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(421, 84);
            button3.Name = "button3";
            button3.Size = new Size(334, 30);
            button3.TabIndex = 1;
            button3.Text = "Добавляем строку";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(421, 120);
            button4.Name = "button4";
            button4.Size = new Size(334, 30);
            button4.TabIndex = 1;
            button4.Text = "Функия AddRange";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(421, 156);
            button5.Name = "button5";
            button5.Size = new Size(334, 30);
            button5.TabIndex = 1;
            button5.Text = "Выделение строк програмно ";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(421, 192);
            button6.Name = "button6";
            button6.Size = new Size(334, 30);
            button6.TabIndex = 1;
            button6.Text = "Сортировка";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(421, 228);
            button7.Name = "button7";
            button7.Size = new Size(334, 30);
            button7.TabIndex = 1;
            button7.Text = "Свойство UseTabStop";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(421, 264);
            button8.Name = "button8";
            button8.Size = new Size(334, 30);
            button8.TabIndex = 1;
            button8.Text = "Доступ к строке";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Location = new Point(421, 300);
            button9.Name = "button9";
            button9.Size = new Size(334, 30);
            button9.TabIndex = 1;
            button9.Text = "Перебор всех строк";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button10
            // 
            button10.Location = new Point(421, 336);
            button10.Name = "button10";
            button10.Size = new Size(334, 30);
            button10.TabIndex = 1;
            button10.Text = "Удаление 1";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // button11
            // 
            button11.Location = new Point(421, 372);
            button11.Name = "button11";
            button11.Size = new Size(334, 30);
            button11.TabIndex = 1;
            button11.Text = "Удаление 2";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button11);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
    }
}