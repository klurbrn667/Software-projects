namespace Project8_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            checkedListBox1.Items.Clear();
            string[] sArayItems = { "Excelent", "Good", "Satisfactory", "Unsatisfactory" };
            checkedListBox1.Items.Clear();
            for (int i = 0; i < sArayItems.GetLength(0); i++)
            {
                checkedListBox1.Items.Add(sArayItems[i]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (int index in checkedListBox1.CheckedIndices)
            {
                MessageBox.Show(index.ToString() + " Value " + checkedListBox1.Items[index].ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                MessageBox.Show("Value " + checkedListBox1.Items[i].ToString() + " State is " + checkedListBox1.GetItemCheckState(i).ToString());
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (int index in checkedListBox1.CheckedIndices)
            {
                checkedListBox1.Items.RemoveAt(index);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int count = 0;
            foreach (int index in checkedListBox1.CheckedIndices)
            {
                count++;
            }
            if (count == 4)
                MessageBox.Show("Value Selection Item 4 Selected");
            else
                MessageBox.Show("Value Selection Item 4 Not Selected");
        }
    }
}