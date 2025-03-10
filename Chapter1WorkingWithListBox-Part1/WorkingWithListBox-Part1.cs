namespace Working_with_ListBox_PartI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Get the textBox1 Text and Add to the listBox1
            if (!string.IsNullOrWhiteSpace(textBox1.Text) && !listBox1.Items.Contains(textBox1.Text))
            {

                listBox1.Items.Add(textBox1.Text);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                // Remove the selected item
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
            else
            {
                MessageBox.Show("Please select an item to remove.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}
