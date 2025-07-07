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
            lblError = new Label();
            btnLogout = new Button();
            btnWithdrawl = new Button();
            btnDeposit = new Button();
            txtWithdrawl = new TextBox();
            lblWithdrawl = new Label();
            txtDeposit = new TextBox();
            lblDeposit = new Label();
            lblBalance = new Label();
            lblWelcome = new Label();
            btnLogin = new Button();
            txtPinNum = new TextBox();
            txtAccountNum = new TextBox();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.Location = new Point(532, 180);
            lblError.Name = "lblError";
            lblError.Size = new Size(0, 20);
            lblError.TabIndex = 29;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(597, 338);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(94, 29);
            btnLogout.TabIndex = 28;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Visible = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnWithdrawl
            // 
            btnWithdrawl.Location = new Point(404, 368);
            btnWithdrawl.Name = "btnWithdrawl";
            btnWithdrawl.Size = new Size(94, 29);
            btnWithdrawl.TabIndex = 27;
            btnWithdrawl.Text = "Withdraw";
            btnWithdrawl.UseVisualStyleBackColor = true;
            btnWithdrawl.Visible = false;
            btnWithdrawl.Click += btnWithdrawl_Click;
            // 
            // btnDeposit
            // 
            btnDeposit.Location = new Point(404, 303);
            btnDeposit.Name = "btnDeposit";
            btnDeposit.Size = new Size(94, 29);
            btnDeposit.TabIndex = 26;
            btnDeposit.Text = "Deposit";
            btnDeposit.UseVisualStyleBackColor = true;
            btnDeposit.Visible = false;
            btnDeposit.Click += btnDeposit_Click;
            // 
            // txtWithdrawl
            // 
            txtWithdrawl.Location = new Point(110, 370);
            txtWithdrawl.Name = "txtWithdrawl";
            txtWithdrawl.Size = new Size(231, 27);
            txtWithdrawl.TabIndex = 25;
            txtWithdrawl.Visible = false;
            // 
            // lblWithdrawl
            // 
            lblWithdrawl.AutoSize = true;
            lblWithdrawl.Location = new Point(110, 347);
            lblWithdrawl.Name = "lblWithdrawl";
            lblWithdrawl.Size = new Size(253, 20);
            lblWithdrawl.TabIndex = 24;
            lblWithdrawl.Text = "Would you like to make a withdrawl?";
            lblWithdrawl.Visible = false;
            // 
            // txtDeposit
            // 
            txtDeposit.Location = new Point(110, 305);
            txtDeposit.Name = "txtDeposit";
            txtDeposit.Size = new Size(231, 27);
            txtDeposit.TabIndex = 23;
            txtDeposit.Visible = false;
            // 
            // lblDeposit
            // 
            lblDeposit.AutoSize = true;
            lblDeposit.Location = new Point(110, 272);
            lblDeposit.Name = "lblDeposit";
            lblDeposit.Size = new Size(238, 20);
            lblDeposit.TabIndex = 22;
            lblDeposit.Text = "Would you like to make a deposit?";
            lblDeposit.Visible = false;
            // 
            // lblBalance
            // 
            lblBalance.AutoSize = true;
            lblBalance.Location = new Point(216, 224);
            lblBalance.Name = "lblBalance";
            lblBalance.Size = new Size(0, 20);
            lblBalance.TabIndex = 21;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Location = new Point(216, 180);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(0, 20);
            lblWelcome.TabIndex = 20;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(448, 86);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(94, 29);
            btnLogin.TabIndex = 19;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtPinNum
            // 
            txtPinNum.Location = new Point(216, 110);
            txtPinNum.Name = "txtPinNum";
            txtPinNum.Size = new Size(125, 27);
            txtPinNum.TabIndex = 18;
            // 
            // txtAccountNum
            // 
            txtAccountNum.Location = new Point(216, 54);
            txtAccountNum.Name = "txtAccountNum";
            txtAccountNum.Size = new Size(125, 27);
            txtAccountNum.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(110, 113);
            label2.Name = "label2";
            label2.Size = new Size(42, 20);
            label2.TabIndex = 16;
            label2.Text = "Pin #";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(110, 57);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 15;
            label1.Text = "Account #";
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

        private Label lblError;
        private Button btnLogout;
        private Button btnWithdrawl;
        private Button btnDeposit;
        private TextBox txtWithdrawl;
        private Label lblWithdrawl;
        private TextBox txtDeposit;
        private Label lblDeposit;
        private Label lblBalance;
        private Label lblWelcome;
        private Button btnLogin;
        private TextBox txtPinNum;
        private TextBox txtAccountNum;
        private Label label2;
        private Label label1;
    }
}
