namespace _8.Zadacha
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double grade1 = double.Parse(txtGrade1.Text);
            double grade2 = double.Parse(txtGrade2.Text);
            double grade3 = double.Parse(txtGrade3.Text);

            double average = (grade1 + grade2 + grade3) / 3;

            lblResult.Text = "Среден успех: " + average.ToString("F2");
        }
    }
}
