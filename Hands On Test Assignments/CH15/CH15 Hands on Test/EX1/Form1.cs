namespace EX1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private ILoan loan;
        private void btnCreate_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            double balance = Convert.ToDouble(txtAmount.Text);

            if (balance < 0)
            {
                lblError.Text = "Enter a valid number";
            }
            if (balance > 0 && rbShortTerm.Checked)
            {
                loan = new ShortTermLoan(name, balance);
                lblError.Text = "";
                grpManage.Visible = true;
                lblName.Text = loan.Name;
                lblLoan.Text = $"Short term loan of {loan.Balance:C}";
            }
            if (balance > 0 && rbLongTerm.Checked)
            {
                loan = new LongTermLoan(name, balance);
                lblError.Text = "";
                grpManage.Visible = true;
                lblName.Text = loan.Name;
                lblLoan.Text = $"Long term loan of {loan.Balance:C}";
            }
        }

        private void btnMakePayment_Click(object sender, EventArgs e)
        {
            loan.MakePayment();
            lblResult.Text = $"After the last payment the loan is down to {loan.Balance:C}";
            loan.ApplyInterest();
            lblResult.Text += $"\n After the last interest accumulation the loan is now {loan.Balance:C}";
        }
    }
}
