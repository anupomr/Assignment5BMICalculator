namespace Assignment5BMICalculator
{
    partial class SplashScreeForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashScreeForm));
            this.BMIPictureBox = new System.Windows.Forms.PictureBox();
            this.MassageLabel = new System.Windows.Forms.Label();
            this.SplashScreenTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.BMIPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // BMIPictureBox
            // 
            this.BMIPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("BMIPictureBox.Image")));
            this.BMIPictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("BMIPictureBox.InitialImage")));
            this.BMIPictureBox.Location = new System.Drawing.Point(37, 167);
            this.BMIPictureBox.Name = "BMIPictureBox";
            this.BMIPictureBox.Size = new System.Drawing.Size(225, 225);
            this.BMIPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BMIPictureBox.TabIndex = 0;
            this.BMIPictureBox.TabStop = false;
            // 
            // MassageLabel
            // 
            this.MassageLabel.AutoSize = true;
            this.MassageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MassageLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.MassageLabel.Location = new System.Drawing.Point(51, 50);
            this.MassageLabel.Name = "MassageLabel";
            this.MassageLabel.Size = new System.Drawing.Size(192, 62);
            this.MassageLabel.TabIndex = 1;
            this.MassageLabel.Text = "Welcome My \r\nBMI Calculator";
            this.MassageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SplashScreenTimer
            // 
            this.SplashScreenTimer.Enabled = true;
            this.SplashScreenTimer.Tick += new System.EventHandler(this.SplashScreenTimer_Tick);
            // 
            // SplashScreeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 441);
            this.ControlBox = false;
            this.Controls.Add(this.MassageLabel);
            this.Controls.Add(this.BMIPictureBox);
            this.MaximizeBox = false;
            this.Name = "SplashScreeForm";
            this.Text = "SplashScreeForm";
            ((System.ComponentModel.ISupportInitialize)(this.BMIPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox BMIPictureBox;
        private System.Windows.Forms.Label MassageLabel;
        private System.Windows.Forms.Timer SplashScreenTimer;
    }
}