namespace Lab6
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
            lblCostWood = new Label();
            lblCostDrawers = new Label();
            lblTotal = new Label();
            txtWood = new TextBox();
            txtDrawers = new TextBox();
            btnCalculate = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(126, 76);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 0;
            label1.Text = "Type of wood";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(421, 76);
            label2.Name = "label2";
            label2.Size = new Size(137, 20);
            label2.TabIndex = 1;
            label2.Text = "Number of drawers";
            // 
            // lblCostWood
            // 
            lblCostWood.AutoSize = true;
            lblCostWood.Location = new Point(91, 290);
            lblCostWood.Name = "lblCostWood";
            lblCostWood.Size = new Size(0, 20);
            lblCostWood.TabIndex = 2;
            // 
            // lblCostDrawers
            // 
            lblCostDrawers.AutoSize = true;
            lblCostDrawers.Location = new Point(329, 290);
            lblCostDrawers.Name = "lblCostDrawers";
            lblCostDrawers.Size = new Size(0, 20);
            lblCostDrawers.TabIndex = 3;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(535, 290);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(0, 20);
            lblTotal.TabIndex = 4;
            // 
            // txtWood
            // 
            txtWood.Location = new Point(126, 117);
            txtWood.Name = "txtWood";
            txtWood.Size = new Size(125, 27);
            txtWood.TabIndex = 5;
            // 
            // txtDrawers
            // 
            txtDrawers.Location = new Point(421, 117);
            txtDrawers.Name = "txtDrawers";
            txtDrawers.Size = new Size(125, 27);
            txtDrawers.TabIndex = 6;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(126, 184);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(94, 29);
            btnCalculate.TabIndex = 7;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCalculate);
            Controls.Add(txtDrawers);
            Controls.Add(txtWood);
            Controls.Add(lblTotal);
            Controls.Add(lblCostDrawers);
            Controls.Add(lblCostWood);
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
        private Label lblCostWood;
        private Label lblCostDrawers;
        private Label lblTotal;
        private TextBox txtWood;
        private TextBox txtDrawers;
        private Button btnCalculate;
    }
}
