using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Project2_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dialog box with a line");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dialog box with a line", "Line Title");
            // the first parameter specifies the dialog box text, the second parameter specifies the title text
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dialog box with a string and different buttons", "Title string", MessageBoxButtons.OKCancel);
            MessageBox.Show("Dialog box with a line and different buttons", "Title line", MessageBoxButtons.AbortRetryIgnore);
            MessageBox.Show("Dialog box with a line and different buttons", "Title line", MessageBoxButtons.OK);
            // MessageBoxButtons determines which buttons will be located on the dialog box
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dialog box with a line and different buttons", "Title bar", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            MessageBox.Show("Dialog box with a line and different buttons", "Title line", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
            // MessageBoxIcon defines the dialog box icon, the data is in the Enum enumeration type
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Save data", "Attention!", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.OK)
                MessageBox.Show("Data saved");
            if (result == DialogResult.No)
                MessageBox.Show("Data not saved");
            if (result == DialogResult.Cancel)
                MessageBox.Show("Saving data canceled by the user");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}