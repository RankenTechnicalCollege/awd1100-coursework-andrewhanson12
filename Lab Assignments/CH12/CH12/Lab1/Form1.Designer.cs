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
            txtTerm = new TextBox();
            btnDefine = new Button();
            lblResult = new Label();
            grpAdd = new GroupBox();
            lblCardAdded = new Label();
            btnAdd = new Button();
            txtNewDefinition = new TextBox();
            label2 = new Label();
            grpAdd.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(81, 31);
            label1.Name = "label1";
            label1.Size = new Size(261, 20);
            label1.TabIndex = 0;
            label1.Text = "What term do you want me to define?";
            // 
            // txtTerm
            // 
            txtTerm.Location = new Point(42, 70);
            txtTerm.Name = "txtTerm";
            txtTerm.Size = new Size(345, 27);
            txtTerm.TabIndex = 1;
            // 
            // btnDefine
            // 
            btnDefine.Location = new Point(466, 31);
            btnDefine.Name = "btnDefine";
            btnDefine.Size = new Size(131, 66);
            btnDefine.TabIndex = 2;
            btnDefine.Text = "Define";
            btnDefine.UseVisualStyleBackColor = true;
            btnDefine.Click += btnDefine_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(42, 123);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 20);
            lblResult.TabIndex = 3;
            // 
            // grpAdd
            // 
            grpAdd.Controls.Add(lblCardAdded);
            grpAdd.Controls.Add(btnAdd);
            grpAdd.Controls.Add(txtNewDefinition);
            grpAdd.Controls.Add(label2);
            grpAdd.Location = new Point(42, 204);
            grpAdd.Name = "grpAdd";
            grpAdd.Size = new Size(672, 220);
            grpAdd.TabIndex = 4;
            grpAdd.TabStop = false;
            grpAdd.Text = "Add Definition";
            grpAdd.Visible = false;
            // 
            // lblCardAdded
            // 
            lblCardAdded.AutoSize = true;
            lblCardAdded.Location = new Point(98, 177);
            lblCardAdded.Name = "lblCardAdded";
            lblCardAdded.Size = new Size(0, 20);
            lblCardAdded.TabIndex = 6;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(522, 86);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(131, 66);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtNewDefinition
            // 
            txtNewDefinition.Location = new Point(98, 86);
            txtNewDefinition.Multiline = true;
            txtNewDefinition.Name = "txtNewDefinition";
            txtNewDefinition.Size = new Size(392, 61);
            txtNewDefinition.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(137, 38);
            label2.Name = "label2";
            label2.Size = new Size(318, 20);
            label2.TabIndex = 0;
            label2.Text = "I don't know that term yet. What does it mean?";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(950, 450);
            Controls.Add(grpAdd);
            Controls.Add(lblResult);
            Controls.Add(btnDefine);
            Controls.Add(txtTerm);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            grpAdd.ResumeLayout(false);
            grpAdd.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtTerm;
        private Button btnDefine;
        private Label lblResult;
        private GroupBox grpAdd;
        private TextBox txtNewDefinition;
        private Label label2;
        private Label lblCardAdded;
        private Button btnAdd;
    }
}
