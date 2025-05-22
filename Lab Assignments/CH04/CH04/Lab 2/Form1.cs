namespace Lab_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double eggOne = Convert.ToDouble(txtEggsOne.Text);
            double eggTwo = Convert.ToDouble(txtEggsTwo.Text);
            double eggThree = Convert.ToDouble(txtEggsThree.Text);
            double eggFour = Convert.ToDouble(txtEggsFour.Text);

            double totalEggs = eggOne + eggTwo + eggThree + eggFour;

            double eggsDozen = Math.Round(totalEggs / 12, 0);

            double eggRemainder = totalEggs % 12;

            lblResult.Text = $"{totalEggs} eggs total, or {eggsDozen} and {eggRemainder} eggs.";
        }
    }
}
