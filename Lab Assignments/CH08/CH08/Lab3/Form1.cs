namespace Lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string[] gameList = new string[5]
            {
                "Player Unknown's Battlegrounds (PUBG)",
                "League of Legends",
                "Call of Duty: Black Ops 3",
                "Battlefield 4",
                "Super Mario Odyssey",
            };
            string[] pubList = new string[5]
            {
                "Bluehole",
                "Riot Games",
                "Activision",
                "Electronic Arts (EA)",
                "Nintendo",
            };
            string[] priceList = new string[5]
            {
                "$35",
                "$0",
                "$60",
                "$20",
                "$60",
            };

            string userSearch = txtSearch.Text.ToLower();
            bool found = false;

            for (int i = 0; i < gameList.Length; i++)
            {
                if (gameList[i].ToLower().Contains(userSearch) || pubList[i].ToLower().Contains(userSearch))
                {
                    lblGame.Text = gameList[i];
                    lblPublisher.Text = pubList[i];
                    lblPrice.Text = priceList[i];
                    found = true;
                }
                if (!found)
                {
                    lblGame.Text = "Game not found";
                    lblPrice.Text = "";
                    lblPublisher.Text = "";
                }
            }
        }
    }
}
