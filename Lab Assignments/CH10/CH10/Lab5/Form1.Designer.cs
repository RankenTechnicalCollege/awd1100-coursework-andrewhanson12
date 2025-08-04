namespace Lab5
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
            label4 = new Label();
            txtId = new TextBox();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtEmail = new TextBox();
            btnAdd = new Button();
            label5 = new Label();
            btnRemove = new Button();
            cboRemove = new ComboBox();
            rtbOutput = new RichTextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(92, 53);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 0;
            label1.Text = "Student ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(92, 108);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 1;
            label2.Text = "First Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(92, 166);
            label3.Name = "label3";
            label3.Size = new Size(82, 20);
            label3.TabIndex = 2;
            label3.Text = "Last Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(92, 223);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 3;
            label4.Text = "Email:";
            // 
            // txtId
            // 
            txtId.Location = new Point(182, 46);
            txtId.Name = "txtId";
            txtId.Size = new Size(125, 27);
            txtId.TabIndex = 4;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(182, 101);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(125, 27);
            txtFirstName.TabIndex = 5;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(182, 159);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(125, 27);
            txtLastName.TabIndex = 6;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(182, 216);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(125, 27);
            txtEmail.TabIndex = 7;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(92, 265);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(92, 311);
            label5.Name = "label5";
            label5.Size = new Size(157, 20);
            label5.TabIndex = 9;
            label5.Text = "Remove Student by ID";
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(92, 371);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(94, 29);
            btnRemove.TabIndex = 10;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // cboRemove
            // 
            cboRemove.FormattingEnabled = true;
            cboRemove.Location = new Point(92, 337);
            cboRemove.Name = "cboRemove";
            cboRemove.Size = new Size(151, 28);
            cboRemove.TabIndex = 11;
            // 
            // rtbOutput
            // 
            rtbOutput.Location = new Point(382, 46);
            rtbOutput.Name = "rtbOutput";
            rtbOutput.Size = new Size(490, 248);
            rtbOutput.TabIndex = 12;
            rtbOutput.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 450);
            Controls.Add(rtbOutput);
            Controls.Add(cboRemove);
            Controls.Add(btnRemove);
            Controls.Add(label5);
            Controls.Add(btnAdd);
            Controls.Add(txtEmail);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(txtId);
            Controls.Add(label4);
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
        private Label label4;
        private TextBox txtId;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtEmail;
        private Button btnAdd;
        private Label label5;
        private Button btnRemove;
        private ComboBox cboRemove;
        private RichTextBox rtbOutput;
    }
}
