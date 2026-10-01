namespace _7.Zadacha
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int x = int.Parse(txtX.Text);
            int y = int.Parse(txtY.Text);

            int remainder = x % y;

            lblResult.Text = "Остатък от делението на " + x + " и " + y + " е: " + remainder;
        }
    }
}
