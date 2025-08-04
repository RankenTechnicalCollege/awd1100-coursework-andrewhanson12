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
            lstIndustries = new ListBox();
            label1 = new Label();
            btnSearch = new Button();
            SuspendLayout();
            // 
            // lstIndustries
            // 
            lstIndustries.FormattingEnabled = true;
            lstIndustries.Location = new Point(47, 84);
            lstIndustries.Name = "lstIndustries";
            lstIndustries.SelectionMode = SelectionMode.MultiSimple;
            lstIndustries.Size = new Size(218, 204);
            lstIndustries.TabIndex = 0;
            lstIndustries.SelectedIndexChanged += lstIndustries_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 32);
            label1.Name = "label1";
            label1.Size = new Size(275, 20);
            label1.TabIndex = 1;
            label1.Text = "Select all industries you are interested in";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(47, 318);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSearch);
            Controls.Add(label1);
            Controls.Add(lstIndustries);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstIndustries;
        private Label label1;
        private Button btnSearch;
    }
}
