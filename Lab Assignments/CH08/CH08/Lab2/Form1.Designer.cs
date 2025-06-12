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
            label3 = new Label();
            txtNightsStayed = new TextBox();
            btnCalculate = new Button();
            lblNightlyRate = new Label();
            lblTotal = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(98, 86);
            label1.Name = "label1";
            label1.Size = new Size(101, 20);
            label1.TabIndex = 0;
            label1.Text = "Nights Stayed";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(419, 86);
            label2.Name = "label2";
            label2.Size = new Size(91, 20);
            label2.TabIndex = 1;
            label2.Text = "Nightly Rate";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(583, 86);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 2;
            label3.Text = "Total Cost";
            // 
            // txtNightsStayed
            // 
            txtNightsStayed.Location = new Point(98, 142);
            txtNightsStayed.Name = "txtNightsStayed";
            txtNightsStayed.Size = new Size(125, 27);
            txtNightsStayed.TabIndex = 3;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(271, 140);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(94, 29);
            btnCalculate.TabIndex = 4;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // lblNightlyRate
            // 
            lblNightlyRate.AutoSize = true;
            lblNightlyRate.Location = new Point(419, 145);
            lblNightlyRate.Name = "lblNightlyRate";
            lblNightlyRate.Size = new Size(0, 20);
            lblNightlyRate.TabIndex = 5;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(583, 145);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(0, 20);
            lblTotal.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblTotal);
            Controls.Add(lblNightlyRate);
            Controls.Add(btnCalculate);
            Controls.Add(txtNightsStayed);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "The Carefree Resort";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNightsStayed;
        private Button btnCalculate;
        private Label lblNightlyRate;
        private Label lblTotal;
    }
}
