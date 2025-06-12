namespace Lab1
{
    public partial class deliveryCharge : Form
    {
        public deliveryCharge()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string[] zipCode = new string[10]
            {
                "63101",
                "63103",
                "63105",
                "63109",
                "63113",
                "63118",
                "63130",
                "63133",
                "63136",
                "63137",
            };
            string[] deliveryCost = new string[10]
            {
                "$20",
                "$12",
                "$25",
                "$15",
                "$10",
                "$23",
                "$18",
                "$20",
                "$17",
                "$12",
            };

            string zipSearch = txtZip.Text.Trim();

            for (int i = 0; i < zipCode.Length; i++)
            {
                if (zipCode[i] == zipSearch)
                {
                    lblResult.Text = deliveryCost[i];
                    break;
                }
                else
                {
                    lblResult.Text = "Zip code not found";
                }
            }
        }
    }
}
