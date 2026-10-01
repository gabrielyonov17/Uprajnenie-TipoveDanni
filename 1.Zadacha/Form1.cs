namespace _1.Zadacha
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {

            int number1 = int.Parse(txtNumber1.Text);
            int number2 = int.Parse(txtNumber2.Text);

            int sum = number1 + number2;
            int difference = number1 - number2;
            int product = number1 * number2;

            lblSumResult.Text = sum.ToString();
            lblDifferenceResult.Text = difference.ToString();
            lblProductResult.Text = product.ToString();
        }
    }
}