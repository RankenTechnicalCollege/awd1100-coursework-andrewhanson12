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
            txtSearch = new TextBox();
            btnSearch = new Button();
            lblGame = new Label();
            lblPublisher = new Label();
            lblPrice = new Label();
            SuspendLayout();
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(142, 64);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(205, 27);
            txtSearch.TabIndex = 0;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(486, 62);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // lblGame
            // 
            lblGame.AutoSize = true;
            lblGame.Location = new Point(142, 215);
            lblGame.Name = "lblGame";
            lblGame.Size = new Size(0, 20);
            lblGame.TabIndex = 2;
            // 
            // lblPublisher
            // 
            lblPublisher.AutoSize = true;
            lblPublisher.Location = new Point(142, 294);
            lblPublisher.Name = "lblPublisher";
            lblPublisher.Size = new Size(0, 20);
            lblPublisher.TabIndex = 3;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(142, 371);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(0, 20);
            lblPrice.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblPrice);
            Controls.Add(lblPublisher);
            Controls.Add(lblGame);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Name = "Form1";
            Text = "Gamebreak";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSearch;
        private Button btnSearch;
        private Label lblGame;
        private Label lblPublisher;
        private Label lblPrice;
    }
}
