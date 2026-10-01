namespace _3.Zadacha
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            int age = int.Parse(txtAge.Text);

            if (age >= 18)
            {
                lblResult.Text = "Пълнолетен";
            }
            else
            {
                lblResult.Text = "Непълнолетен";
            }
        }
    }
}