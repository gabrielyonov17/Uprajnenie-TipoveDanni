namespace _6.Zadacha
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnGreeting_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;

            string fullName = firstName + " " + lastName;

            lblResult.Text = "Здравей, " + fullName + "!";
        }
    }
}