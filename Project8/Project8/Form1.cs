namespace Project8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
                MessageBox.Show("CheckBox1 is selected");
            if (checkBox2.Checked == true)
                MessageBox.Show("CheckBox2 is selected");
            if (checkBox3.Checked == true)
                MessageBox.Show("CheckBox3 is selected");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(checkBox1.CheckState.ToString());
            MessageBox.Show(checkBox2.CheckState.ToString());
            MessageBox.Show(checkBox3.CheckState.ToString());
            checkBox1.CheckState = CheckState.Unchecked;
            checkBox2.CheckState = CheckState.Checked;
            checkBox3.CheckState = CheckState.Indeterminate;
            if (checkBox1.CheckState == CheckState.Checked)
            {
                MessageBox.Show("The state of option 2 is equal to selected");
            }
            else
            {
                MessageBox.Show("The state of choice item 2 is not selected or not defined");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = true;
            checkBox2.Checked = false;
            checkBox3.Checked = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
                MessageBox.Show("The radioButton1 item is selected");
            if (radioButton2.Checked == true)
                MessageBox.Show("The radioButton2 is selected");
            if (radioButton3.Checked == true)
                MessageBox.Show("The radioButton3 is selected");
            MessageBox.Show("We can only select one item");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
            radioButton2.Checked = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
                MessageBox.Show("The radioButton1 item is selected");
            if (radioButton2.Checked == true)
                MessageBox.Show("RadioButton2 is selected");
            if (radioButton3.Checked == true)
                MessageBox.Show("RadioButton3 is selected");
            if (radioButton4.Checked == true)
                MessageBox.Show("The radioButton4 item is selected");
            if (radioButton5.Checked == true)
                MessageBox.Show("The radioButton5 item is selected");
            if (radioButton6.Checked == true)
                MessageBox.Show("RadioButton6 is selected");
            MessageBox.Show("We can select only two items from this group and the previous one");
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("The CheckedChanged event has occured");
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("The CheckedChanged event has occured");
        }
    }
}