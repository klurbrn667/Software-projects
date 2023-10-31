using System.Windows.Forms;

namespace Project5_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.SelectionBullet = true;
            richTextBox1.BulletIndent = 50;
            richTextBox1.SelectionFont = new Font("Arial", 16);
            richTextBox1.SelectedText = "Below is a last \n";
            richTextBox1.SelectionFont = new Font("Arial", 12);
            richTextBox1.SelectionBullet = true;
            richTextBox1.SelectionColor = Color.Red;
            richTextBox1.SelectedText = "Apple" + "\n";
            richTextBox1.SelectionFont = new Font("Arial", 12);
            richTextBox1.SelectionColor = Color.Orange;
            richTextBox1.SelectedText = "Orange" + "\n";
            richTextBox1.SelectionFont = new Font("Arial", 12);
            richTextBox1.SelectionColor = Color.Purple;
            richTextBox1.SelectedText = "Grapes" + "\n";
            richTextBox1.SelectionBullet = false;
            richTextBox1.SelectionFont = new Font("Verdana", 10);
            richTextBox1.SelectedText = "The list is over \n";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int viNom = 0;
            richTextBox1.Text += "Text" + (Convert.ToInt32(viNom)).ToString();
            viNom++;
            richTextBox1.Text += "String" + (Convert.ToInt32(viNom)).ToString() + "\r\n";
            viNom++;
            richTextBox1.Text += "String" + (Convert.ToInt32(viNom)).ToString() + "\r\n";
            richTextBox1.AppendText("String" + Convert.ToString(viNom) + "\r\n");
            viNom++;
            richTextBox1.AppendText("String" + Convert.ToString(viNom) + "\r\n");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox2.Text = "My site https://www.youtube.com/";
        }

        private void richTextBox2_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            MessageBox.Show("Clicked on links");
            System.Diagnostics.Process.Start(e.LinkText);
        }
    }
}