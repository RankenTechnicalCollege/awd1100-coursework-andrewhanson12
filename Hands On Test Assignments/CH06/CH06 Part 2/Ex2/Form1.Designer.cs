namespace Ex2
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
            txtQuantity = new TextBox();
            txtDiscount = new TextBox();
            btnOrder = new Button();
            lblDiscount = new Label();
            lblQuantity = new Label();
            lblSubtotal = new Label();
            lblTax = new Label();
            lblTotal = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(83, 76);
            label1.Name = "label1";
            label1.Size = new Size(65, 20);
            label1.TabIndex = 0;
            label1.Text = "Quantity";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(83, 140);
            label2.Name = "label2";
            label2.Size = new Size(106, 20);
            label2.TabIndex = 1;
            label2.Text = "Discount Code";
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(244, 69);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(125, 27);
            txtQuantity.TabIndex = 2;
            // 
            // txtDiscount
            // 
            txtDiscount.Location = new Point(244, 133);
            txtDiscount.Name = "txtDiscount";
            txtDiscount.Size = new Size(125, 27);
            txtDiscount.TabIndex = 3;
            // 
            // btnOrder
            // 
            btnOrder.Location = new Point(501, 101);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(94, 29);
            btnOrder.TabIndex = 4;
            btnOrder.Text = "Order";
            btnOrder.UseVisualStyleBackColor = true;
            btnOrder.Click += btnOrder_Click;
            // 
            // lblDiscount
            // 
            lblDiscount.AutoSize = true;
            lblDiscount.Location = new Point(244, 187);
            lblDiscount.Name = "lblDiscount";
            lblDiscount.Size = new Size(0, 20);
            lblDiscount.TabIndex = 5;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(98, 247);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(0, 20);
            lblQuantity.TabIndex = 6;
            // 
            // lblSubtotal
            // 
            lblSubtotal.AutoSize = true;
            lblSubtotal.Location = new Point(98, 301);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(0, 20);
            lblSubtotal.TabIndex = 7;
            // 
            // lblTax
            // 
            lblTax.AutoSize = true;
            lblTax.Location = new Point(98, 355);
            lblTax.Name = "lblTax";
            lblTax.Size = new Size(0, 20);
            lblTax.TabIndex = 8;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(98, 405);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(0, 20);
            lblTotal.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblTotal);
            Controls.Add(lblTax);
            Controls.Add(lblSubtotal);
            Controls.Add(lblQuantity);
            Controls.Add(lblDiscount);
            Controls.Add(btnOrder);
            Controls.Add(txtDiscount);
            Controls.Add(txtQuantity);
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
        private TextBox txtQuantity;
        private TextBox txtDiscount;
        private Button btnOrder;
        private Label lblDiscount;
        private Label lblQuantity;
        private Label lblSubtotal;
        private Label lblTax;
        private Label lblTotal;
    }
}
