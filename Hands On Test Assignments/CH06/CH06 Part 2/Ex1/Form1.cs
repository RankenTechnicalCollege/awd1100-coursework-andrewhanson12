namespace Ex1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double smallTotal = 0;
        double medTotal = 0;
        double largeTotal = 0;

        int smallCount = 0;
        int medCount = 0;
        int largeCount = 0;

        private void AddShirt(string size)
        {
            if (size == "small")
            {
                smallCount++;
                smallTotal += 9.99;
                lblSmCount.Text = $"{smallCount}";
            }
            if (size == "medium")
            {
                medCount++;
                medTotal += 10.99;
                lblMCount.Text = $"{medCount}";
            }
            if (size == "large")
            {
                largeCount++;
                largeTotal += 11.99;
                lblLgCount.Text = $"{largeCount}";
            }
        }
        private void ShowInvoice()
        {
            double subtotal = smallTotal + medTotal + largeTotal;
            double tax = subtotal * 0.07;
            double total = subtotal + tax;
            lblSubtotal.Text = $"Subtotal: {subtotal:C}";
            lblTax.Text = $"Tax: {tax:C}";
            lblTotal.Text = $"Total: {total:C}";
        }
        private void ClearOrder()
        {
            double smallTotal = 0;
            double medTotal = 0;
            double largeTotal = 0;
            int smallCount = 0;
            int medCount = 0;
            int largeCount = 0;
            lblLgCount.Text = "";
            lblMCount.Text = "";
            lblSmCount.Text = "";
            lblSubtotal.Text = "";
            lblTax.Text = "";
            lblTotal.Text = "";
        }
        private void btnSmall_Click(object sender, EventArgs e)
        {
            string size = "small";
            AddShirt(size);
            ShowInvoice();
        }

        private void btnMed_Click(object sender, EventArgs e)
        {
            string size = "medium";
            AddShirt(size);
            ShowInvoice();
        }

        private void btnLarge_Click(object sender, EventArgs e)
        {
            string size = "large";
            AddShirt(size);
            ShowInvoice();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearOrder();
        }
    }
}
