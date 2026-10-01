namespace _5.Zadacha
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double length = double.Parse(txtLength.Text);
            double width = double.Parse(txtWidth.Text);

            double area = length * width;

            lblArea.Text = "Лице: " + area;
        }
    }
}
