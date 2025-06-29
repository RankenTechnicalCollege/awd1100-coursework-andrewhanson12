namespace Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void SortWords(string[] unsortedWords)
        {
            string result = "";
            Array.Sort(unsortedWords);
            for (int i = 0; i < unsortedWords.Length; i++)
            {
                result += unsortedWords[i] + "";
                lblResult.Text = result;
            }
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            string phrase = txtPhrase.Text;
            char[] chars = { ' ', ',', '.', };
            string[] unsortedWords = phrase.Split(chars);
            SortWords(unsortedWords);

        }
    }
}
