namespace Lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double compScoreCounter = 0;
        double playerScoreCounter = 0;

        private void btnRock_Click(object sender, EventArgs e)
        {
            Random randGenerator = new Random();
            int num1 = randGenerator.Next(1, 4);

            if (num1 == 1)
            {
                lblPlayerChoice.Text = "You chose ROCK";
                lblComputerChoice.Text = "Computer chose ROCK";
                lblWinRound.Text = "DRAW";
                if (compScoreCounter == 2)
                {
                    lblWinner.Text = "Computer Wins!";
                }
                if (playerScoreCounter == 2)
                {
                    lblWinner.Text = "Player Wins!";
                }

            }

            else if (num1 == 2)
            {
                lblPlayerChoice.Text = "You Chose Rock";
                lblComputerChoice.Text = "Computer Chose Paper";
                lblWinRound.Text = "Paper Wins";
                compScoreCounter++;
                lblCompScore.Text = $"Computer Score: {compScoreCounter}";
                if (playerScoreCounter == 2)
                {
                    lblWinner.Text = "Player Wins!";
                }
                if (compScoreCounter == 2)
                {
                    lblWinner.Text = "Computer Wins!";
                }
            }

            else if (num1 == 3)
            {
                lblPlayerChoice.Text = "You Chose Rock";
                lblComputerChoice.Text = "Computer Chose Scissors";
                lblWinRound.Text = "Rock Wins";
                playerScoreCounter++;
                lblPlayerScore.Text = $"Player Score: {playerScoreCounter}";
                if (playerScoreCounter == 2)
                {
                    lblWinner.Text = "Player Wins!";
                }
                if (compScoreCounter == 2)
                {
                    lblWinner.Text = "Computer Wins!";
                }
            }

        }

        private void btnPaper_Click(object sender, EventArgs e)
        {
            Random randGenerator = new Random();
            int num2 = randGenerator.Next(1, 4);
            if (num2 == 1)
            {
                lblPlayerChoice.Text = "You Chose Paper";
                lblComputerChoice.Text = "Computer Chose Rock";
                lblWinRound.Text = "Paper Wins";
                playerScoreCounter++;
                lblPlayerScore.Text = $"Player Score: {playerScoreCounter}";
                if (playerScoreCounter == 2)
                {
                    lblWinner.Text = "Player Wins";
                }
                if (compScoreCounter == 2)
                {
                    lblWinner.Text = "Computer Wins";
                }
            }

            else if (num2 == 2)
            {
                lblPlayerChoice.Text = "You Chose Paper";
                lblComputerChoice.Text = "Computer Chose Paper";
                lblWinRound.Text = "DRAW";
                if (compScoreCounter == 2)
                {
                    lblWinner.Text = "Computer Wins!";
                }
                if (playerScoreCounter == 2)
                {
                    lblWinner.Text = "Player Wins!";
                }
            }

            else if (num2 == 3)
            {
                lblPlayerChoice.Text = "You Chose Paper";
                lblComputerChoice.Text = "Computer Chose Scissors";
                lblWinRound.Text = "Scissors Wins";
                compScoreCounter++;
                lblCompScore.Text = $"Computer Score: {compScoreCounter}";
                if (compScoreCounter == 2)
                {
                    lblWinner.Text = "Computer Wins!";
                }
                if (playerScoreCounter == 2)
                {
                    lblWinner.Text = "Player Wins!";
                }
            }
        }

        private void btnScissors_Click(object sender, EventArgs e)
        {
            Random randGenerator = new Random();
            int num3 = randGenerator.Next(1, 4);
            if (num3 == 1)
            {
                lblPlayerChoice.Text = "You Chose Scissors";
                lblComputerChoice.Text = "Computer Chose Rock";
                lblWinRound.Text = "Rock Wins";
                compScoreCounter++;
                lblCompScore.Text = $"Computer Score {compScoreCounter}";
                if (compScoreCounter == 2)
                {
                    lblWinner.Text = "Computer Wins!";
                }
                if (playerScoreCounter == 2)
                {
                    lblWinner.Text = "Player Wins!";
                }
            }

            else if (num3 == 2)
            {
                lblPlayerChoice.Text = "You Chose Scissors";
                lblComputerChoice.Text = "Computer Chose Paper";
                lblWinRound.Text = "Scissors Wins";
                playerScoreCounter++;
                lblPlayerScore.Text = $"Player Score: {playerScoreCounter}";
                if (compScoreCounter == 2)
                {
                    lblWinner.Text = "Computer Wins!";
                }
                if (playerScoreCounter == 2)
                {
                    lblWinner.Text = "Player Wins!";
                }
            }

            else if (num3 == 3)
            {
                lblPlayerChoice.Text = "You Chose Scissors";
                lblComputerChoice.Text = "Computer Chose Scissors";
                lblWinRound.Text = "DRAW";
                if (compScoreCounter == 2)
                {
                    lblWinner.Text = "Computer Wins!";
                }
                if (playerScoreCounter == 2)
                {
                    lblWinner.Text = "Player Wins!";
                }
            }
        }
    }
}
