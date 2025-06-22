using Microsoft.VisualBasic.Devices;

namespace EX1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] bookArray = new string[5]
        {
            "The Great Gatsby",
            "War and Peace",
            "Moby-Dick",
            "Hamlet",
            "Pride and Prejudice",
        };
        string[] authorArray = new string[5]
        {
            "F. Scott Fitzgerald",
            "Leo Tolstoy",
            "Herman Melville",
            "William Shakespeare",
            "Jane Austen",
        };
        string[] keywordArray = new string[5]
        {
            "The story of eccentric millionaire Jay Gatsby and his pursuit of his lost love.",
            "A fictional story about the 1812 French invasion of Russia.",
            "The story of a sailor’s relentless hunt for a white whale.",
            "A Shakespearean tragedy about a young man coming home from college after the murder of his father.",
            "A comedic story of love and life in Old England.",
        };
        string[] isbnArray = new string[5]
        {
            "978-1847496140",
            "978-1400079988",
            "978-1503280786",
            "978-1973844402",
            "978-0141439518",
        };
        private void ShowBook(int index)
        {
            lblAuthor.Text = authorArray[index];
            lblName.Text = bookArray[index];
            lblDescription.Text = keywordArray[index];
            lblISBN.Text = isbnArray[index];
        }
        private string SearchByAuthor(string authorName)
        {
            bool found = false;
            for (int i = 0; i < authorArray.Length; i++)
            {
                if (authorArray[i].ToLower().Contains(authorName.ToLower()))
                {
                    ShowBook(i);
                    found = true;
                }
                if (!found)
                {
                    lblAuthor.Text = "Book not found";
                    lblName.Text = string.Empty;
                    lblDescription.Text = string.Empty;
                    lblISBN.Text = string.Empty;
                }
            }
            return authorName;
        }
        private string SearchByIsbn(string isbnNumber)
        {
            bool found = false;
            for (int i = 0; i < isbnNumber.Length; i++)
            {
                if (isbnArray[i].Contains(isbnNumber))
                {
                    ShowBook(i);
                    found = true;
                }
                if (!found)
                {
                    lblAuthor.Text = "Book not found";
                    lblName.Text = string.Empty;
                    lblDescription.Text = string.Empty;
                    lblISBN.Text = string.Empty;
                }
            }
            return isbnNumber;
        }
        private string SearchByKeyword(string keyword)
        {
            bool found = false;
            for (int i = 0; i < keyword.Length; i++)
            {
                if (keywordArray[i].ToLower().Contains(keyword.ToLower()))
                {
                    ShowBook(i);
                    found = true;
                }
                if (!found)
                {
                    lblAuthor.Text = "Book not found";
                    lblName.Text = string.Empty;
                    lblDescription.Text = string.Empty;
                    lblISBN.Text = string.Empty;
                }
            }
            return keyword;
        }
        private void btnAuthor_Click(object sender, EventArgs e)
        {
            SearchByAuthor(txtAuthor.Text);
        }

        private void btnISBN_Click(object sender, EventArgs e)
        {
            SearchByIsbn(txtISBN.Text);
        }

        private void btnKeyword_Click(object sender, EventArgs e)
        {
            SearchByKeyword(txtKeyword.Text);
        }
    }
}
