namespace Lab1
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
            txtNumOne = new TextBox();
            txtNumTwo = new TextBox();
            txtNumThree = new TextBox();
            txtNumFour = new TextBox();
            btnReverse = new Button();
            SuspendLayout();
            // 
            // txtNumOne
            // 
            txtNumOne.Location = new Point(94, 96);
            txtNumOne.Name = "txtNumOne";
            txtNumOne.Size = new Size(125, 27);
            txtNumOne.TabIndex = 0;
            // 
            // txtNumTwo
            // 
            txtNumTwo.Location = new Point(241, 96);
            txtNumTwo.Name = "txtNumTwo";
            txtNumTwo.Size = new Size(125, 27);
            txtNumTwo.TabIndex = 1;
            // 
            // txtNumThree
            // 
            txtNumThree.Location = new Point(391, 96);
            txtNumThree.Name = "txtNumThree";
            txtNumThree.Size = new Size(125, 27);
            txtNumThree.TabIndex = 2;
            // 
            // txtNumFour
            // 
            txtNumFour.Location = new Point(540, 96);
            txtNumFour.Name = "txtNumFour";
            txtNumFour.Size = new Size(125, 27);
            txtNumFour.TabIndex = 3;
            // 
            // btnReverse
            // 
            btnReverse.Location = new Point(94, 207);
            btnReverse.Name = "btnReverse";
            btnReverse.Size = new Size(94, 29);
            btnReverse.TabIndex = 4;
            btnReverse.Text = "Reverse";
            btnReverse.UseVisualStyleBackColor = true;
            btnReverse.Click += btnReverse_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnReverse);
            Controls.Add(txtNumFour);
            Controls.Add(txtNumThree);
            Controls.Add(txtNumTwo);
            Controls.Add(txtNumOne);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNumOne;
        private TextBox txtNumTwo;
        private TextBox txtNumThree;
        private TextBox txtNumFour;
        private Button btnReverse;
    }
}
