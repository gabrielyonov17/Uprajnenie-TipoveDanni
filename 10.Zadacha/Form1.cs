namespace _10.Zadacha
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            int number = int.Parse(txtNumber.Text);

            if (number % 2 == 0)
            {
                lblResult.Text = "Числото е четно";
            }
            else
            {
                lblResult.Text = "Числото е нечетно";
            }
        }
    }
}
