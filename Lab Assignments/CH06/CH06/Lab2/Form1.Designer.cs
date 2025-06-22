namespace Lab2
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
            txtGPA = new TextBox();
            txtTestScore = new TextBox();
            btnAdmit = new Button();
            lblResult = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(139, 109);
            label1.Name = "label1";
            label1.Size = new Size(36, 20);
            label1.TabIndex = 0;
            label1.Text = "GPA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(492, 109);
            label2.Name = "label2";
            label2.Size = new Size(149, 20);
            label2.TabIndex = 1;
            label2.Text = "Admission Test Score";
            // 
            // txtGPA
            // 
            txtGPA.Location = new Point(139, 165);
            txtGPA.Name = "txtGPA";
            txtGPA.Size = new Size(125, 27);
            txtGPA.TabIndex = 2;
            // 
            // txtTestScore
            // 
            txtTestScore.Location = new Point(492, 165);
            txtTestScore.Name = "txtTestScore";
            txtTestScore.Size = new Size(125, 27);
            txtTestScore.TabIndex = 3;
            // 
            // btnAdmit
            // 
            btnAdmit.Location = new Point(139, 244);
            btnAdmit.Name = "btnAdmit";
            btnAdmit.Size = new Size(94, 29);
            btnAdmit.TabIndex = 4;
            btnAdmit.Text = "Admit";
            btnAdmit.UseVisualStyleBackColor = true;
            btnAdmit.Click += btnAdmit_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(492, 248);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 20);
            lblResult.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResult);
            Controls.Add(btnAdmit);
            Controls.Add(txtTestScore);
            Controls.Add(txtGPA);
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
        private TextBox txtGPA;
        private TextBox txtTestScore;
        private Button btnAdmit;
        private Label lblResult;
    }
}
