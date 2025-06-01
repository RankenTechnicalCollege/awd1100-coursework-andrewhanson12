namespace Lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdmit_Click(object sender, EventArgs e)
        {
            double studentGpa = Convert.ToDouble(txtGPA.Text);
            double studentTest = Convert.ToDouble(txtTestScore.Text);

            if (studentGpa >= 3.0 && studentTest >= 60)
            {
                lblResult.Text = "Accept";
            }
            else if (studentGpa < 3.0 && studentTest >= 80)
            {
                lblResult.Text = "Accept";
            }
            else
            {
                lblResult.Text = "Reject";
            }
        }
    }
}
