namespace EX2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnArithmatic_Click(object sender, EventArgs e)
        {
            try
            {
                int num = 25;
                int zero = 0;
                int division = num / zero;
            }
            catch (ArithmeticException ex)
            {
                MessageBox.Show("Arithmetic Error");
            }
        }

        private void btnFormat_Click(object sender, EventArgs e)
        {
            try
            {
                string message = "yes";
                double num = double.Parse(message);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Format Error");
            }
        }

        private void btnCast_Click(object sender, EventArgs e)
        {
            try
            {
                object obj = "yes";
                int num = (int)obj;
            }
            catch (InvalidCastException ex)
            {
                MessageBox.Show("Casting Error");
            }
        }

        private void btnNull_Click(object sender, EventArgs e)
        {
            string message = null;
            try
            {
                int number = message.Length;
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("Null Reference Error");
            }
        }
    }
}
