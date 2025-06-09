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
            label1 = new Label();
            txtPhrase = new TextBox();
            btnEnter = new Button();
            lblResult = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(164, 69);
            label1.Name = "label1";
            label1.Size = new Size(149, 20);
            label1.TabIndex = 0;
            label1.Text = "Please enter a phrase";
            // 
            // txtPhrase
            // 
            txtPhrase.Location = new Point(164, 115);
            txtPhrase.Name = "txtPhrase";
            txtPhrase.Size = new Size(125, 27);
            txtPhrase.TabIndex = 1;
            // 
            // btnEnter
            // 
            btnEnter.Location = new Point(387, 113);
            btnEnter.Name = "btnEnter";
            btnEnter.Size = new Size(94, 29);
            btnEnter.TabIndex = 2;
            btnEnter.Text = "Enter";
            btnEnter.UseVisualStyleBackColor = true;
            btnEnter.Click += btnEnter_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(164, 214);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 20);
            lblResult.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResult);
            Controls.Add(btnEnter);
            Controls.Add(txtPhrase);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtPhrase;
        private Button btnEnter;
        private Label lblResult;
    }
}
