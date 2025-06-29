namespace Lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string ParseBid(string bidString)
        {
            bidString = bidString.Replace("dollars", "").Replace("dollar", "").Replace("$", "").ToLower().Trim();
            if (double.TryParse(bidString, out double bid))
            {
                if (bid >= 10)
                {
                    return lblResult.Text = $"Your bid of {bid:C} was accepted";
                }
                else
                {
                    return lblResult.Text = "Invalid Bid";
                }
            }
            else
            {
                return lblResult.Text = "Invalid Bid";
            }
        }

        private void btnBid_Click(object sender, EventArgs e)
        {
            ParseBid(txtBid.Text);
        }
    }
}
