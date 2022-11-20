namespace Act2
{
    partial class InToCm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Convert = new System.Windows.Forms.Button();
            this.inchesLabel = new System.Windows.Forms.Label();
            this.centimetersLabel = new System.Windows.Forms.Label();
            this.inchesTextBox = new System.Windows.Forms.TextBox();
            this.centimetersTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Convert
            // 
            this.Convert.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Convert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Convert.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Convert.Location = new System.Drawing.Point(30, 175);
            this.Convert.Name = "Convert";
            this.Convert.Size = new System.Drawing.Size(189, 50);
            this.Convert.TabIndex = 0;
            this.Convert.Text = "CONVERT";
            this.Convert.UseVisualStyleBackColor = false;
            this.Convert.Click += new System.EventHandler(this.Convert_Click);
            // 
            // inchesLabel
            // 
            this.inchesLabel.AutoSize = true;
            this.inchesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inchesLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.inchesLabel.Location = new System.Drawing.Point(26, 33);
            this.inchesLabel.Name = "inchesLabel";
            this.inchesLabel.Size = new System.Drawing.Size(193, 20);
            this.inchesLabel.TabIndex = 1;
            this.inchesLabel.Text = "Enter length in Inches";
            // 
            // centimetersLabel
            // 
            this.centimetersLabel.AutoSize = true;
            this.centimetersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.centimetersLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.centimetersLabel.Location = new System.Drawing.Point(26, 98);
            this.centimetersLabel.Name = "centimetersLabel";
            this.centimetersLabel.Size = new System.Drawing.Size(195, 20);
            this.centimetersLabel.TabIndex = 2;
            this.centimetersLabel.Text = "Length in Centimeters";
            // 
            // inchesTextBox
            // 
            this.inchesTextBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.inchesTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inchesTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.inchesTextBox.Location = new System.Drawing.Point(283, 33);
            this.inchesTextBox.Name = "inchesTextBox";
            this.inchesTextBox.Size = new System.Drawing.Size(377, 27);
            this.inchesTextBox.TabIndex = 3;
            // 
            // centimetersTextBox
            // 
            this.centimetersTextBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.centimetersTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.centimetersTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.centimetersTextBox.Location = new System.Drawing.Point(283, 98);
            this.centimetersTextBox.Name = "centimetersTextBox";
            this.centimetersTextBox.ReadOnly = true;
            this.centimetersTextBox.Size = new System.Drawing.Size(377, 27);
            this.centimetersTextBox.TabIndex = 4;
            // 
            // InToCm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(695, 253);
            this.Controls.Add(this.centimetersTextBox);
            this.Controls.Add(this.inchesTextBox);
            this.Controls.Add(this.centimetersLabel);
            this.Controls.Add(this.inchesLabel);
            this.Controls.Add(this.Convert);
            this.Name = "InToCm";
            this.Text = "Convert Inches to Centimeters";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Convert;
        private System.Windows.Forms.Label inchesLabel;
        private System.Windows.Forms.Label centimetersLabel;
        private System.Windows.Forms.TextBox inchesTextBox;
        private System.Windows.Forms.TextBox centimetersTextBox;
    }
}