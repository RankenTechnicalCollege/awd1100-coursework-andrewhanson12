namespace Lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int CountVowels(string phrase)
        {
            int vowelCount = 0;

            for (int i = 0; i < phrase.ToLower().Length; i++)
            {
                switch (phrase[i])
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
            return vowelCount;
        }
        private void btnEnter_Click(object sender, EventArgs e)
        {
            CountVowels(txtPhrase.Text);
        }
    }
}
