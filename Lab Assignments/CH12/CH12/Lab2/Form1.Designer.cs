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
            label1 = new Label();
            label2 = new Label();
            txtSearchName = new TextBox();
            txtSearchUPC = new TextBox();
            btnSearchName = new Button();
            btnSearchUPC = new Button();
            lblName = new Label();
            lblUPC = new Label();
            lblStorePrice = new Label();
            lblCostCase = new Label();
            lblUnitsCase = new Label();
            grpChange = new GroupBox();
            btnUpdate = new Button();
            txtChangeAccess = new TextBox();
            txtNewPrice = new TextBox();
            lblChangeError = new Label();
            label4 = new Label();
            label3 = new Label();
            grpDelete = new GroupBox();
            lblErrorDelete = new Label();
            btnDelete = new Button();
            txtDeleteAccess = new TextBox();
            txtVerifyUPC = new TextBox();
            label5 = new Label();
            label6 = new Label();
            grpAdd = new GroupBox();
            lblResult = new Label();
            btnAdd = new Button();
            txtAddAccess = new TextBox();
            txtUnitsCase = new TextBox();
            txtCostCase = new TextBox();
            txtStorePrice = new TextBox();
            txtUPC = new TextBox();
            txtName = new TextBox();
            label11 = new Label();
            label12 = new Label();
            label9 = new Label();
            label10 = new Label();
            label8 = new Label();
            label7 = new Label();
            grpChange.SuspendLayout();
            grpDelete.SuspendLayout();
            grpAdd.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(83, 34);
            label1.Name = "label1";
            label1.Size = new Size(114, 20);
            label1.TabIndex = 0;
            label1.Text = "Search by name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(446, 34);
            label2.Name = "label2";
            label2.Size = new Size(104, 20);
            label2.TabIndex = 1;
            label2.Text = "Search by UPC";
            // 
            // txtSearchName
            // 
            txtSearchName.Location = new Point(83, 77);
            txtSearchName.Name = "txtSearchName";
            txtSearchName.Size = new Size(173, 27);
            txtSearchName.TabIndex = 2;
            // 
            // txtSearchUPC
            // 
            txtSearchUPC.Location = new Point(446, 77);
            txtSearchUPC.Name = "txtSearchUPC";
            txtSearchUPC.Size = new Size(173, 27);
            txtSearchUPC.TabIndex = 3;
            // 
            // btnSearchName
            // 
            btnSearchName.Location = new Point(278, 34);
            btnSearchName.Name = "btnSearchName";
            btnSearchName.Size = new Size(94, 70);
            btnSearchName.TabIndex = 4;
            btnSearchName.Text = "Search";
            btnSearchName.UseVisualStyleBackColor = true;
            btnSearchName.Click += btnSearchName_Click;
            // 
            // btnSearchUPC
            // 
            btnSearchUPC.Location = new Point(650, 34);
            btnSearchUPC.Name = "btnSearchUPC";
            btnSearchUPC.Size = new Size(94, 70);
            btnSearchUPC.TabIndex = 5;
            btnSearchUPC.Text = "Search";
            btnSearchUPC.UseVisualStyleBackColor = true;
            btnSearchUPC.Click += btnSearchUPC_Click;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(83, 132);
            lblName.Name = "lblName";
            lblName.Size = new Size(0, 20);
            lblName.TabIndex = 6;
            // 
            // lblUPC
            // 
            lblUPC.AutoSize = true;
            lblUPC.Location = new Point(83, 162);
            lblUPC.Name = "lblUPC";
            lblUPC.Size = new Size(0, 20);
            lblUPC.TabIndex = 7;
            // 
            // lblStorePrice
            // 
            lblStorePrice.AutoSize = true;
            lblStorePrice.Location = new Point(83, 191);
            lblStorePrice.Name = "lblStorePrice";
            lblStorePrice.Size = new Size(0, 20);
            lblStorePrice.TabIndex = 8;
            // 
            // lblCostCase
            // 
            lblCostCase.AutoSize = true;
            lblCostCase.Location = new Point(446, 132);
            lblCostCase.Name = "lblCostCase";
            lblCostCase.Size = new Size(0, 20);
            lblCostCase.TabIndex = 9;
            // 
            // lblUnitsCase
            // 
            lblUnitsCase.AutoSize = true;
            lblUnitsCase.Location = new Point(446, 162);
            lblUnitsCase.Name = "lblUnitsCase";
            lblUnitsCase.Size = new Size(0, 20);
            lblUnitsCase.TabIndex = 10;
            // 
            // grpChange
            // 
            grpChange.Controls.Add(btnUpdate);
            grpChange.Controls.Add(txtChangeAccess);
            grpChange.Controls.Add(txtNewPrice);
            grpChange.Controls.Add(lblChangeError);
            grpChange.Controls.Add(label4);
            grpChange.Controls.Add(label3);
            grpChange.Location = new Point(83, 227);
            grpChange.Name = "grpChange";
            grpChange.Size = new Size(321, 125);
            grpChange.TabIndex = 11;
            grpChange.TabStop = false;
            grpChange.Text = "Change Item";
            grpChange.Visible = false;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(238, 33);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(77, 57);
            btnUpdate.TabIndex = 5;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtChangeAccess
            // 
            txtChangeAccess.Location = new Point(107, 67);
            txtChangeAccess.Name = "txtChangeAccess";
            txtChangeAccess.Size = new Size(125, 27);
            txtChangeAccess.TabIndex = 4;
            // 
            // txtNewPrice
            // 
            txtNewPrice.Location = new Point(107, 33);
            txtNewPrice.Name = "txtNewPrice";
            txtNewPrice.Size = new Size(125, 27);
            txtNewPrice.TabIndex = 3;
            // 
            // lblChangeError
            // 
            lblChangeError.AutoSize = true;
            lblChangeError.Location = new Point(6, 102);
            lblChangeError.Name = "lblChangeError";
            lblChangeError.Size = new Size(0, 20);
            lblChangeError.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 70);
            label4.Name = "label4";
            label4.Size = new Size(81, 20);
            label4.TabIndex = 1;
            label4.Text = "Access Key";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 36);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 0;
            label3.Text = "New Price";
            // 
            // grpDelete
            // 
            grpDelete.Controls.Add(lblErrorDelete);
            grpDelete.Controls.Add(btnDelete);
            grpDelete.Controls.Add(txtDeleteAccess);
            grpDelete.Controls.Add(txtVerifyUPC);
            grpDelete.Controls.Add(label5);
            grpDelete.Controls.Add(label6);
            grpDelete.Location = new Point(446, 227);
            grpDelete.Name = "grpDelete";
            grpDelete.Size = new Size(321, 125);
            grpDelete.TabIndex = 12;
            grpDelete.TabStop = false;
            grpDelete.Text = "Delete Item";
            grpDelete.Visible = false;
            // 
            // lblErrorDelete
            // 
            lblErrorDelete.AutoSize = true;
            lblErrorDelete.Location = new Point(6, 102);
            lblErrorDelete.Name = "lblErrorDelete";
            lblErrorDelete.Size = new Size(0, 20);
            lblErrorDelete.TabIndex = 11;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(238, 32);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(77, 57);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtDeleteAccess
            // 
            txtDeleteAccess.Location = new Point(107, 66);
            txtDeleteAccess.Name = "txtDeleteAccess";
            txtDeleteAccess.Size = new Size(125, 27);
            txtDeleteAccess.TabIndex = 9;
            // 
            // txtVerifyUPC
            // 
            txtVerifyUPC.Location = new Point(107, 32);
            txtVerifyUPC.Name = "txtVerifyUPC";
            txtVerifyUPC.Size = new Size(125, 27);
            txtVerifyUPC.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 69);
            label5.Name = "label5";
            label5.Size = new Size(81, 20);
            label5.TabIndex = 7;
            label5.Text = "Access Key";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 35);
            label6.Name = "label6";
            label6.Size = new Size(77, 20);
            label6.TabIndex = 6;
            label6.Text = "Verify UPC";
            // 
            // grpAdd
            // 
            grpAdd.Controls.Add(lblResult);
            grpAdd.Controls.Add(btnAdd);
            grpAdd.Controls.Add(txtAddAccess);
            grpAdd.Controls.Add(txtUnitsCase);
            grpAdd.Controls.Add(txtCostCase);
            grpAdd.Controls.Add(txtStorePrice);
            grpAdd.Controls.Add(txtUPC);
            grpAdd.Controls.Add(txtName);
            grpAdd.Controls.Add(label11);
            grpAdd.Controls.Add(label12);
            grpAdd.Controls.Add(label9);
            grpAdd.Controls.Add(label10);
            grpAdd.Controls.Add(label8);
            grpAdd.Controls.Add(label7);
            grpAdd.Location = new Point(83, 361);
            grpAdd.Name = "grpAdd";
            grpAdd.Size = new Size(684, 125);
            grpAdd.TabIndex = 13;
            grpAdd.TabStop = false;
            grpAdd.Text = "Add Item";
            grpAdd.Visible = false;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(409, 100);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 20);
            lblResult.TabIndex = 13;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(623, 29);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(55, 71);
            btnAdd.TabIndex = 12;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtAddAccess
            // 
            txtAddAccess.Location = new Point(492, 73);
            txtAddAccess.Name = "txtAddAccess";
            txtAddAccess.Size = new Size(125, 27);
            txtAddAccess.TabIndex = 11;
            // 
            // txtUnitsCase
            // 
            txtUnitsCase.Location = new Point(516, 25);
            txtUnitsCase.Name = "txtUnitsCase";
            txtUnitsCase.Size = new Size(101, 27);
            txtUnitsCase.TabIndex = 10;
            // 
            // txtCostCase
            // 
            txtCostCase.Location = new Point(288, 77);
            txtCostCase.Name = "txtCostCase";
            txtCostCase.Size = new Size(115, 27);
            txtCostCase.TabIndex = 9;
            // 
            // txtStorePrice
            // 
            txtStorePrice.Location = new Point(288, 29);
            txtStorePrice.Name = "txtStorePrice";
            txtStorePrice.Size = new Size(115, 27);
            txtStorePrice.TabIndex = 8;
            // 
            // txtUPC
            // 
            txtUPC.Location = new Point(62, 77);
            txtUPC.Name = "txtUPC";
            txtUPC.Size = new Size(125, 27);
            txtUPC.TabIndex = 7;
            // 
            // txtName
            // 
            txtName.Location = new Point(62, 32);
            txtName.Name = "txtName";
            txtName.Size = new Size(125, 27);
            txtName.TabIndex = 6;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(409, 80);
            label11.Name = "label11";
            label11.Size = new Size(81, 20);
            label11.TabIndex = 5;
            label11.Text = "Access Key";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(409, 32);
            label12.Name = "label12";
            label12.Size = new Size(101, 20);
            label12.TabIndex = 4;
            label12.Text = "Units per case";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(192, 84);
            label9.Name = "label9";
            label9.Size = new Size(97, 20);
            label9.TabIndex = 3;
            label9.Text = "Cost per case";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(193, 32);
            label10.Name = "label10";
            label10.Size = new Size(80, 20);
            label10.TabIndex = 2;
            label10.Text = "Store Price";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 84);
            label8.Name = "label8";
            label8.Size = new Size(36, 20);
            label8.TabIndex = 1;
            label8.Text = "UPC";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 32);
            label7.Name = "label7";
            label7.Size = new Size(49, 20);
            label7.TabIndex = 0;
            label7.Text = "Name";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 498);
            Controls.Add(grpAdd);
            Controls.Add(grpDelete);
            Controls.Add(grpChange);
            Controls.Add(lblUnitsCase);
            Controls.Add(lblCostCase);
            Controls.Add(lblStorePrice);
            Controls.Add(lblUPC);
            Controls.Add(lblName);
            Controls.Add(btnSearchUPC);
            Controls.Add(btnSearchName);
            Controls.Add(txtSearchUPC);
            Controls.Add(txtSearchName);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            grpChange.ResumeLayout(false);
            grpChange.PerformLayout();
            grpDelete.ResumeLayout(false);
            grpDelete.PerformLayout();
            grpAdd.ResumeLayout(false);
            grpAdd.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtSearchName;
        private TextBox txtSearchUPC;
        private Button btnSearchName;
        private Button btnSearchUPC;
        private Label lblName;
        private Label lblUPC;
        private Label lblStorePrice;
        private Label lblCostCase;
        private Label lblUnitsCase;
        private GroupBox grpChange;
        private Label lblChangeError;
        private Label label4;
        private Label label3;
        private GroupBox grpDelete;
        private GroupBox grpAdd;
        private Button btnUpdate;
        private TextBox txtChangeAccess;
        private TextBox txtNewPrice;
        private Label lblErrorDelete;
        private Button btnDelete;
        private TextBox txtDeleteAccess;
        private TextBox txtVerifyUPC;
        private Label label5;
        private Label label6;
        private TextBox txtName;
        private Label label11;
        private Label label12;
        private Label label9;
        private Label label10;
        private Label label8;
        private Label label7;
        private Button btnAdd;
        private TextBox txtAddAccess;
        private TextBox txtUnitsCase;
        private TextBox txtCostCase;
        private TextBox txtStorePrice;
        private TextBox txtUPC;
        private Label lblResult;
    }
}
