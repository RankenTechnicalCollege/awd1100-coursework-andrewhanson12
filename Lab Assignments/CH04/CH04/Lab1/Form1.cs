namespace Lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMilesToKm_Click(object sender, EventArgs e)
        {
            double amountMiles = Convert.ToDouble(txtMiles.Text);
            double convertKm = amountMiles * 1.6;
            lblResult.Text = $"{amountMiles} miles is {convertKm}";
        }

        private void btnKmToMiles_Click(object sender, EventArgs e)
        {
            double amountKm = Convert.ToDouble(txtKilometers.Text);
            double convertMiles = amountKm / 1.6;
            lblResult.Text = $"{amountKm} kilometers is {convertMiles}";
        }
    }
}
