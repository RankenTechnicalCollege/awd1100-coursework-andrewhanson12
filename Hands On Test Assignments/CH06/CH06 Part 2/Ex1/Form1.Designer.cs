namespace Ex1
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
            btnSmall = new Button();
            btnMed = new Button();
            btnLarge = new Button();
            lblSmCount = new Label();
            lblMCount = new Label();
            lblLgCount = new Label();
            lblSubtotal = new Label();
            lblTax = new Label();
            lblTotal = new Label();
            btnClear = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(277, 42);
            label1.Name = "label1";
            label1.Size = new Size(199, 20);
            label1.TabIndex = 0;
            label1.Text = "What size shirt do you need?";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(86, 110);
            label2.Name = "label2";
            label2.Size = new Size(44, 20);
            label2.TabIndex = 0;
            label2.Text = "$9.99";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(347, 110);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 0;
            label3.Text = "$10.99";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(612, 110);
            label4.Name = "label4";
            label4.Size = new Size(52, 20);
            label4.TabIndex = 0;
            label4.Text = "$11.99";
            // 
            // btnSmall
            // 
            btnSmall.Location = new Point(86, 150);
            btnSmall.Name = "btnSmall";
            btnSmall.Size = new Size(50, 37);
            btnSmall.TabIndex = 1;
            btnSmall.Text = "S";
            btnSmall.UseVisualStyleBackColor = true;
            btnSmall.Click += btnSmall_Click;
            // 
            // btnMed
            // 
            btnMed.Location = new Point(347, 150);
            btnMed.Name = "btnMed";
            btnMed.Size = new Size(52, 37);
            btnMed.TabIndex = 2;
            btnMed.Text = "M";
            btnMed.UseVisualStyleBackColor = true;
            btnMed.Click += btnMed_Click;
            // 
            // btnLarge
            // 
            btnLarge.Location = new Point(612, 150);
            btnLarge.Name = "btnLarge";
            btnLarge.Size = new Size(52, 37);
            btnLarge.TabIndex = 3;
            btnLarge.Text = "L";
            btnLarge.UseVisualStyleBackColor = true;
            btnLarge.Click += btnLarge_Click;
            // 
            // lblSmCount
            // 
            lblSmCount.AutoSize = true;
            lblSmCount.Location = new Point(86, 207);
            lblSmCount.Name = "lblSmCount";
            lblSmCount.Size = new Size(0, 20);
            lblSmCount.TabIndex = 0;
            // 
            // lblMCount
            // 
            lblMCount.AutoSize = true;
            lblMCount.Location = new Point(347, 207);
            lblMCount.Name = "lblMCount";
            lblMCount.Size = new Size(0, 20);
            lblMCount.TabIndex = 0;
            // 
            // lblLgCount
            // 
            lblLgCount.AutoSize = true;
            lblLgCount.Location = new Point(612, 207);
            lblLgCount.Name = "lblLgCount";
            lblLgCount.Size = new Size(0, 20);
            lblLgCount.TabIndex = 0;
            // 
            // lblSubtotal
            // 
            lblSubtotal.AutoSize = true;
            lblSubtotal.Location = new Point(86, 272);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(0, 20);
            lblSubtotal.TabIndex = 0;
            // 
            // lblTax
            // 
            lblTax.AutoSize = true;
            lblTax.Location = new Point(86, 327);
            lblTax.Name = "lblTax";
            lblTax.Size = new Size(0, 20);
            lblTax.TabIndex = 0;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(86, 384);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(0, 20);
            lblTotal.TabIndex = 0;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(445, 318);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 4;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnClear);
            Controls.Add(lblTotal);
            Controls.Add(lblTax);
            Controls.Add(lblSubtotal);
            Controls.Add(lblLgCount);
            Controls.Add(lblMCount);
            Controls.Add(lblSmCount);
            Controls.Add(btnLarge);
            Controls.Add(btnMed);
            Controls.Add(btnSmall);
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
        private Button btnSmall;
        private Button btnMed;
        private Button btnLarge;
        private Label lblSmCount;
        private Label lblMCount;
        private Label lblLgCount;
        private Label lblSubtotal;
        private Label lblTax;
        private Label lblTotal;
        private Button btnClear;
    }
}
