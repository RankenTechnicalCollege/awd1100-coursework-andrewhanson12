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
            txtName = new TextBox();
            btnSearch = new Button();
            lblFirstName = new Label();
            lblLastName = new Label();
            lblPhone = new Label();
            lblError = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(123, 45);
            label1.Name = "label1";
            label1.Size = new Size(172, 20);
            label1.TabIndex = 0;
            label1.Text = "First Name or Last Name";
            // 
            // txtName
            // 
            txtName.Location = new Point(123, 92);
            txtName.Name = "txtName";
            txtName.Size = new Size(172, 27);
            txtName.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(359, 90);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(123, 186);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(0, 20);
            lblFirstName.TabIndex = 3;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(123, 237);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(0, 20);
            lblLastName.TabIndex = 4;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(123, 291);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(0, 20);
            lblPhone.TabIndex = 5;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.Location = new Point(123, 347);
            lblError.Name = "lblError";
            lblError.Size = new Size(0, 20);
            lblError.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblError);
            Controls.Add(lblPhone);
            Controls.Add(lblLastName);
            Controls.Add(lblFirstName);
            Controls.Add(btnSearch);
            Controls.Add(txtName);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Address Book";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtName;
        private Button btnSearch;
        private Label lblFirstName;
        private Label lblLastName;
        private Label lblPhone;
        private Label lblError;
    }
}
