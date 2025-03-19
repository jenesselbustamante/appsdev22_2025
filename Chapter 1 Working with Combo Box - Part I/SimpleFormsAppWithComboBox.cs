namespace SimpleFormsAppWithComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string[] cuisinepartyList = { "Japanese", "HongKong", "Paris", "Filipino" };
            comboBox1.Items.AddRange(cuisinepartyList);

            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.SelectedIndex = 0;

            checkedListBox1.CheckOnClick = true;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] JapaneseFoodList = { "Ramen", "Sashimi", "Shabu-Shabu","Shushi"};
            string[] HongkongFoodList = { "Egg Tart", "Pineapple bun", "French toast", "Egg waffle" };
            string[] ParisFoodList = { "Macarons", "Crepes", "Croissants", "Baguette" };
            string[] FilipinoFoodList = { "Sinigang", "Sisig", "Adobo", "Letchon"};

            checkedListBox1.Items.Clear();

            if (comboBox1.SelectedItem.ToString().Contains("Japanese"))
            {
                checkedListBox1.Items.AddRange(JapaneseFoodList);
            }
            else if (comboBox1.SelectedItem.ToString().Contains("HongKong"))
            {
                checkedListBox1.Items.AddRange(HongkongFoodList);
            }
            else if (comboBox1.SelectedItem.ToString().Contains("Paris"))
            {
                checkedListBox1.Items.AddRange(ParisFoodList);
            }
            else if (comboBox1.SelectedItem.ToString().Contains("Filipino"))
            {
                checkedListBox1.Items.AddRange(FilipinoFoodList);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (var item in checkedListBox1.Items)
            {
                bool isSelected = checkedListBox1.GetItemChecked(checkedListBox1.Items.IndexOf(item));
                if (isSelected && !listBox1.Items.Contains(item))
                {
                    listBox1.Items.Add(item);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (checkedListBox1.Items.Count >= 1)
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}
