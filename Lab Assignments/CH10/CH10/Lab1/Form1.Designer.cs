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
            cboHeros = new ComboBox();
            lblLikes = new Label();
            lblDislikes = new Label();
            lblSuperpower = new Label();
            lblBiography = new Label();
            lblName = new Label();
            pbHero = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            lblLink = new Label();
            ((System.ComponentModel.ISupportInitialize)pbHero).BeginInit();
            SuspendLayout();
            // 
            // cboHeros
            // 
            cboHeros.DropDownStyle = ComboBoxStyle.DropDownList;
            cboHeros.FormattingEnabled = true;
            cboHeros.Location = new Point(88, 71);
            cboHeros.Name = "cboHeros";
            cboHeros.Size = new Size(151, 28);
            cboHeros.TabIndex = 0;
            cboHeros.SelectedIndexChanged += cboHeros_SelectedIndexChanged;
            // 
            // lblLikes
            // 
            lblLikes.AutoSize = true;
            lblLikes.Location = new Point(195, 160);
            lblLikes.Name = "lblLikes";
            lblLikes.Size = new Size(0, 20);
            lblLikes.TabIndex = 1;
            // 
            // lblDislikes
            // 
            lblDislikes.AutoSize = true;
            lblDislikes.Location = new Point(195, 203);
            lblDislikes.Name = "lblDislikes";
            lblDislikes.Size = new Size(0, 20);
            lblDislikes.TabIndex = 2;
            // 
            // lblSuperpower
            // 
            lblSuperpower.AutoSize = true;
            lblSuperpower.Location = new Point(195, 247);
            lblSuperpower.Name = "lblSuperpower";
            lblSuperpower.Size = new Size(0, 20);
            lblSuperpower.TabIndex = 3;
            // 
            // lblBiography
            // 
            lblBiography.AutoSize = true;
            lblBiography.Location = new Point(88, 320);
            lblBiography.Name = "lblBiography";
            lblBiography.Size = new Size(0, 20);
            lblBiography.TabIndex = 4;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(195, 123);
            lblName.Name = "lblName";
            lblName.Size = new Size(0, 20);
            lblName.TabIndex = 5;
            // 
            // pbHero
            // 
            pbHero.Location = new Point(457, 50);
            pbHero.Name = "pbHero";
            pbHero.Size = new Size(184, 234);
            pbHero.SizeMode = PictureBoxSizeMode.Zoom;
            pbHero.TabIndex = 6;
            pbHero.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(88, 123);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 7;
            label1.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(88, 160);
            label2.Name = "label2";
            label2.Size = new Size(44, 20);
            label2.TabIndex = 8;
            label2.Text = "Likes:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(88, 203);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 9;
            label3.Text = "Dislikes:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(88, 247);
            label4.Name = "label4";
            label4.Size = new Size(92, 20);
            label4.TabIndex = 10;
            label4.Text = "Superpower:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(88, 289);
            label5.Name = "label5";
            label5.Size = new Size(80, 20);
            label5.TabIndex = 11;
            label5.Text = "Biography:";
            // 
            // lblLink
            // 
            lblLink.AutoSize = true;
            lblLink.Location = new Point(88, 391);
            lblLink.Name = "lblLink";
            lblLink.Size = new Size(0, 20);
            lblLink.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblLink);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pbHero);
            Controls.Add(lblName);
            Controls.Add(lblBiography);
            Controls.Add(lblSuperpower);
            Controls.Add(lblDislikes);
            Controls.Add(lblLikes);
            Controls.Add(cboHeros);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pbHero).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboHeros;
        private Label lblLikes;
        private Label lblDislikes;
        private Label lblSuperpower;
        private Label lblBiography;
        private Label lblName;
        private PictureBox pbHero;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label lblLink;
    }
}
