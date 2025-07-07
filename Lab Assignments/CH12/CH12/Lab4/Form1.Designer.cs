namespace Lab4
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
            lblPublisher = new Label();
            lblGame = new Label();
            btnSearch = new Button();
            txtSearch = new TextBox();
            lblPrice = new Label();
            SuspendLayout();
            // 
            // lblPublisher
            // 
            lblPublisher.AutoSize = true;
            lblPublisher.Location = new Point(181, 317);
            lblPublisher.Name = "lblPublisher";
            lblPublisher.Size = new Size(0, 20);
            lblPublisher.TabIndex = 7;
            // 
            // lblGame
            // 
            lblGame.AutoSize = true;
            lblGame.Location = new Point(181, 238);
            lblGame.Name = "lblGame";
            lblGame.Size = new Size(0, 20);
            lblGame.TabIndex = 6;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(525, 99);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 5;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(181, 101);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(205, 27);
            txtSearch.TabIndex = 4;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(181, 389);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(0, 20);
            lblPrice.TabIndex = 8;
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
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPublisher;
        private Label lblGame;
        private Button btnSearch;
        private TextBox txtSearch;
        private Label lblPrice;
    }
}
