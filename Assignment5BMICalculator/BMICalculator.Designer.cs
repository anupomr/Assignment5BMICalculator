namespace Assignment5BMICalculator
{
    partial class BMICalculator
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
            this.BMITableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.WeightLabel = new System.Windows.Forms.Label();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.ImperialRadioButton = new System.Windows.Forms.RadioButton();
            this.MetricRadioButton = new System.Windows.Forms.RadioButton();
            this.ResultListBox = new System.Windows.Forms.ListBox();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.HeightTextBox = new System.Windows.Forms.TextBox();
            this.WeightTextBox = new System.Windows.Forms.TextBox();
            this.BmiCalculatorLabel = new System.Windows.Forms.Label();
            this.BMITableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // BMITableLayoutPanel
            // 
            this.BMITableLayoutPanel.ColumnCount = 2;
            this.BMITableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.BMITableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.BMITableLayoutPanel.Controls.Add(this.WeightLabel, 0, 3);
            this.BMITableLayoutPanel.Controls.Add(this.HeightLabel, 0, 2);
            this.BMITableLayoutPanel.Controls.Add(this.ImperialRadioButton, 0, 1);
            this.BMITableLayoutPanel.Controls.Add(this.MetricRadioButton, 1, 1);
            this.BMITableLayoutPanel.Controls.Add(this.ResultListBox, 0, 5);
            this.BMITableLayoutPanel.Controls.Add(this.CalculateButton, 0, 4);
            this.BMITableLayoutPanel.Controls.Add(this.ClearButton, 1, 4);
            this.BMITableLayoutPanel.Controls.Add(this.HeightTextBox, 1, 2);
            this.BMITableLayoutPanel.Controls.Add(this.WeightTextBox, 1, 3);
            this.BMITableLayoutPanel.Controls.Add(this.BmiCalculatorLabel, 0, 0);
            this.BMITableLayoutPanel.Location = new System.Drawing.Point(6, 12);
            this.BMITableLayoutPanel.Name = "BMITableLayoutPanel";
            this.BMITableLayoutPanel.RowCount = 6;
            this.BMITableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.BMITableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.BMITableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.BMITableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.BMITableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.BMITableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.44444F));
            this.BMITableLayoutPanel.Size = new System.Drawing.Size(297, 417);
            this.BMITableLayoutPanel.TabIndex = 0;
            // 
            // WeightLabel
            // 
            this.WeightLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.WeightLabel.AutoSize = true;
            this.WeightLabel.Location = new System.Drawing.Point(4, 145);
            this.WeightLabel.Name = "WeightLabel";
            this.WeightLabel.Size = new System.Drawing.Size(141, 31);
            this.WeightLabel.TabIndex = 2;
            this.WeightLabel.Text = "My Weight";
            // 
            // HeightLabel
            // 
            this.HeightLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.HeightLabel.AutoSize = true;
            this.HeightLabel.Location = new System.Drawing.Point(9, 99);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(136, 31);
            this.HeightLabel.TabIndex = 1;
            this.HeightLabel.Text = "My Height";
            this.HeightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ImperialRadioButton
            // 
            this.ImperialRadioButton.AutoSize = true;
            this.ImperialRadioButton.Location = new System.Drawing.Point(3, 49);
            this.ImperialRadioButton.Name = "ImperialRadioButton";
            this.ImperialRadioButton.Size = new System.Drawing.Size(128, 35);
            this.ImperialRadioButton.TabIndex = 3;
            this.ImperialRadioButton.TabStop = true;
            this.ImperialRadioButton.Text = "Imperial";
            this.ImperialRadioButton.UseVisualStyleBackColor = true;
            // 
            // MetricRadioButton
            // 
            this.MetricRadioButton.AutoSize = true;
            this.MetricRadioButton.Location = new System.Drawing.Point(151, 49);
            this.MetricRadioButton.Name = "MetricRadioButton";
            this.MetricRadioButton.Size = new System.Drawing.Size(106, 35);
            this.MetricRadioButton.TabIndex = 4;
            this.MetricRadioButton.TabStop = true;
            this.MetricRadioButton.Text = "Metric";
            this.MetricRadioButton.UseVisualStyleBackColor = true;
            // 
            // ResultListBox
            // 
            this.BMITableLayoutPanel.SetColumnSpan(this.ResultListBox, 2);
            this.ResultListBox.FormattingEnabled = true;
            this.ResultListBox.ItemHeight = 31;
            this.ResultListBox.Location = new System.Drawing.Point(3, 233);
            this.ResultListBox.Name = "ResultListBox";
            this.ResultListBox.Size = new System.Drawing.Size(291, 159);
            this.ResultListBox.TabIndex = 5;
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(3, 187);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(137, 40);
            this.CalculateButton.TabIndex = 6;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(151, 187);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(143, 40);
            this.ClearButton.TabIndex = 7;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            // 
            // HeightTextBox
            // 
            this.HeightTextBox.Location = new System.Drawing.Point(151, 95);
            this.HeightTextBox.Name = "HeightTextBox";
            this.HeightTextBox.Size = new System.Drawing.Size(143, 38);
            this.HeightTextBox.TabIndex = 8;
            // 
            // WeightTextBox
            // 
            this.WeightTextBox.Location = new System.Drawing.Point(151, 141);
            this.WeightTextBox.Name = "WeightTextBox";
            this.WeightTextBox.Size = new System.Drawing.Size(143, 38);
            this.WeightTextBox.TabIndex = 9;
            // 
            // BmiCalculatorLabel
            // 
            this.BmiCalculatorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BmiCalculatorLabel.AutoSize = true;
            this.BMITableLayoutPanel.SetColumnSpan(this.BmiCalculatorLabel, 2);
            this.BmiCalculatorLabel.Location = new System.Drawing.Point(3, 0);
            this.BmiCalculatorLabel.Name = "BmiCalculatorLabel";
            this.BmiCalculatorLabel.Size = new System.Drawing.Size(291, 46);
            this.BmiCalculatorLabel.TabIndex = 0;
            this.BmiCalculatorLabel.Text = "BMI Calculator";
            this.BmiCalculatorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BMICalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 441);
            this.Controls.Add(this.BMITableLayoutPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximizeBox = false;
            this.Name = "BMICalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMICalculator";
            this.BMITableLayoutPanel.ResumeLayout(false);
            this.BMITableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel BMITableLayoutPanel;
        private System.Windows.Forms.Label BmiCalculatorLabel;
        private System.Windows.Forms.Label WeightLabel;
        private System.Windows.Forms.Label HeightLabel;
        private System.Windows.Forms.RadioButton ImperialRadioButton;
        private System.Windows.Forms.RadioButton MetricRadioButton;
        private System.Windows.Forms.ListBox ResultListBox;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.TextBox HeightTextBox;
        private System.Windows.Forms.TextBox WeightTextBox;
    }
}

