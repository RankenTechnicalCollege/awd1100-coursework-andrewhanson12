namespace EX1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private TestStatistics _stats = new TestStatistics();

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (float.TryParse(txtScore.Text, out float score))
            {
                try
                {
                    _stats.AddScore(score);
                    lblResult.Text = $"Number of scores: {_stats.Count}\n";
                    lblResult.Text = $"Sum of scores: {_stats.Sum}\n";
                    lblResult.Text = $"Average score: {_stats.Average}\n";
                    lblResult.Text = $"Highest score: {_stats.Max}\n";
                    lblResult.Text = $"Lowest score: {_stats.Min}";
                    lblError.Text = "";
                }
                catch (ArgumentException)
                {
                    lblError.Text = "Please enter a number between 0 & 100.";
                }
            }
        }
    }
}
