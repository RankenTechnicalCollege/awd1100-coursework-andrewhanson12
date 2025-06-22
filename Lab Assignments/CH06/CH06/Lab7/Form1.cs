namespace Lab7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] accountNumArray = new string[3]
        {
            "123-456-789",
            "234-567-891",
            "345-678-912",
        };
        string[] pinNumArray = new string[3]
        {
            "1234",
            "5678",
            "9123",
        };
        string[] accountName = new string[3]
        {
            "John Smith",
            "Jack Reacher",
            "Eric Cartman",
        };
        decimal[] accountBalance = new decimal[3]
        {
            10000,
            0,
            35000,
        };
        private void Login(string accountNum, string pin)
        {
            bool found = false;
            for (int i = 0; i < accountNumArray.Length; i++)
            {
                if (!found)
                {
                    lblError.Text = "User not found";
                }
                if (accountNum == accountNumArray[i] && pin == pinNumArray[i])
                {
                    lblWelcome.Text = $"Welcome {accountName[i]}";
                    lblBalance.Text = $"{accountBalance[i]:C}";
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
            for (int i = 0; i < accountNumArray.Length; i++)
            {
                if (txtAccountNum.Text == accountNumArray[i] && txtPinNum.Text == pinNumArray[i])
                {
                    accountBalance[i] += depositAmount;
                    lblBalance.Text = $"{accountBalance[i]:C}";
                }
            }
        }
        private void MakeWithdrawl(decimal withdrawlAmount)
        {
            Login(txtAccountNum.Text, txtPinNum.Text);
            for (int i = 0; i < accountNumArray.Length; i++)
            {
                if (txtAccountNum.Text == accountNumArray[i] && txtPinNum.Text == pinNumArray[i])
                {
                    accountBalance[i] -= withdrawlAmount;
                    lblBalance.Text = $"{accountBalance[i]:C}";
                }
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login(txtAccountNum.Text, txtPinNum.Text);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Logout();
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            MakeDeposit(Convert.ToDecimal(txtDeposit.Text));
        }

        private void btnWithdrawl_Click(object sender, EventArgs e)
        {
            MakeWithdrawl(Convert.ToDecimal(txtWithdrawl.Text));
        }
    }
}
