namespace _11.Zadacha
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string input = txtInput.Text;

            int number = int.Parse(input);

            int result = number + 10;

            lblResult.Text = "Резултат: " + result;
        }
    }
}