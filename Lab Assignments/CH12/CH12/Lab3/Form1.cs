namespace Lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Account> accountList = new List<Account>()
        {
            new Account("123-456-789", "1234", "John Smith", 10000),
            new Account("234-567-891", "5678", "Jack Reacher", 0),
            new Account("345-678-912", "9123", "Eric Cartman", 35000),
        };
        private void Login(string accountNum, string pin)
        {
            bool found = false;
            for (int i = 0; i < accountList.Count; i++)
            {
                if (!found)
                {
                    lblError.Text = "User not found";
                }
                if (accountNum == accountList[i].GetAccountNumber() && pin == accountList[i].GetPin())
                {
                    lblWelcome.Text = $"Welcome {accountList[i].GetName()}";
                    lblBalance.Text = $"{accountList[i].GetBalance():C}";
                    lblError.Text = "";
                    lblDeposit.Visible = true;
                    lblWithdrawl.Visible = true;
                    txtDeposit.Visible = true;
                    txtWithdrawl.Visible = true;
                    btnDeposit.Visible = true;
                    btnWithdrawl.Visible = true;
                    btnLogout.Visible = true;
                    found = true;
                }
            }
        }
        private void Logout()
        {
            txtAccountNum.Text = string.Empty;
            txtPinNum.Text = string.Empty;
            lblWelcome.Text = string.Empty;
            lblBalance.Text = string.Empty;
            txtDeposit.Text = string.Empty;
            txtWithdrawl.Text = string.Empty;
            lblDeposit.Visible = false;
            lblWithdrawl.Visible = false;
            txtDeposit.Visible = false;
            txtWithdrawl.Visible = false;
            btnDeposit.Visible = false;
            btnWithdrawl.Visible = false;
            btnLogout.Visible = false;
        }

        private void MakeDeposit(decimal depositAmount)
        {
            Login(txtAccountNum.Text, txtPinNum.Text);
            for (int i = 0; i < accountList.Count; i++)
            {
                if (txtAccountNum.Text == accountList[i].GetAccountNumber() && txtPinNum.Text == accountList[i].GetPin())
                {
                    accountList[i].SetBalance(accountList[i].GetBalance() + depositAmount);
                    lblBalance.Text = $"{accountList[i].GetBalance():C}";
                }
            }
        }
        private void MakeWithdrawl(decimal withdrawlAmount)
        {
            Login(txtAccountNum.Text, txtPinNum.Text);
            for (int i = 0; i < accountList.Count; i++)
            {
                if (txtAccountNum.Text == accountList[i].GetAccountNumber() && txtPinNum.Text == accountList[i].GetPin())
                {
                    accountList[i].SetBalance(accountList[i].GetBalance() - withdrawlAmount);
                    lblBalance.Text = $"{accountList[i].GetBalance():C}";
                }
            }
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login(txtAccountNum.Text, txtPinNum.Text);
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            MakeDeposit(Convert.ToDecimal(txtDeposit.Text));
        }

        private void btnWithdrawl_Click(object sender, EventArgs e)
        {
            MakeWithdrawl(Convert.ToDecimal(txtWithdrawl.Text));
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Logout();
        }
    }
}
