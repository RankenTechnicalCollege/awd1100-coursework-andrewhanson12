namespace Lab4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        double danielleSales = 0;
        double francisSales = 0;
        double edwardSales = 0;
        double totalSales = 0;

        private void btnDanielle_Click(object sender, EventArgs e)
        {
            while (true)
            {
                double salesEntered = Convert.ToDouble(txtSale.Text);
                danielleSales += salesEntered;
                danielleSales += totalSales;
                lblDanielleSales.Text = $"Danielle Sales: {danielleSales:C}";
                lblEdwardSales.Text = $"Edward Sales: {edwardSales:C}";
                lblFrancisSales.Text = $"Francis Sales: {francisSales:C}";
                lblTotal.Text = $"Total Sales: {totalSales:C}";

                if ( danielleSales > francisSales &&  danielleSales > edwardSales )
                {
                    lblWinner.Text = "Danielle has the most sales";
                }
                else if ( francisSales > edwardSales && francisSales > danielleSales)
                {
                    lblWinner.Text = "Francis has the most sales";
                }
                else if ( edwardSales > danielleSales && edwardSales > francisSales )
                {
                    lblWinner.Text = "Edward has the most sales";
                } 
            }
        }

        private void btnEdward_Click(object sender, EventArgs e)
        {
            while (true)
            {
                double salesEntered = Convert.ToDouble(txtSale.Text);
                edwardSales += salesEntered;
                edwardSales += totalSales;
                lblDanielleSales.Text = $"Danielle Sales: {danielleSales:C}";
                lblEdwardSales.Text = $"Edward Sales: {edwardSales:C}";
                lblFrancisSales.Text = $"Francis Sales: {francisSales:C}";
                lblTotal.Text = $"Total Sales: {totalSales:C}";

                if (danielleSales > francisSales && danielleSales > edwardSales)
                {
                    lblWinner.Text = "Danielle has the most sales";
                }
                else if (francisSales > edwardSales && francisSales > danielleSales)
                {
                    lblWinner.Text = "Francis has the most sales";
                }
                else if (edwardSales > danielleSales && edwardSales > francisSales)
                {
                    lblWinner.Text = "Edward has the most sales";
                }
            }
        }
        

        private void btnFrancis_Click(object sender, EventArgs e)
        {
            while (true)
            {
                double salesEntered = Convert.ToDouble(txtSale.Text);
                francisSales += salesEntered;
                francisSales += totalSales;
                lblDanielleSales.Text = $"Danielle Sales: {danielleSales:C}";
                lblEdwardSales.Text = $"Edward Sales: {edwardSales:C}";
                lblFrancisSales.Text = $"Francis Sales: {francisSales:C}";
                lblTotal.Text = $"Total Sales: {totalSales:C}";

                if (danielleSales > francisSales && danielleSales > edwardSales)
                {
                    lblWinner.Text = "Danielle has the most sales";
                }
                else if (francisSales > edwardSales && francisSales > danielleSales)
                {
                    lblWinner.Text = "Francis has the most sales";
                }
                else if (edwardSales > danielleSales && edwardSales > francisSales)
                {
                    lblWinner.Text = "Edward has the most sales";
                }
            }
        }
        
    }
}
