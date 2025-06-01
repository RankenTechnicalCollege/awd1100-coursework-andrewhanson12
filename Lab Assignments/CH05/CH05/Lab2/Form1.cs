namespace Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEstimate_Click(object sender, EventArgs e)
        {
            double windSpeed = Convert.ToDouble(txtWindSpeed.Text);

            if (windSpeed >= 157)
            {
                lblResult.Text = "Category 5";
            }
            else if (windSpeed >= 130)
            {
                lblResult.Text = "Category 4";
            }
            else if (windSpeed >= 111)
            {
                lblResult.Text = "Category 3";
            }
            else if (windSpeed >= 96)
            {
                lblResult.Text = "Category 2";
            }
            else if (windSpeed >= 74)
            {
                lblResult.Text = "Category 1";
            }
            else
            {
                lblResult.Text = "No Hurricane";
            }
        }
    }
}
