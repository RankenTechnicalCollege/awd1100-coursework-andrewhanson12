namespace Ex2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] discountCode = new string[3]
        {
            "8264",
            "5679",
            "6483",
        };
        float[] discountPercent = new float[3]
        {
            0.30f,
            0.20f,
            0.10f,
        };
        private float CheckDiscountCode(string code)
        {
            for (int i = 0; i < discountCode.Length; i++)
            {
                if (discountCode[i] == code)
                {
                    lblDiscount.Text = "Discount applied";
                    return discountPercent[i];
                }
            }
            lblDiscount.Text = "Invalid code";
            return 0;
        }
        private void ShowInvoice(int quantity, float discountPercentage)
        {
            float price = 13.75f;
            float discountTotal = 13.75f;
            if (discountPercentage > 0)
            {
                discountTotal *= discountPercentage;
                price -= discountTotal;
            }
            float subtotal = quantity * price;
            float tax = subtotal * 0.08f;
            float total = subtotal + tax;
            lblQuantity.Text = $"{quantity} shirts at {price:C}";
            lblSubtotal.Text = $"Subtotal: {subtotal:C}";
            lblTax.Text = $"Tax: {tax:C}";
            lblTotal.Text = $"Total: {total:C}";
        }
        private void btnOrder_Click(object sender, EventArgs e)
        {
            CheckDiscountCode(txtDiscount.Text);
            ShowInvoice(Convert.ToInt32(txtQuantity.Text), CheckDiscountCode(txtDiscount.Text));
        }
    }
}
