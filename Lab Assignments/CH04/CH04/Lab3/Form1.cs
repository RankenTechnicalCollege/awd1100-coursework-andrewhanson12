namespace Lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            lblYear.Visible = true;
            lblYearOne.Visible = true;
            lblYearTwo.Visible = true;
            lblYearThree.Visible = true;

            string nameOne = txtNameOne.Text;
            string nameTwo = txtNameTwo.Text;
            string nameThree = txtNameThree.Text;

            double salaryOne = Convert.ToDouble(txtSalaryOne.Text);
            double salaryTwo = Convert.ToDouble(txtSalaryTwo.Text);
            double salaryThree = Convert.ToDouble(txtSalaryThree.Text);

            double raiseOne = salaryOne * 1.04;
            double raiseTwo = salaryTwo * 1.04;
            double raiseThree = salaryThree * 1.04;

            double raiseFour = raiseOne * 1.04;
            double raiseFive = raiseTwo * 1.04;
            double raiseSix = raiseThree * 1.04;

            lblNameOne.Text = nameOne;
            lblNameTwo.Text = nameTwo;
            lblNameThree.Text = nameThree;

            lblSalaryOne.Text = $"{salaryOne:C}";
            lblSalaryTwo.Text = $"{salaryTwo:C}";
            lblSalaryThree.Text = $"{salaryThree:C}";

            lblRaiseOne.Text = $"{raiseOne:C}";
            lblRaiseTwo.Text = $"{raiseTwo:C}";
            lblRaiseThree.Text = $"{raiseThree:C}";

            lblRaiseFour.Text = $"{raiseFour:C}";
            lblRaiseFive.Text = $"{raiseFive:C}";
            lblRaiseSix.Text = $"{raiseSix:C}";
        }
    }
}
