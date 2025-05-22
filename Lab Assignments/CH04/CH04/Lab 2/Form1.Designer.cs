namespace Lab_2
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
            lblNumChickens = new Label();
            txtEggsOne = new TextBox();
            txtEggsFour = new TextBox();
            txtEggsThree = new TextBox();
            txtEggsTwo = new TextBox();
            btnCalculate = new Button();
            lblResult = new Label();
            SuspendLayout();
            // 
            // lblNumChickens
            // 
            lblNumChickens.AutoSize = true;
            lblNumChickens.Location = new Point(218, 52);
            lblNumChickens.Name = "lblNumChickens";
            lblNumChickens.Size = new Size(328, 20);
            lblNumChickens.TabIndex = 0;
            lblNumChickens.Text = "Enter the number of eggs layed by each chicken:";
            // 
            // txtEggsOne
            // 
            txtEggsOne.Location = new Point(103, 121);
            txtEggsOne.Name = "txtEggsOne";
            txtEggsOne.Size = new Size(125, 27);
            txtEggsOne.TabIndex = 1;
            // 
            // txtEggsFour
            // 
            txtEggsFour.Location = new Point(555, 121);
            txtEggsFour.Name = "txtEggsFour";
            txtEggsFour.Size = new Size(125, 27);
            txtEggsFour.TabIndex = 2;
            // 
            // txtEggsThree
            // 
            txtEggsThree.Location = new Point(405, 121);
            txtEggsThree.Name = "txtEggsThree";
            txtEggsThree.Size = new Size(125, 27);
            txtEggsThree.TabIndex = 3;
            // 
            // txtEggsTwo
            // 
            txtEggsTwo.Location = new Point(253, 121);
            txtEggsTwo.Name = "txtEggsTwo";
            txtEggsTwo.Size = new Size(125, 27);
            txtEggsTwo.TabIndex = 4;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(314, 192);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(138, 45);
            btnCalculate.TabIndex = 5;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(242, 310);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 20);
            lblResult.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResult);
            Controls.Add(btnCalculate);
            Controls.Add(txtEggsTwo);
            Controls.Add(txtEggsThree);
            Controls.Add(txtEggsFour);
            Controls.Add(txtEggsOne);
            Controls.Add(lblNumChickens);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNumChickens;
        private TextBox txtEggsOne;
        private TextBox txtEggsFour;
        private TextBox txtEggsThree;
        private TextBox txtEggsTwo;
        private Button btnCalculate;
        private Label lblResult;
    }
}
