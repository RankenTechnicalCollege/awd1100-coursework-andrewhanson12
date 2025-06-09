namespace Lab2
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
            label1 = new Label();
            txtTestScore = new TextBox();
            btnEnter = new Button();
            lblNumScores = new Label();
            lblSumScores = new Label();
            lblAverageScore = new Label();
            lblLowScore = new Label();
            lblHighScore = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(142, 47);
            label1.Name = "label1";
            label1.Size = new Size(146, 20);
            label1.TabIndex = 0;
            label1.Text = "Enter your test score:";
            // 
            // txtTestScore
            // 
            txtTestScore.Location = new Point(142, 88);
            txtTestScore.Name = "txtTestScore";
            txtTestScore.Size = new Size(125, 27);
            txtTestScore.TabIndex = 1;
            // 
            // btnEnter
            // 
            btnEnter.Location = new Point(142, 141);
            btnEnter.Name = "btnEnter";
            btnEnter.Size = new Size(94, 29);
            btnEnter.TabIndex = 2;
            btnEnter.Text = "Enter";
            btnEnter.UseVisualStyleBackColor = true;
            btnEnter.Click += btnEnter_Click;
            // 
            // lblNumScores
            // 
            lblNumScores.AutoSize = true;
            lblNumScores.Location = new Point(142, 211);
            lblNumScores.Name = "lblNumScores";
            lblNumScores.Size = new Size(0, 20);
            lblNumScores.TabIndex = 3;
            // 
            // lblSumScores
            // 
            lblSumScores.AutoSize = true;
            lblSumScores.Location = new Point(142, 252);
            lblSumScores.Name = "lblSumScores";
            lblSumScores.Size = new Size(0, 20);
            lblSumScores.TabIndex = 4;
            // 
            // lblAverageScore
            // 
            lblAverageScore.AutoSize = true;
            lblAverageScore.Location = new Point(142, 290);
            lblAverageScore.Name = "lblAverageScore";
            lblAverageScore.Size = new Size(0, 20);
            lblAverageScore.TabIndex = 5;
            // 
            // lblLowScore
            // 
            lblLowScore.AutoSize = true;
            lblLowScore.Location = new Point(142, 331);
            lblLowScore.Name = "lblLowScore";
            lblLowScore.Size = new Size(0, 20);
            lblLowScore.TabIndex = 6;
            // 
            // lblHighScore
            // 
            lblHighScore.AutoSize = true;
            lblHighScore.Location = new Point(142, 374);
            lblHighScore.Name = "lblHighScore";
            lblHighScore.Size = new Size(0, 20);
            lblHighScore.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblHighScore);
            Controls.Add(lblLowScore);
            Controls.Add(lblAverageScore);
            Controls.Add(lblSumScores);
            Controls.Add(lblNumScores);
            Controls.Add(btnEnter);
            Controls.Add(txtTestScore);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtTestScore;
        private Button btnEnter;
        private Label lblNumScores;
        private Label lblSumScores;
        private Label lblAverageScore;
        private Label lblLowScore;
        private Label lblHighScore;
    }
}
