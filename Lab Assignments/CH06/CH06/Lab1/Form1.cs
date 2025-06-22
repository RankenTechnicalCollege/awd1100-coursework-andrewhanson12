namespace Lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GenerateFortune()
        {
            string[] fortuneArray = new string[8]
            {
                "Birthdays are like friends. The more you have the better.",
                "Your smile is a treasure to all who know you.",
                "You never hesitate to tackle the most difficult problems.",
                "The most obvious solution is not always the best.",
                "If you want the rainbow, you will have to tolerate the rain.",
                "The early bird gets the worm, but the second mouse gets the cheese.",
                "From listening comes wisdom and from speaking repentance.",
                "A smile is your personal welcome mat.",
            };

            Random rand = new Random();
            var randomFortune = fortuneArray.OrderBy(x => rand.Next()).Take(2).ToArray();
            lblResult.Text = $"{randomFortune[0]}\n{randomFortune[1]}";
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            GenerateFortune();
        }
    }
}
