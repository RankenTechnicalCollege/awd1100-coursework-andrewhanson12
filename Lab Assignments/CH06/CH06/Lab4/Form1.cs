namespace Lab4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int CalculateTotalArea(int length, int width)
        {
            int height = 9;
            int totalArea = (length * height * 2) + (width * height * 2);
            lblArea.Text = totalArea.ToString();
            return totalArea;
        }
        private double CalculatePaintEstimate(int totalArea)
        {
            double totalCost = totalArea * 6;
            lblTotal.Text = $"{totalCost:C}";
            return totalCost;
        }
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int totalArea = CalculateTotalArea(Convert.ToInt32(txtLength.Text), Convert.ToInt32(txtWidth.Text));
            CalculatePaintEstimate(totalArea);
        }
    }
}
