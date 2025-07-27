namespace EX2
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
            btnArithmatic = new Button();
            btnFormat = new Button();
            btnCast = new Button();
            btnNull = new Button();
            SuspendLayout();
            // 
            // btnArithmatic
            // 
            btnArithmatic.Location = new Point(2, -1);
            btnArithmatic.Name = "btnArithmatic";
            btnArithmatic.Size = new Size(414, 232);
            btnArithmatic.TabIndex = 0;
            btnArithmatic.Text = "System.ArtithmeticException";
            btnArithmatic.UseVisualStyleBackColor = true;
            btnArithmatic.Click += btnArithmatic_Click;
            // 
            // btnFormat
            // 
            btnFormat.Location = new Point(409, -1);
            btnFormat.Name = "btnFormat";
            btnFormat.Size = new Size(392, 232);
            btnFormat.TabIndex = 1;
            btnFormat.Text = "System.FormatException";
            btnFormat.UseVisualStyleBackColor = true;
            btnFormat.Click += btnFormat_Click;
            // 
            // btnCast
            // 
            btnCast.Location = new Point(2, 225);
            btnCast.Name = "btnCast";
            btnCast.Size = new Size(414, 232);
            btnCast.TabIndex = 2;
            btnCast.Text = "System.InvalidCastException";
            btnCast.UseVisualStyleBackColor = true;
            btnCast.Click += btnCast_Click;
            // 
            // btnNull
            // 
            btnNull.Location = new Point(409, 225);
            btnNull.Name = "btnNull";
            btnNull.Size = new Size(414, 232);
            btnNull.TabIndex = 3;
            btnNull.Text = "System.NullReferenceException";
            btnNull.UseVisualStyleBackColor = true;
            btnNull.Click += btnNull_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnNull);
            Controls.Add(btnCast);
            Controls.Add(btnFormat);
            Controls.Add(btnArithmatic);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnArithmatic;
        private Button btnFormat;
        private Button btnCast;
        private Button btnNull;
    }
}
