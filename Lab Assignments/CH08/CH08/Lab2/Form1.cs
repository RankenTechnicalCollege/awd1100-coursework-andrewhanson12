namespace Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int[] nightsStayed = new int[8]
            {
                1, 2, 3, 4, 5, 6, 7, 8,
            };
            int[] nightlyRate = new int[8]
            {
                200, 200, 180, 180, 160, 160, 160, 145,
            };

            int userNights = int.Parse(txtNightsStayed.Text);

            for (int i = 0; i < nightsStayed.Length; i++)
            {
                if (userNights == nightsStayed[i])
                {
                    lblNightlyRate.Text = $"{nightlyRate[i]:C}";
                    int totalCost = nightlyRate[i] * nightsStayed[i];
                    lblTotal.Text = $"{totalCost:C}";
                    break;
                }
                else if (userNights > 8)
                {
                    lblNightlyRate.Text = $"{nightlyRate[7]:C}";
                    int totCost = userNights * nightlyRate[7];
                    lblTotal.Text = $"{totCost:C}";
                    break;
                }
                else
                {
                    lblNightlyRate.Text = "Error";
                    lblTotal.Text = "Error";
                }
            }
        }
    }
}
