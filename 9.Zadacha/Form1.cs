namespace _9.Zadacha
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            double hourlyWage = double.Parse(txtHourlyWage.Text);
            int hours = int.Parse(txtHours.Text);

            double salary = hourlyWage * hours;

            lblResult.Text = name + ", заплатата ти е: " + salary.ToString("F2") + " лв.";
        }
    }
}
