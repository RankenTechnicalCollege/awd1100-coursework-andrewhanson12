namespace Lab4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string[] movieList = new string[5]
            {
                "Lord of the Rings: Fellowship of the Ring",
                "Star Wars: The Empire Strikes Back",
                "The Dark Knight",
                "The Avengers",
                "John Wick"
            };
            string[] directorList = new string[5]
            {
                "Peter Jackson",
                "Irvin Kershner",
                "Christopher Nolan",
                "Joss Whedon",
                "Chad Stahelski",
            };
            string[] descriptionList = new string[5]
            {
                "An epic journey of hobbits and magic rings.",
                "Luke Skywalker trains as a jedi while the empire hunts down the rest of the crew.",
                "Batman takes on the Joker in the sequel to Batman Begins.",
                "A team of super heroes come together to face an extra terrestrial threat.",
                "A man turns back to his old self when his dog is killed.",
            };

            string userSearch = txtSearch.Text.ToLower();
            bool found = false;

            for (int i = 0; i < movieList.Length; i++)
            {
                if (movieList[i].ToLower().Contains(userSearch) || directorList[i].ToLower().Contains(userSearch))
                {
                    lblMovie.Text = movieList[i];
                    lblDirector.Text = directorList[i];
                    lblDescription.Text = descriptionList[i];
                    found = true;
                }
                if (!found)
                {
                    lblMovie.Text = "Movie not found";
                    lblDirector.Text = "";
                    lblDescription.Text = "";
                }
            }
        }
    }
}
