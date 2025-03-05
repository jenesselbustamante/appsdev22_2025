namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fNameValue = FirstName.Text;
            string mNameValue = MiddleName.Text;
            string lNameValue = LastName.Text;
            string suffixValue = Suffix.Text;

            DialogResult result = MessageBox.Show("Are you want to submit?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show($"Hello There! {fNameValue} {mNameValue} {lNameValue} {suffixValue}!", "Greetings!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } 

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
