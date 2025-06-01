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
            label1 = new Label();
            label2 = new Label();
            lblResult = new Label();
            btnAdmit = new Button();
            txtGPA = new TextBox();
            txtTestScore = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(138, 89);
            label1.Name = "label1";
            label1.Size = new Size(36, 20);
            label1.TabIndex = 0;
            label1.Text = "GPA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(448, 89);
            label2.Name = "label2";
            label2.Size = new Size(149, 20);
            label2.TabIndex = 1;
            label2.Text = "Admission Test Score";
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(323, 260);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 20);
            lblResult.TabIndex = 2;
            // 
            // btnAdmit
            // 
            btnAdmit.Location = new Point(138, 256);
            btnAdmit.Name = "btnAdmit";
            btnAdmit.Size = new Size(94, 29);
            btnAdmit.TabIndex = 3;
            btnAdmit.Text = "Admit";
            btnAdmit.UseVisualStyleBackColor = true;
            btnAdmit.Click += btnAdmit_Click;
            // 
            // txtGPA
            // 
            txtGPA.Location = new Point(138, 143);
            txtGPA.Name = "txtGPA";
            txtGPA.Size = new Size(125, 27);
            txtGPA.TabIndex = 4;
            // 
            // txtTestScore
            // 
            txtTestScore.Location = new Point(448, 143);
            txtTestScore.Name = "txtTestScore";
            txtTestScore.Size = new Size(125, 27);
            txtTestScore.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtTestScore);
            Controls.Add(txtGPA);
            Controls.Add(btnAdmit);
            Controls.Add(lblResult);
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
        private Label lblResult;
        private Button btnAdmit;
        private TextBox txtGPA;
        private TextBox txtTestScore;
    }
}
