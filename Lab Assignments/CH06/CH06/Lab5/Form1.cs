namespace Lab5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string MaskNumber(string unmaskedCC, string replacementChar, int numDigitsToPreserve)
        {
            lblResult.Text = $"{replacementChar}-{numDigitsToPreserve}";
            return unmaskedCC;
        }

        private void btnMask_Click(object sender, EventArgs e)
        {
            MaskNumber(txtCcNumber.Text, "****-****-****", Convert.ToInt32(txtCcNumber.Text.Substring(txtCcNumber.MaxLength - 4, 4)));
        }
    }
}
