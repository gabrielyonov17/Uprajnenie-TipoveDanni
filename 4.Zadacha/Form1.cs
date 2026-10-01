namespace _4.Zadacha
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            double celsius = double.Parse(txtCelsius.Text);

            double fahrenheit = celsius * 1.8 + 32;

            lblFahrenheit.Text = "Температура във Фаренхайт: " + fahrenheit + "°F";
        }
    }
}