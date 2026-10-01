namespace _2.Zadacha
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnWelcome_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;

            lblWelcome.Text = "Добре дошъл, " + name;
        }
    }
}
