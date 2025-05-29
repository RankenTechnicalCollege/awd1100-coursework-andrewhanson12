namespace EX3
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
            txtLength = new TextBox();
            txtWidth = new TextBox();
            btnCalculate = new Button();
            lblArea = new Label();
            lblTotal = new Label();
            lblWeeklyFee = new Label();
            lblSeasonLength = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(166, 63);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 0;
            label1.Text = "Length (ft)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(409, 63);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 1;
            label2.Text = "Width (ft)";
            // 
            // txtLength
            // 
            txtLength.Location = new Point(166, 111);
            txtLength.Name = "txtLength";
            txtLength.Size = new Size(125, 27);
            txtLength.TabIndex = 2;
            // 
            // txtWidth
            // 
            txtWidth.Location = new Point(409, 111);
            txtWidth.Name = "txtWidth";
            txtWidth.Size = new Size(125, 27);
            txtWidth.TabIndex = 3;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(305, 177);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(94, 29);
            btnCalculate.TabIndex = 4;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // lblArea
            // 
            lblArea.AutoSize = true;
            lblArea.Location = new Point(166, 261);
            lblArea.Name = "lblArea";
            lblArea.Size = new Size(0, 20);
            lblArea.TabIndex = 5;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(166, 378);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(0, 20);
            lblTotal.TabIndex = 6;
            // 
            // lblWeeklyFee
            // 
            lblWeeklyFee.AutoSize = true;
            lblWeeklyFee.Location = new Point(166, 300);
            lblWeeklyFee.Name = "lblWeeklyFee";
            lblWeeklyFee.Size = new Size(0, 20);
            lblWeeklyFee.TabIndex = 7;
            // 
            // lblSeasonLength
            // 
            lblSeasonLength.AutoSize = true;
            lblSeasonLength.Location = new Point(166, 340);
            lblSeasonLength.Name = "lblSeasonLength";
            lblSeasonLength.Size = new Size(0, 20);
            lblSeasonLength.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblSeasonLength);
            Controls.Add(lblWeeklyFee);
            Controls.Add(lblTotal);
            Controls.Add(lblArea);
            Controls.Add(btnCalculate);
            Controls.Add(txtWidth);
            Controls.Add(txtLength);
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
        private TextBox txtLength;
        private TextBox txtWidth;
        private Button btnCalculate;
        private Label lblArea;
        private Label lblTotal;
        private Label lblWeeklyFee;
        private Label lblSeasonLength;
    }
}
