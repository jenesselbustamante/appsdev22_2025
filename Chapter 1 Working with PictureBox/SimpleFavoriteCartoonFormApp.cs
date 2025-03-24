namespace SimpleFavoriteCartoonFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            string[] characters = { "Spongebob", "Patrick", "Mr. Krabs", "Sandy" };
            comboBox1.Items.AddRange(characters);
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Please Select a cartoon character first.");
            }

            string selectedItem = comboBox1.SelectedItem.ToString();

            switch (selectedItem)
            {
                case "Spongebob":
                    pictureBox1.Image = Image.FromFile(@"C:/Users/MM310/Downloads/190503220200-spongebob-squarepants-story-top.jpg");
                    break;
                case "Patrick":
                    pictureBox1.Image = Image.FromFile(@"C:/Users/MM310/Downloads/271cca205a35478452badb13912aeb95.jpg");
                    break;
                case "Mr. Krabs":
                    pictureBox1.Image = Image.FromFile(@"C:/Users/MM310/Downloads/1009c8c7faa8d7d98ea03d3ba18db47d.jpg");
                    break;
                case "Sandy":
                    pictureBox1.Image = Image.FromFile(@"C:/Users/MM310/Downloads/spongebob_squarepants_s4_e11_sandy_1_by_geedirosso_dhwsdpv-fullview.jpg");
                    break;
                default:
                    pictureBox1.Image = null;
                    break;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
