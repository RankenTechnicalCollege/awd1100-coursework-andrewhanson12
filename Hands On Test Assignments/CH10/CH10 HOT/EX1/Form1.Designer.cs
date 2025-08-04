namespace EX1
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
            cboOccasion = new ComboBox();
            cboStyle = new ComboBox();
            chkEnvelope = new CheckBox();
            chkStamp = new CheckBox();
            chkCustomMessage = new CheckBox();
            rtbMessage = new RichTextBox();
            lblCost = new Label();
            pbCard = new PictureBox();
            lblOccasion = new Label();
            lblMessage = new Label();
            btnOrder = new Button();
            ((System.ComponentModel.ISupportInitialize)pbCard).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(68, 66);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 0;
            label1.Text = "Occasion ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(68, 123);
            label2.Name = "label2";
            label2.Size = new Size(41, 20);
            label2.TabIndex = 1;
            label2.Text = "Style";
            // 
            // cboOccasion
            // 
            cboOccasion.FormattingEnabled = true;
            cboOccasion.Location = new Point(170, 58);
            cboOccasion.Name = "cboOccasion";
            cboOccasion.Size = new Size(151, 28);
            cboOccasion.TabIndex = 2;
            cboOccasion.SelectedIndexChanged += cboOccasion_SelectedIndexChanged;
            // 
            // cboStyle
            // 
            cboStyle.FormattingEnabled = true;
            cboStyle.Location = new Point(170, 115);
            cboStyle.Name = "cboStyle";
            cboStyle.Size = new Size(151, 28);
            cboStyle.TabIndex = 3;
            cboStyle.SelectedIndexChanged += cboStyle_SelectedIndexChanged;
            // 
            // chkEnvelope
            // 
            chkEnvelope.AutoSize = true;
            chkEnvelope.Location = new Point(68, 177);
            chkEnvelope.Name = "chkEnvelope";
            chkEnvelope.Size = new Size(141, 24);
            chkEnvelope.TabIndex = 4;
            chkEnvelope.Text = "Envelope ($0.25)";
            chkEnvelope.UseVisualStyleBackColor = true;
            // 
            // chkStamp
            // 
            chkStamp.AutoSize = true;
            chkStamp.Location = new Point(68, 224);
            chkStamp.Name = "chkStamp";
            chkStamp.Size = new Size(123, 24);
            chkStamp.TabIndex = 5;
            chkStamp.Text = "Stamp ($0.50)";
            chkStamp.UseVisualStyleBackColor = true;
            // 
            // chkCustomMessage
            // 
            chkCustomMessage.AutoSize = true;
            chkCustomMessage.Location = new Point(68, 268);
            chkCustomMessage.Name = "chkCustomMessage";
            chkCustomMessage.Size = new Size(192, 24);
            chkCustomMessage.TabIndex = 6;
            chkCustomMessage.Text = "Custom Message ($0.30)";
            chkCustomMessage.UseVisualStyleBackColor = true;
            chkCustomMessage.CheckedChanged += chkCustomMessage_CheckedChanged;
            // 
            // rtbMessage
            // 
            rtbMessage.Enabled = false;
            rtbMessage.Location = new Point(68, 298);
            rtbMessage.Name = "rtbMessage";
            rtbMessage.Size = new Size(388, 120);
            rtbMessage.TabIndex = 7;
            rtbMessage.Text = "";
            // 
            // lblCost
            // 
            lblCost.AutoSize = true;
            lblCost.Location = new Point(68, 436);
            lblCost.Name = "lblCost";
            lblCost.Size = new Size(0, 20);
            lblCost.TabIndex = 8;
            // 
            // pbCard
            // 
            pbCard.Location = new Point(487, 46);
            pbCard.Name = "pbCard";
            pbCard.Size = new Size(346, 234);
            pbCard.SizeMode = PictureBoxSizeMode.Zoom;
            pbCard.TabIndex = 9;
            pbCard.TabStop = false;
            // 
            // lblOccasion
            // 
            lblOccasion.AutoSize = true;
            lblOccasion.Location = new Point(630, 137);
            lblOccasion.Name = "lblOccasion";
            lblOccasion.Size = new Size(0, 20);
            lblOccasion.TabIndex = 10;
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Location = new Point(501, 203);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(0, 20);
            lblMessage.TabIndex = 11;
            // 
            // btnOrder
            // 
            btnOrder.Location = new Point(362, 424);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(94, 49);
            btnOrder.TabIndex = 12;
            btnOrder.Text = "Order";
            btnOrder.UseVisualStyleBackColor = true;
            btnOrder.Click += btnOrder_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(845, 477);
            Controls.Add(btnOrder);
            Controls.Add(lblMessage);
            Controls.Add(lblOccasion);
            Controls.Add(pbCard);
            Controls.Add(lblCost);
            Controls.Add(rtbMessage);
            Controls.Add(chkCustomMessage);
            Controls.Add(chkStamp);
            Controls.Add(chkEnvelope);
            Controls.Add(cboStyle);
            Controls.Add(cboOccasion);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pbCard).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox cboOccasion;
        private ComboBox cboStyle;
        private CheckBox chkEnvelope;
        private CheckBox chkStamp;
        private CheckBox chkCustomMessage;
        private RichTextBox rtbMessage;
        private Label lblCost;
        private PictureBox pbCard;
        private Label lblOccasion;
        private Label lblMessage;
        private Button btnOrder;
    }
}
