namespace EX2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            double numberGrade = Convert.ToDouble(txtNumericGrade.Text);
            string letterGrade;

            if (numberGrade > 3.0)
            {
                letterGrade = "A";
            }
            else if (numberGrade > 2.0 && numberGrade <= 3.0)
            {
                letterGrade = "B";
            }
            else if (numberGrade > 1.0 && numberGrade <= 2.0)
            {
                letterGrade = "C";
            }
            else if (numberGrade > 0.0 && numberGrade <= 1.0)
            {
                letterGrade = "D";
            }
            else
            {
                letterGrade = "F";
            }

            lblResult.Text = $"Your Grade: {letterGrade}";
        }
    }
}
