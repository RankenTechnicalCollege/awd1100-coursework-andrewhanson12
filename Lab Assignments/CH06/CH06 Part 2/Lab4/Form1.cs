namespace Lab4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void CalculateStats(out int min, out int max, out double sum, out double avg, params int[] numbers)
        {
            min = 0;
            max = 0;
            sum = 0.0;
            avg = 0.0;
            int numberEntered = int.Parse(txtNumber.Text);
            numbers = new int[numberEntered];
            for (int i = 0; i < numbers.Length; i++)
            {
                lblCount.Text = $"Numbers Entered: {numbers.Length}";
                min = numbers.Min();
                lblMin.Text = $"Lowest: {min}";
                max = numbers.Max();
                lblMax.Text = $"Highest: {max}";
                sum = numbers.Sum();
                lblSum.Text = $"Sum: {sum}";
                avg = numbers.Average();
                lblAverage.Text = $"Average: {avg}";
            } 
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            CalculateStats(out int min, out int max, out double sum, out double avg, Convert.ToInt32(txtNumber.Text));
        }
    }
}
