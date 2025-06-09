namespace Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            List<double> testList = new List<double>();
            double testScore = double.Parse(txtTestScore.Text);
            while (true)
            {
                if (testScore >= 0 && testScore <= 100)
                {
                    testList.Add(testScore);
                }
                if (testList.Count > 0)
                {
                    double sum = 0;
                    double min = testList[0];
                    double max = testList[0];
                    foreach (double d in testList)
                    {
                        sum += d;
                        if (d < min) min = d;
                        if (d > max) max = d;
                    }
                    double average = sum / testList.Count;
                    lblAverageScore.Text = $"Average: {average}";
                    lblHighScore.Text = $"Highest Score: {max}";
                    lblLowScore.Text = $"Lowest Score: {min}";
                    lblNumScores.Text = $"Number of Scores: {testList.Count}";
                    lblSumScores.Text = $"Sum: {sum}";
                }
            }
        }
    }
}
