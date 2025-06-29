namespace Lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void Reverse4(ref int num1, ref int num2, ref int num3, ref int num4)
        {
            txtNumOne.Text = $"{num4}";
            txtNumTwo.Text = $"{num3}";
            txtNumThree.Text = $"{num2}";
            txtNumFour.Text = $"{num1}";
        }

        private void btnReverse_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(txtNumOne.Text);
            int num2 = Convert.ToInt32(txtNumTwo.Text);
            int num3 = Convert.ToInt32(txtNumThree.Text);
            int num4 = Convert.ToInt32(txtNumFour.Text);
            Reverse4(ref num1, ref num2, ref num3, ref num4);
        }
    }
}
