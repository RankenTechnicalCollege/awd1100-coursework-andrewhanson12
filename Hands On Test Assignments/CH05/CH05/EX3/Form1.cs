namespace EX3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double totalLength = Convert.ToDouble(txtLength.Text);
            double totalWidth = Convert.ToDouble(txtWidth.Text);
            double totalArea = totalLength * totalWidth;
            string weeklyFee;
            double totalCost;

            if (totalArea >= 600)
            {
                weeklyFee = "$50";
            }
            else if (totalArea >= 400 && totalArea < 600)
            {
                weeklyFee = "$35";
            }
            else
            {
                weeklyFee = "$25";
            }

            if (totalArea >= 600)
            {
                totalCost = 20 * 50;
            }
            else if (totalArea >= 400 && totalArea < 600)
            {
                totalCost = 20 * 35;
            }
            else
            {
                totalCost = 20 * 25;
            }

            lblArea.Text = $"Area: {totalArea} sq feet";
            lblWeeklyFee.Text = $"Weekley Fee: {weeklyFee}";
            lblSeasonLength.Text = "Season Length: 20 Weeks";
            lblTotal.Text = $"Total Cost: {totalCost:C}";
        }
    }
}
