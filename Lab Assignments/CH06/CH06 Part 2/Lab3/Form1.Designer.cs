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
            txtBid = new TextBox();
            btnBid = new Button();
            lblResult = new Label();
            SuspendLayout();
            // 
            // txtBid
            // 
            txtBid.Location = new Point(85, 92);
            txtBid.Name = "txtBid";
            txtBid.Size = new Size(125, 27);
            txtBid.TabIndex = 0;
            // 
            // btnBid
            // 
            btnBid.Location = new Point(318, 91);
            btnBid.Name = "btnBid";
            btnBid.Size = new Size(94, 29);
            btnBid.TabIndex = 1;
            btnBid.Text = "Bid";
            btnBid.UseVisualStyleBackColor = true;
            btnBid.Click += btnBid_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(537, 95);
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
            Controls.Add(btnBid);
            Controls.Add(txtBid);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBid;
        private Button btnBid;
        private Label lblResult;
    }
}
