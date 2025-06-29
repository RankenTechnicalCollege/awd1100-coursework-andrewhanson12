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
            txtNumber = new TextBox();
            btnEnter = new Button();
            lblCount = new Label();
            lblMin = new Label();
            lblMax = new Label();
            lblSum = new Label();
            lblAverage = new Label();
            SuspendLayout();
            // 
            // txtNumber
            // 
            txtNumber.Location = new Point(104, 71);
            txtNumber.Name = "txtNumber";
            txtNumber.Size = new Size(125, 27);
            txtNumber.TabIndex = 0;
            // 
            // btnEnter
            // 
            btnEnter.Location = new Point(327, 69);
            btnEnter.Name = "btnEnter";
            btnEnter.Size = new Size(94, 29);
            btnEnter.TabIndex = 1;
            btnEnter.Text = "Enter";
            btnEnter.UseVisualStyleBackColor = true;
            btnEnter.Click += btnEnter_Click;
            // 
            // lblCount
            // 
            lblCount.AutoSize = true;
            lblCount.Location = new Point(104, 187);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(0, 20);
            lblCount.TabIndex = 2;
            // 
            // lblMin
            // 
            lblMin.AutoSize = true;
            lblMin.Location = new Point(104, 240);
            lblMin.Name = "lblMin";
            lblMin.Size = new Size(0, 20);
            lblMin.TabIndex = 3;
            // 
            // lblMax
            // 
            lblMax.AutoSize = true;
            lblMax.Location = new Point(104, 293);
            lblMax.Name = "lblMax";
            lblMax.Size = new Size(0, 20);
            lblMax.TabIndex = 4;
            // 
            // lblSum
            // 
            lblSum.AutoSize = true;
            lblSum.Location = new Point(104, 342);
            lblSum.Name = "lblSum";
            lblSum.Size = new Size(0, 20);
            lblSum.TabIndex = 5;
            // 
            // lblAverage
            // 
            lblAverage.AutoSize = true;
            lblAverage.Location = new Point(104, 393);
            lblAverage.Name = "lblAverage";
            lblAverage.Size = new Size(0, 20);
            lblAverage.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblAverage);
            Controls.Add(lblSum);
            Controls.Add(lblMax);
            Controls.Add(lblMin);
            Controls.Add(lblCount);
            Controls.Add(btnEnter);
            Controls.Add(txtNumber);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNumber;
        private Button btnEnter;
        private Label lblCount;
        private Label lblMin;
        private Label lblMax;
        private Label lblSum;
        private Label lblAverage;
    }
}
