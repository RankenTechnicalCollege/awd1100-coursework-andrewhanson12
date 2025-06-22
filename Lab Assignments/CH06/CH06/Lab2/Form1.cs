namespace Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool IsStudentAccepted(float gpa, int testScore)
        {
            if (gpa >= 3 && testScore >= 60)
            {
                lblResult.Text = "Accept";
            }
            else if (gpa < 3 && testScore >= 80)
            {
                lblResult.Text = "Accept";
            }
            else
            {
                lblResult.Text = "Reject";
            }
                return true;
        }

        private void btnAdmit_Click(object sender, EventArgs e)
        {
            IsStudentAccepted(float.Parse(txtGPA.Text), Convert.ToInt32(txtTestScore.Text));
        }
    }
}
