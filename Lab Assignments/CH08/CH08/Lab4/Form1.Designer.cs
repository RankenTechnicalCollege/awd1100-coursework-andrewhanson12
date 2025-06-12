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
            btnSearch = new Button();
            txtSearch = new TextBox();
            lblMovie = new Label();
            lblDirector = new Label();
            lblDescription = new Label();
            SuspendLayout();
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(499, 76);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 0;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(169, 78);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(265, 27);
            txtSearch.TabIndex = 1;
            // 
            // lblMovie
            // 
            lblMovie.AutoSize = true;
            lblMovie.Location = new Point(169, 170);
            lblMovie.Name = "lblMovie";
            lblMovie.Size = new Size(0, 20);
            lblMovie.TabIndex = 2;
            // 
            // lblDirector
            // 
            lblDirector.AutoSize = true;
            lblDirector.Location = new Point(169, 239);
            lblDirector.Name = "lblDirector";
            lblDirector.Size = new Size(0, 20);
            lblDirector.TabIndex = 3;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(169, 306);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(0, 20);
            lblDescription.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblDescription);
            Controls.Add(lblDirector);
            Controls.Add(lblMovie);
            Controls.Add(txtSearch);
            Controls.Add(btnSearch);
            Name = "Form1";
            Text = "Movie Database";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSearch;
        private TextBox txtSearch;
        private Label lblMovie;
        private Label lblDirector;
        private Label lblDescription;
    }
}
