namespace Project8_2
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
            checkedListBox1 = new CheckedListBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(333, 34);
            button1.Name = "button1";
            button1.Size = new Size(321, 64);
            button1.TabIndex = 1;
            button1.Text = "Добавляем данные";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(333, 104);
            button2.Name = "button2";
            button2.Size = new Size(321, 64);
            button2.TabIndex = 1;
            button2.Text = "Опреление кто помечен";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(333, 174);
            button3.Name = "button3";
            button3.Size = new Size(321, 64);
            button3.TabIndex = 1;
            button3.Text = "Функция GetItemCheckState";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(333, 244);
            button4.Name = "button4";
            button4.Size = new Size(321, 64);
            button4.TabIndex = 1;
            button4.Text = "Удаляем помеченые";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(333, 314);
            button5.Name = "button5";
            button5.Size = new Size(321, 64);
            button5.TabIndex = 1;
            button5.Text = "Определение индекса поля";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "Пункт выбора 1", "Пункт выьора 2", "Пункт выбора 3", "Пункт выбора 4", "Пункт выбора 5" });
            checkedListBox1.Location = new Point(12, 34);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(299, 356);
            checkedListBox1.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(checkedListBox1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private CheckedListBox checkedListBox1;
    }
}