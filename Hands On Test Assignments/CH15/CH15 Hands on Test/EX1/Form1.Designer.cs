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
            grpCreate = new GroupBox();
            lblError = new Label();
            btnCreate = new Button();
            rbLongTerm = new RadioButton();
            rbShortTerm = new RadioButton();
            txtAmount = new TextBox();
            txtName = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            grpManage = new GroupBox();
            lblResult = new Label();
            btnMakePayment = new Button();
            lblLoan = new Label();
            lblName = new Label();
            grpCreate.SuspendLayout();
            grpManage.SuspendLayout();
            SuspendLayout();
            // 
            // grpCreate
            // 
            grpCreate.Controls.Add(lblError);
            grpCreate.Controls.Add(btnCreate);
            grpCreate.Controls.Add(rbLongTerm);
            grpCreate.Controls.Add(rbShortTerm);
            grpCreate.Controls.Add(txtAmount);
            grpCreate.Controls.Add(txtName);
            grpCreate.Controls.Add(label3);
            grpCreate.Controls.Add(label2);
            grpCreate.Controls.Add(label1);
            grpCreate.Location = new Point(25, 35);
            grpCreate.Name = "grpCreate";
            grpCreate.Size = new Size(730, 201);
            grpCreate.TabIndex = 0;
            grpCreate.TabStop = false;
            grpCreate.Text = "Create Loan";
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.Location = new Point(461, 97);
            lblError.Name = "lblError";
            lblError.Size = new Size(0, 20);
            lblError.TabIndex = 8;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(551, 134);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(94, 54);
            btnCreate.TabIndex = 7;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // rbLongTerm
            // 
            rbLongTerm.AutoSize = true;
            rbLongTerm.Location = new Point(187, 164);
            rbLongTerm.Name = "rbLongTerm";
            rbLongTerm.Size = new Size(136, 24);
            rbLongTerm.TabIndex = 6;
            rbLongTerm.TabStop = true;
            rbLongTerm.Text = "Long Term Loan";
            rbLongTerm.UseVisualStyleBackColor = true;
            // 
            // rbShortTerm
            // 
            rbShortTerm.AutoSize = true;
            rbShortTerm.Location = new Point(187, 134);
            rbShortTerm.Name = "rbShortTerm";
            rbShortTerm.Size = new Size(138, 24);
            rbShortTerm.TabIndex = 5;
            rbShortTerm.TabStop = true;
            rbShortTerm.Text = "Short Term Loan";
            rbShortTerm.UseVisualStyleBackColor = true;
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(187, 90);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(228, 27);
            txtAmount.TabIndex = 4;
            // 
            // txtName
            // 
            txtName.Location = new Point(187, 46);
            txtName.Name = "txtName";
            txtName.Size = new Size(228, 27);
            txtName.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(48, 148);
            label3.Name = "label3";
            label3.Size = new Size(40, 20);
            label3.TabIndex = 2;
            label3.Text = "Type";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 97);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 1;
            label2.Text = "Amount";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 49);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // grpManage
            // 
            grpManage.Controls.Add(lblResult);
            grpManage.Controls.Add(btnMakePayment);
            grpManage.Controls.Add(lblLoan);
            grpManage.Controls.Add(lblName);
            grpManage.Location = new Point(25, 242);
            grpManage.Name = "grpManage";
            grpManage.Size = new Size(730, 201);
            grpManage.TabIndex = 1;
            grpManage.TabStop = false;
            grpManage.Text = "Manage Loan";
            grpManage.Visible = false;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(48, 150);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 20);
            lblResult.TabIndex = 3;
            // 
            // btnMakePayment
            // 
            btnMakePayment.Location = new Point(48, 109);
            btnMakePayment.Name = "btnMakePayment";
            btnMakePayment.Size = new Size(115, 29);
            btnMakePayment.TabIndex = 2;
            btnMakePayment.Text = "Make Payment";
            btnMakePayment.UseVisualStyleBackColor = true;
            btnMakePayment.Click += btnMakePayment_Click;
            // 
            // lblLoan
            // 
            lblLoan.AutoSize = true;
            lblLoan.Location = new Point(47, 76);
            lblLoan.Name = "lblLoan";
            lblLoan.Size = new Size(0, 20);
            lblLoan.TabIndex = 1;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(47, 34);
            lblName.Name = "lblName";
            lblName.Size = new Size(0, 20);
            lblName.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(grpManage);
            Controls.Add(grpCreate);
            Name = "Form1";
            Text = "Form1";
            grpCreate.ResumeLayout(false);
            grpCreate.PerformLayout();
            grpManage.ResumeLayout(false);
            grpManage.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpCreate;
        private RadioButton rbLongTerm;
        private RadioButton rbShortTerm;
        private TextBox txtAmount;
        private TextBox txtName;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox grpManage;
        private Button btnCreate;
        private Label lblName;
        private Label lblResult;
        private Button btnMakePayment;
        private Label lblLoan;
        private Label lblError;
    }
}
