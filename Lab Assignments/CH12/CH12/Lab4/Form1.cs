namespace Lab4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Game> gameList = new List<Game>()
        {
            new Game("Player Unknown's Battlegrounds (PUBG)", "Bluehole", 35),
            new Game("League of Legends", "Riot Games", 0),
            new Game("Call of Duty: Black Ops 3", "Activision", 60),
            new Game("Battlefield 4", "Electronic Arts (EA)", 20),
            new Game("Super Mario Odyssey", "Nintendo", 60),
        };
        int foundIndex = -1;
        private void SearchGame(string searchTerm)
        {
            bool found = false;
            for (int i = 0; i < gameList.Count; i++)
            {
                if (gameList[i].GetName().ToLower().Contains(searchTerm.ToLower()) || gameList[i].GetPublisher().ToLower().Contains(searchTerm.ToLower()))
                {
                    found = true;
                    foundIndex = i;
                }
                if(!found)
                {
                    lblGame.Text = "game not found";
                    lblPrice.Text = "";
                    lblPublisher.Text = "";
                }
            }
        }
        private void ShowGame()
        {
            lblGame.Text = $"Game: {gameList[foundIndex].GetName()}";
            lblPublisher.Text = $"Publisher: {gameList[foundIndex].GetPublisher()}";
            lblPrice.Text = $"Price: {gameList[foundIndex].GetPrice():C}";
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchGame(txtSearch.Text);
            ShowGame(); 
        }
    }
}
