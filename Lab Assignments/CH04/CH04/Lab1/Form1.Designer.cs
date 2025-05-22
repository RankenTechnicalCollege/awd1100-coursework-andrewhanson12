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
            lblDistanceMiles = new Label();
            txtMiles = new TextBox();
            btnMilesToKm = new Button();
            txtKilometers = new TextBox();
            lblDistanceKm = new Label();
            btnKmToMiles = new Button();
            lblResult = new Label();
            SuspendLayout();
            // 
            // lblDistanceMiles
            // 
            lblDistanceMiles.AutoSize = true;
            lblDistanceMiles.Location = new Point(106, 72);
            lblDistanceMiles.Name = "lblDistanceMiles";
            lblDistanceMiles.Size = new Size(121, 20);
            lblDistanceMiles.TabIndex = 0;
            lblDistanceMiles.Text = "Distance in miles";
            // 
            // txtMiles
            // 
            txtMiles.Location = new Point(106, 113);
            txtMiles.Name = "txtMiles";
            txtMiles.Size = new Size(127, 27);
            txtMiles.TabIndex = 1;
            // 
            // btnMilesToKm
            // 
            btnMilesToKm.Location = new Point(106, 168);
            btnMilesToKm.Name = "btnMilesToKm";
            btnMilesToKm.Size = new Size(171, 29);
            btnMilesToKm.TabIndex = 2;
            btnMilesToKm.Text = "Convert to kilometers";
            btnMilesToKm.UseVisualStyleBackColor = true;
            btnMilesToKm.Click += btnMilesToKm_Click;
            // 
            // txtKilometers
            // 
            txtKilometers.Location = new Point(412, 113);
            txtKilometers.Name = "txtKilometers";
            txtKilometers.Size = new Size(127, 27);
            txtKilometers.TabIndex = 3;
            // 
            // lblDistanceKm
            // 
            lblDistanceKm.AutoSize = true;
            lblDistanceKm.Location = new Point(412, 72);
            lblDistanceKm.Name = "lblDistanceKm";
            lblDistanceKm.Size = new Size(155, 20);
            lblDistanceKm.TabIndex = 4;
            lblDistanceKm.Text = "Distance in kilometers";
            // 
            // btnKmToMiles
            // 
            btnKmToMiles.Location = new Point(412, 168);
            btnKmToMiles.Name = "btnKmToMiles";
            btnKmToMiles.Size = new Size(171, 29);
            btnKmToMiles.TabIndex = 5;
            btnKmToMiles.Text = "Convert to miles";
            btnKmToMiles.UseVisualStyleBackColor = true;
            btnKmToMiles.Click += btnKmToMiles_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(131, 296);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 20);
            lblResult.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(813, 450);
            Controls.Add(lblResult);
            Controls.Add(btnKmToMiles);
            Controls.Add(lblDistanceKm);
            Controls.Add(txtKilometers);
            Controls.Add(btnMilesToKm);
            Controls.Add(txtMiles);
            Controls.Add(lblDistanceMiles);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDistanceMiles;
        private TextBox txtMiles;
        private Button btnMilesToKm;
        private TextBox txtKilometers;
        private Label lblDistanceKm;
        private Button btnKmToMiles;
        private Label lblResult;
    }
}
