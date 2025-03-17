namespace SimpleFormsAppWithCheckedListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            string[] movie = { "Justice League", "Fantastica", "Blue Beetle", "Little Einsteins" };
            moviescheckedListBox.Items.AddRange(movie);
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var movie in moviescheckedListBox.Items)
            {
                bool isSelected = moviescheckedListBox.GetItemChecked(moviescheckedListBox.Items.IndexOf(movie));
                if (isSelected && !movieslistBox.Items.Contains(movie))
                {
                    {
                        movieslistBox.Items.Add(movie);
                    }
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (movieslistBox.Items.Count >= 1)
            {
                movieslistBox.Items.Remove
               (movieslistBox.SelectedItem);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            movieslistBox.Items.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}