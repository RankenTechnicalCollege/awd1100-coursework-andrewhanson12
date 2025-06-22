namespace EX1
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
            label2 = new Label();
            label3 = new Label();
            txtAuthor = new TextBox();
            txtISBN = new TextBox();
            txtKeyword = new TextBox();
            btnAuthor = new Button();
            btnISBN = new Button();
            btnKeyword = new Button();
            lblName = new Label();
            lblDescription = new Label();
            lblAuthor = new Label();
            lblISBN = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(83, 48);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 0;
            label1.Text = "Author";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(83, 108);
            label2.Name = "label2";
            label2.Size = new Size(41, 20);
            label2.TabIndex = 1;
            label2.Text = "ISBN";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(83, 167);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 2;
            label3.Text = "Keyword";
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(196, 45);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(125, 27);
            txtAuthor.TabIndex = 3;
            // 
            // txtISBN
            // 
            txtISBN.Location = new Point(196, 105);
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(125, 27);
            txtISBN.TabIndex = 4;
            // 
            // txtKeyword
            // 
            txtKeyword.Location = new Point(196, 164);
            txtKeyword.Name = "txtKeyword";
            txtKeyword.Size = new Size(125, 27);
            txtKeyword.TabIndex = 5;
            // 
            // btnAuthor
            // 
            btnAuthor.Location = new Point(438, 43);
            btnAuthor.Name = "btnAuthor";
            btnAuthor.Size = new Size(94, 29);
            btnAuthor.TabIndex = 6;
            btnAuthor.Text = "Search";
            btnAuthor.UseVisualStyleBackColor = true;
            btnAuthor.Click += btnAuthor_Click;
            // 
            // btnISBN
            // 
            btnISBN.Location = new Point(438, 104);
            btnISBN.Name = "btnISBN";
            btnISBN.Size = new Size(94, 29);
            btnISBN.TabIndex = 7;
            btnISBN.Text = "Search";
            btnISBN.UseVisualStyleBackColor = true;
            btnISBN.Click += btnISBN_Click;
            // 
            // btnKeyword
            // 
            btnKeyword.Location = new Point(438, 163);
            btnKeyword.Name = "btnKeyword";
            btnKeyword.Size = new Size(94, 29);
            btnKeyword.TabIndex = 8;
            btnKeyword.Text = "Search";
            btnKeyword.UseVisualStyleBackColor = true;
            btnKeyword.Click += btnKeyword_Click;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(83, 233);
            lblName.Name = "lblName";
            lblName.Size = new Size(0, 20);
            lblName.TabIndex = 9;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(83, 281);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(0, 20);
            lblDescription.TabIndex = 10;
            // 
            // lblAuthor
            // 
            lblAuthor.AutoSize = true;
            lblAuthor.Location = new Point(83, 331);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(0, 20);
            lblAuthor.TabIndex = 11;
            // 
            // lblISBN
            // 
            lblISBN.AutoSize = true;
            lblISBN.Location = new Point(83, 383);
            lblISBN.Name = "lblISBN";
            lblISBN.Size = new Size(0, 20);
            lblISBN.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblISBN);
            Controls.Add(lblAuthor);
            Controls.Add(lblDescription);
            Controls.Add(lblName);
            Controls.Add(btnKeyword);
            Controls.Add(btnISBN);
            Controls.Add(btnAuthor);
            Controls.Add(txtKeyword);
            Controls.Add(txtISBN);
            Controls.Add(txtAuthor);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtAuthor;
        private TextBox txtISBN;
        private TextBox txtKeyword;
        private Button btnAuthor;
        private Button btnISBN;
        private Button btnKeyword;
        private Label lblName;
        private Label lblDescription;
        private Label lblAuthor;
        private Label lblISBN;
    }
}
