namespace Lab4
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
            txtSale = new TextBox();
            btnDanielle = new Button();
            btnEdward = new Button();
            btnFrancis = new Button();
            label2 = new Label();
            lblDanielleSales = new Label();
            lblEdwardSales = new Label();
            lblFrancisSales = new Label();
            lblTotal = new Label();
            lblWinner = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(151, 41);
            label1.Name = "label1";
            label1.Size = new Size(171, 20);
            label1.TabIndex = 0;
            label1.Text = "How much was the sale?";
            // 
            // txtSale
            // 
            txtSale.Location = new Point(151, 88);
            txtSale.Name = "txtSale";
            txtSale.Size = new Size(125, 27);
            txtSale.TabIndex = 1;
            // 
            // btnDanielle
            // 
            btnDanielle.Location = new Point(151, 163);
            btnDanielle.Name = "btnDanielle";
            btnDanielle.Size = new Size(94, 29);
            btnDanielle.TabIndex = 2;
            btnDanielle.Text = "Danielle";
            btnDanielle.UseVisualStyleBackColor = true;
            btnDanielle.Click += btnDanielle_Click;
            // 
            // btnEdward
            // 
            btnEdward.Location = new Point(305, 163);
            btnEdward.Name = "btnEdward";
            btnEdward.Size = new Size(94, 29);
            btnEdward.TabIndex = 3;
            btnEdward.Text = "Edward";
            btnEdward.UseVisualStyleBackColor = true;
            btnEdward.Click += btnEdward_Click;
            // 
            // btnFrancis
            // 
            btnFrancis.Location = new Point(457, 163);
            btnFrancis.Name = "btnFrancis";
            btnFrancis.Size = new Size(94, 29);
            btnFrancis.TabIndex = 4;
            btnFrancis.Text = "Francis";
            btnFrancis.UseVisualStyleBackColor = true;
            btnFrancis.Click += btnFrancis_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(151, 130);
            label2.Name = "label2";
            label2.Size = new Size(144, 20);
            label2.TabIndex = 5;
            label2.Text = "Who made the sale?";
            // 
            // lblDanielleSales
            // 
            lblDanielleSales.AutoSize = true;
            lblDanielleSales.Location = new Point(151, 225);
            lblDanielleSales.Name = "lblDanielleSales";
            lblDanielleSales.Size = new Size(0, 20);
            lblDanielleSales.TabIndex = 6;
            // 
            // lblEdwardSales
            // 
            lblEdwardSales.AutoSize = true;
            lblEdwardSales.Location = new Point(151, 258);
            lblEdwardSales.Name = "lblEdwardSales";
            lblEdwardSales.Size = new Size(0, 20);
            lblEdwardSales.TabIndex = 7;
            // 
            // lblFrancisSales
            // 
            lblFrancisSales.AutoSize = true;
            lblFrancisSales.Location = new Point(151, 294);
            lblFrancisSales.Name = "lblFrancisSales";
            lblFrancisSales.Size = new Size(0, 20);
            lblFrancisSales.TabIndex = 8;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(151, 329);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(0, 20);
            lblTotal.TabIndex = 9;
            // 
            // lblWinner
            // 
            lblWinner.AutoSize = true;
            lblWinner.Location = new Point(151, 390);
            lblWinner.Name = "lblWinner";
            lblWinner.Size = new Size(0, 20);
            lblWinner.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblWinner);
            Controls.Add(lblTotal);
            Controls.Add(lblFrancisSales);
            Controls.Add(lblEdwardSales);
            Controls.Add(lblDanielleSales);
            Controls.Add(label2);
            Controls.Add(btnFrancis);
            Controls.Add(btnEdward);
            Controls.Add(btnDanielle);
            Controls.Add(txtSale);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtSale;
        private Button btnDanielle;
        private Button btnEdward;
        private Button btnFrancis;
        private Label label2;
        private Label lblDanielleSales;
        private Label lblEdwardSales;
        private Label lblFrancisSales;
        private Label lblTotal;
        private Label lblWinner;
    }
}
