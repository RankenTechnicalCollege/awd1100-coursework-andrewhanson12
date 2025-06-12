namespace Lab5
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
            txtCard = new TextBox();
            btnMask = new Button();
            lblResult = new Label();
            SuspendLayout();
            // 
            // txtCard
            // 
            txtCard.Location = new Point(143, 91);
            txtCard.Name = "txtCard";
            txtCard.Size = new Size(215, 27);
            txtCard.TabIndex = 0;
            // 
            // btnMask
            // 
            btnMask.Location = new Point(444, 89);
            btnMask.Name = "btnMask";
            btnMask.Size = new Size(94, 29);
            btnMask.TabIndex = 1;
            btnMask.Text = "Mask";
            btnMask.UseVisualStyleBackColor = true;
            btnMask.Click += btnMask_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(143, 183);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 20);
            lblResult.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResult);
            Controls.Add(btnMask);
            Controls.Add(txtCard);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCard;
        private Button btnMask;
        private Label lblResult;
    }
}
