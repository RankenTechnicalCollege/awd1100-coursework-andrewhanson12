namespace Lab3
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
            txtOne = new TextBox();
            txtTwo = new TextBox();
            txtThree = new TextBox();
            txtFour = new TextBox();
            txtFive = new TextBox();
            txtSix = new TextBox();
            txtSeven = new TextBox();
            txtEight = new TextBox();
            SuspendLayout();
            // 
            // txtOne
            // 
            txtOne.Location = new Point(294, 52);
            txtOne.Name = "txtOne";
            txtOne.Size = new Size(125, 27);
            txtOne.TabIndex = 0;
            txtOne.Text = "1";
            txtOne.Click += AnyTextBox_Click;
            txtOne.Enter += AnyTextBox_Focus;
            txtOne.KeyDown += AnyTextBox_KeyDown;
            txtOne.Leave += AnyTextBox_Leave;
            // 
            // txtTwo
            // 
            txtTwo.Location = new Point(430, 112);
            txtTwo.Name = "txtTwo";
            txtTwo.Size = new Size(125, 27);
            txtTwo.TabIndex = 1;
            txtTwo.Text = "2";
            txtTwo.Click += AnyTextBox_Click;
            txtTwo.Enter += AnyTextBox_Focus;
            txtTwo.KeyDown += AnyTextBox_KeyDown;
            txtTwo.Leave += AnyTextBox_Leave;
            // 
            // txtThree
            // 
            txtThree.Location = new Point(522, 186);
            txtThree.Name = "txtThree";
            txtThree.Size = new Size(125, 27);
            txtThree.TabIndex = 2;
            txtThree.Text = "3";
            txtThree.Click += AnyTextBox_Click;
            txtThree.Enter += AnyTextBox_Focus;
            txtThree.KeyDown += AnyTextBox_KeyDown;
            txtThree.Leave += AnyTextBox_Leave;
            // 
            // txtFour
            // 
            txtFour.Location = new Point(430, 261);
            txtFour.Name = "txtFour";
            txtFour.Size = new Size(125, 27);
            txtFour.TabIndex = 3;
            txtFour.Text = "4";
            txtFour.Click += AnyTextBox_Click;
            txtFour.Enter += AnyTextBox_Focus;
            txtFour.KeyDown += AnyTextBox_KeyDown;
            txtFour.Leave += AnyTextBox_Leave;
            // 
            // txtFive
            // 
            txtFive.Location = new Point(294, 306);
            txtFive.Name = "txtFive";
            txtFive.Size = new Size(125, 27);
            txtFive.TabIndex = 4;
            txtFive.Text = "5";
            txtFive.Click += AnyTextBox_Click;
            txtFive.Enter += AnyTextBox_Focus;
            txtFive.KeyDown += AnyTextBox_KeyDown;
            txtFive.Leave += AnyTextBox_Leave;
            // 
            // txtSix
            // 
            txtSix.Location = new Point(153, 261);
            txtSix.Name = "txtSix";
            txtSix.Size = new Size(125, 27);
            txtSix.TabIndex = 5;
            txtSix.Text = "6";
            txtSix.Click += AnyTextBox_Click;
            txtSix.Enter += AnyTextBox_Focus;
            txtSix.KeyDown += AnyTextBox_KeyDown;
            txtSix.Leave += AnyTextBox_Leave;
            // 
            // txtSeven
            // 
            txtSeven.Location = new Point(35, 186);
            txtSeven.Name = "txtSeven";
            txtSeven.Size = new Size(125, 27);
            txtSeven.TabIndex = 6;
            txtSeven.Text = "7";
            txtSeven.Click += AnyTextBox_Click;
            txtSeven.Enter += AnyTextBox_Focus;
            txtSeven.KeyDown += AnyTextBox_KeyDown;
            txtSeven.Leave += AnyTextBox_Leave;
            // 
            // txtEight
            // 
            txtEight.Location = new Point(133, 112);
            txtEight.Name = "txtEight";
            txtEight.Size = new Size(125, 27);
            txtEight.TabIndex = 7;
            txtEight.Text = "8";
            txtEight.Click += AnyTextBox_Click;
            txtEight.Enter += AnyTextBox_Focus;
            txtEight.KeyDown += AnyTextBox_KeyDown;
            txtEight.Leave += AnyTextBox_Leave;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtEight);
            Controls.Add(txtSeven);
            Controls.Add(txtSix);
            Controls.Add(txtFive);
            Controls.Add(txtFour);
            Controls.Add(txtThree);
            Controls.Add(txtTwo);
            Controls.Add(txtOne);
            Name = "Form1";
            Text = "Form1";
            Click += AnyTextBox_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtOne;
        private TextBox txtTwo;
        private TextBox txtThree;
        private TextBox txtFour;
        private TextBox txtFive;
        private TextBox txtSix;
        private TextBox txtSeven;
        private TextBox txtEight;
    }
}
