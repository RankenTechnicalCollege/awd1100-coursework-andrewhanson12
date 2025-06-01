namespace Lab3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnRock = new Button();
            btnPaper = new Button();
            btnScissors = new Button();
            lblPlayerChoice = new Label();
            lblComputerChoice = new Label();
            lblPlayerScore = new Label();
            lblCompScore = new Label();
            lblWinner = new Label();
            lblWinRound = new Label();
            SuspendLayout();
            // 
            // btnRock
            // 
            btnRock.Location = new Point(112, 79);
            btnRock.Name = "btnRock";
            btnRock.Size = new Size(94, 29);
            btnRock.TabIndex = 0;
            btnRock.Text = "Rock";
            btnRock.UseVisualStyleBackColor = true;
            btnRock.Click += btnRock_Click;
            // 
            // btnPaper
            // 
            btnPaper.Location = new Point(306, 79);
            btnPaper.Name = "btnPaper";
            btnPaper.Size = new Size(94, 29);
            btnPaper.TabIndex = 1;
            btnPaper.Text = "Paper";
            btnPaper.UseVisualStyleBackColor = true;
            btnPaper.Click += btnPaper_Click;
            // 
            // btnScissors
            // 
            btnScissors.Location = new Point(496, 79);
            btnScissors.Name = "btnScissors";
            btnScissors.Size = new Size(94, 29);
            btnScissors.TabIndex = 2;
            btnScissors.Text = "Scissors";
            btnScissors.UseVisualStyleBackColor = true;
            btnScissors.Click += btnScissors_Click;
            // 
            // lblPlayerChoice
            // 
            lblPlayerChoice.AutoSize = true;
            lblPlayerChoice.Location = new Point(112, 164);
            lblPlayerChoice.Name = "lblPlayerChoice";
            lblPlayerChoice.Size = new Size(0, 20);
            lblPlayerChoice.TabIndex = 3;
            // 
            // lblComputerChoice
            // 
            lblComputerChoice.AutoSize = true;
            lblComputerChoice.Location = new Point(496, 164);
            lblComputerChoice.Name = "lblComputerChoice";
            lblComputerChoice.Size = new Size(0, 20);
            lblComputerChoice.TabIndex = 4;
            // 
            // lblPlayerScore
            // 
            lblPlayerScore.AutoSize = true;
            lblPlayerScore.Location = new Point(112, 272);
            lblPlayerScore.Name = "lblPlayerScore";
            lblPlayerScore.Size = new Size(0, 20);
            lblPlayerScore.TabIndex = 5;
            // 
            // lblCompScore
            // 
            lblCompScore.AutoSize = true;
            lblCompScore.Location = new Point(496, 272);
            lblCompScore.Name = "lblCompScore";
            lblCompScore.Size = new Size(0, 20);
            lblCompScore.TabIndex = 6;
            // 
            // lblWinner
            // 
            lblWinner.AutoSize = true;
            lblWinner.Location = new Point(112, 355);
            lblWinner.Name = "lblWinner";
            lblWinner.Size = new Size(0, 20);
            lblWinner.TabIndex = 7;
            // 
            // lblWinRound
            // 
            lblWinRound.AutoSize = true;
            lblWinRound.Location = new Point(112, 208);
            lblWinRound.Name = "lblWinRound";
            lblWinRound.Size = new Size(0, 20);
            lblWinRound.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblWinRound);
            Controls.Add(lblWinner);
            Controls.Add(lblCompScore);
            Controls.Add(lblPlayerScore);
            Controls.Add(lblComputerChoice);
            Controls.Add(lblPlayerChoice);
            Controls.Add(btnScissors);
            Controls.Add(btnPaper);
            Controls.Add(btnRock);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRock;
        private Button btnPaper;
        private Button btnScissors;
        private Label lblPlayerChoice;
        private Label lblComputerChoice;
        private Label lblPlayerScore;
        private Label lblCompScore;
        private Label lblWinner;
        private Label lblWinRound;
    }
}
