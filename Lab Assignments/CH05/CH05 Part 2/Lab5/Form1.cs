namespace Lab5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            string phraseEntered = txtPhrase.Text.ToLower();
            int vowelCount = 0;

            for (int i = 0; i < phraseEntered.Length; i++)
            {
                switch (phraseEntered[i])
                {
                    case 'a':
                    case 'e':
                    case 'i':
                    case 'o':
                    case 'u':
                        vowelCount++;
                        break;

                }
            }
            lblResult.Text = $"There are {vowelCount} vowels in your phrase.";
        }
    }
}
