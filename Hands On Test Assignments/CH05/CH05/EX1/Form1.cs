namespace EX1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            double inchEntered = Convert.ToDouble(txtInches.Text);
            const double cmPerInch = 2.54;
            double cmConverterd = inchEntered * cmPerInch;

            lblResult.Text = $"{inchEntered} inches is {cmConverterd} centimeters.";
        }
    }
}
