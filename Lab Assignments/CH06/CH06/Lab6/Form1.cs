namespace Lab6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string GetWood()
        {
            string woodType = txtWood.Text;

            if (woodType == "m")
            {
                woodType = "mahoganey";
            }
            else if (woodType == "o")
            {
                woodType = "oak";
            }
            else if (woodType == "p")
            {
                woodType = "pine";
            }
            else
            {
                woodType = "other";
            }
            return woodType;
        }

        private int GetDrawers()
        {
            int numDrawers = Convert.ToInt32(txtDrawers.Text);
            return numDrawers;
        }

        private double CalculateWoodCost(string woodType)
        {
            double woodCost;

            if (woodType == "pine")
            {
                woodCost = 100;
            }
            else if (woodType == "oak")
            {
                woodCost = 140;
            }
            else
            {
                woodCost = 180;
            }
            lblCostWood.Text = $"Cost of wood\n {woodCost:C}";
            return woodCost;
        }

        private double CalculateDrawerCost(int numDrawers)
        {
            double drawerCost = numDrawers * 30;
            lblCostDrawers.Text = $"Cost of drawers\n {drawerCost:C}";
            return drawerCost;
        }

        private double CalculateTotalCost(string woodType, int numDrawers)
        {
            double drawerCost = numDrawers * 30;
            double totalCost;
            if (woodType == "pine")
            {
                totalCost = drawerCost + 100;
            }
            else if (woodType == "oak")
            {
                totalCost = drawerCost + 140;
            }
            else
            {
                totalCost = drawerCost + 180;
            }
            lblTotal.Text = $"Total cost\n {totalCost:C}";
            return totalCost;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            CalculateWoodCost(GetWood());
            CalculateDrawerCost(GetDrawers());
            CalculateTotalCost(GetWood(), GetDrawers());
        }
    }
}
