namespace Lab7
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
            txtAccountNum = new TextBox();
            txtPinNum = new TextBox();
            btnLogin = new Button();
            lblWelcome = new Label();
            lblBalance = new Label();
            lblDeposit = new Label();
            txtDeposit = new TextBox();
            lblWithdrawl = new Label();
            txtWithdrawl = new TextBox();
            btnDeposit = new Button();
            btnWithdrawl = new Button();
            btnLogout = new Button();
            lblError = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(79, 39);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 0;
            label1.Text = "Account #";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(79, 95);
            label2.Name = "label2";
            label2.Size = new Size(42, 20);
            label2.TabIndex = 1;
            label2.Text = "Pin #";
            // 
            // txtAccountNum
            // 
            txtAccountNum.Location = new Point(185, 36);
            txtAccountNum.Name = "txtAccountNum";
            txtAccountNum.Size = new Size(125, 27);
            txtAccountNum.TabIndex = 2;
            // 
            // txtPinNum
            // 
            txtPinNum.Location = new Point(185, 92);
            txtPinNum.Name = "txtPinNum";
            txtPinNum.Size = new Size(125, 27);
            txtPinNum.TabIndex = 3;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(417, 68);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(94, 29);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Location = new Point(185, 162);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(0, 20);
            lblWelcome.TabIndex = 5;
            // 
            // lblBalance
            // 
            lblBalance.AutoSize = true;
            lblBalance.Location = new Point(185, 206);
            lblBalance.Name = "lblBalance";
            lblBalance.Size = new Size(0, 20);
            lblBalance.TabIndex = 6;
            // 
            // lblDeposit
            // 
            lblDeposit.AutoSize = true;
            lblDeposit.Location = new Point(79, 254);
            lblDeposit.Name = "lblDeposit";
            lblDeposit.Size = new Size(238, 20);
            lblDeposit.TabIndex = 7;
            lblDeposit.Text = "Would you like to make a deposit?";
            lblDeposit.Visible = false;
            // 
            // txtDeposit
            // 
            txtDeposit.Location = new Point(79, 287);
            txtDeposit.Name = "txtDeposit";
            txtDeposit.Size = new Size(231, 27);
            txtDeposit.TabIndex = 8;
            txtDeposit.Visible = false;
            // 
            // lblWithdrawl
            // 
            lblWithdrawl.AutoSize = true;
            lblWithdrawl.Location = new Point(79, 329);
            lblWithdrawl.Name = "lblWithdrawl";
            lblWithdrawl.Size = new Size(253, 20);
            lblWithdrawl.TabIndex = 9;
            lblWithdrawl.Text = "Would you like to make a withdrawl?";
            lblWithdrawl.Visible = false;
            // 
            // txtWithdrawl
            // 
            txtWithdrawl.Location = new Point(79, 352);
            txtWithdrawl.Name = "txtWithdrawl";
            txtWithdrawl.Size = new Size(231, 27);
            txtWithdrawl.TabIndex = 10;
            txtWithdrawl.Visible = false;
            // 
            // btnDeposit
            // 
            btnDeposit.Location = new Point(373, 285);
            btnDeposit.Name = "btnDeposit";
            btnDeposit.Size = new Size(94, 29);
            btnDeposit.TabIndex = 11;
            btnDeposit.Text = "Deposit";
            btnDeposit.UseVisualStyleBackColor = true;
            btnDeposit.Visible = false;
            btnDeposit.Click += btnDeposit_Click;
            // 
            // btnWithdrawl
            // 
            btnWithdrawl.Location = new Point(373, 350);
            btnWithdrawl.Name = "btnWithdrawl";
            btnWithdrawl.Size = new Size(94, 29);
            btnWithdrawl.TabIndex = 12;
            btnWithdrawl.Text = "Withdraw";
            btnWithdrawl.UseVisualStyleBackColor = true;
            btnWithdrawl.Visible = false;
            btnWithdrawl.Click += btnWithdrawl_Click;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(566, 320);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(94, 29);
            btnLogout.TabIndex = 13;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Visible = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.Location = new Point(501, 162);
            lblError.Name = "lblError";
            lblError.Size = new Size(0, 20);
            lblError.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblError);
            Controls.Add(btnLogout);
            Controls.Add(btnWithdrawl);
            Controls.Add(btnDeposit);
            Controls.Add(txtWithdrawl);
            Controls.Add(lblWithdrawl);
            Controls.Add(txtDeposit);
            Controls.Add(lblDeposit);
            Controls.Add(lblBalance);
            Controls.Add(lblWelcome);
            Controls.Add(btnLogin);
            Controls.Add(txtPinNum);
            Controls.Add(txtAccountNum);
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
        private TextBox txtAccountNum;
        private TextBox txtPinNum;
        private Button btnLogin;
        private Label lblWelcome;
        private Label lblBalance;
        private Label lblDeposit;
        private TextBox txtDeposit;
        private Label lblWithdrawl;
        private TextBox txtWithdrawl;
        private Button btnDeposit;
        private Button btnWithdrawl;
        private Button btnLogout;
        private Label lblError;
    }
}
