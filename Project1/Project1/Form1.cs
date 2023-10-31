namespace Project1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            MessageBox.Show(this, "Hello World C #");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            if (button1.Visible == false) MessageBox.Show("The first is not visible");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Text = "Clicked on the button";
            int viNumber = Convert.ToInt32(textBox1.Text) * 5;
            label1.Text = "Entered number multiplied by 5=" + viNumber.ToString();
        }

        private void button3_TextChanges(object sender, EventArgs e)
        {
            MessageBox.Show("An event has occured");
        }

        /*private void label1_Click(object sender, EventArgs e)
        {

        }*/
    }
}