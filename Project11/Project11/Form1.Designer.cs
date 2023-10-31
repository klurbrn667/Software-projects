namespace Project11
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
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewComboBoxColumn();
            panel1 = new Panel();
            button1 = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            button2 = new Button();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.AppWorkspace;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dataGridView1.Location = new Point(1, 1);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(712, 248);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_RowsAdded;
            dataGridView1.CellEndEdit += dataGridView1_CellEndEdit;
            // 
            // Column1
            // 
            Column1.HeaderText = "Товар";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Цена";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Количество";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "Сумма";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.FlatStyle = FlatStyle.System;
            Column5.HeaderText = "Параметр";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 125;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Location = new Point(737, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(280, 346);
            panel1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(33, 271);
            button1.Name = "button1";
            button1.Size = new Size(214, 43);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 186);
            label3.Name = "label3";
            label3.Size = new Size(90, 20);
            label3.TabIndex = 1;
            label3.Text = "Количество";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 106);
            label2.Name = "label2";
            label2.Size = new Size(45, 20);
            label2.TabIndex = 1;
            label2.Text = "Цена";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 18);
            label1.Name = "label1";
            label1.Size = new Size(51, 20);
            label1.TabIndex = 1;
            label1.Text = "Товар";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(33, 209);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(214, 27);
            textBox3.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(33, 129);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(214, 27);
            textBox2.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(33, 41);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(214, 27);
            textBox1.TabIndex = 0;
            // 
            // button2
            // 
            button2.Location = new Point(1, 255);
            button2.Name = "button2";
            button2.Size = new Size(214, 43);
            button2.TabIndex = 2;
            button2.Text = "button1";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(326, 266);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 1;
            label4.Text = "label4";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(374, 338);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 1;
            label5.Text = "label5";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 450);
            Controls.Add(button2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Panel panel1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewComboBoxColumn Column5;
        private Button button1;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button button2;
        private Label label4;
        private Label label5;
    }
}