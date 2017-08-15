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
            this.ResultListBox = new System.Windows.Forms.ListBox();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.HeightTextBox = new System.Windows.Forms.TextBox();
            this.WeightTextBox = new System.Windows.Forms.TextBox();
            this.BmiCalculatorLabel = new System.Windows.Forms.Label();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.HeightUnitLabel = new System.Windows.Forms.Label();
            this.WeightUnitLabel = new System.Windows.Forms.Label();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.MetricRadioButton = new System.Windows.Forms.RadioButton();
            this.ImperialRadioButton = new System.Windows.Forms.RadioButton();
            this.BMIProgressBar = new System.Windows.Forms.ProgressBar();
            this.BMITableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // BMITableLayoutPanel
            // 
            this.BMITableLayoutPanel.ColumnCount = 6;
            this.BMITableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.6F));
            this.BMITableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.73F));
            this.BMITableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.6F));
            this.BMITableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.73F));
            this.BMITableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.6F));
            this.BMITableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.74F));
            this.BMITableLayoutPanel.Controls.Add(this.WeightLabel, 0, 3);
            this.BMITableLayoutPanel.Controls.Add(this.ResultListBox, 0, 5);
            this.BMITableLayoutPanel.Controls.Add(this.CalculateButton, 0, 4);
            this.BMITableLayoutPanel.Controls.Add(this.ClearButton, 1, 4);
            this.BMITableLayoutPanel.Controls.Add(this.HeightTextBox, 1, 2);
            this.BMITableLayoutPanel.Controls.Add(this.WeightTextBox, 1, 3);
            this.BMITableLayoutPanel.Controls.Add(this.BmiCalculatorLabel, 0, 0);
            this.BMITableLayoutPanel.Controls.Add(this.HeightLabel, 0, 2);
            this.BMITableLayoutPanel.Controls.Add(this.HeightUnitLabel, 2, 2);
            this.BMITableLayoutPanel.Controls.Add(this.WeightUnitLabel, 2, 3);
            this.BMITableLayoutPanel.Controls.Add(this.resultTextBox, 2, 4);
            this.BMITableLayoutPanel.Controls.Add(this.MetricRadioButton, 2, 1);
            this.BMITableLayoutPanel.Controls.Add(this.ImperialRadioButton, 0, 1);
            this.BMITableLayoutPanel.Controls.Add(this.BMIProgressBar, 1, 6);
            this.BMITableLayoutPanel.Location = new System.Drawing.Point(6, 12);
            this.BMITableLayoutPanel.Name = "BMITableLayoutPanel";
            this.BMITableLayoutPanel.RowCount = 7;
            this.BMITableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11182F));
            this.BMITableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11182F));
            this.BMITableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11182F));
            this.BMITableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11182F));
            this.BMITableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11182F));
            this.BMITableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33066F));
            this.BMITableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11022F));
            this.BMITableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.BMITableLayoutPanel.Size = new System.Drawing.Size(297, 417);
            this.BMITableLayoutPanel.TabIndex = 0;
            // 
            // WeightLabel
            // 
            this.WeightLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.WeightLabel.AutoSize = true;
            this.BMITableLayoutPanel.SetColumnSpan(this.WeightLabel, 2);
            this.WeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeightLabel.Location = new System.Drawing.Point(12, 144);
            this.WeightLabel.Name = "WeightLabel";
            this.WeightLabel.Size = new System.Drawing.Size(83, 20);
            this.WeightLabel.TabIndex = 2;
            this.WeightLabel.Text = "My Weight";
            // 
            // ResultListBox
            // 
            this.BMITableLayoutPanel.SetColumnSpan(this.ResultListBox, 6);
            this.ResultListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultListBox.FormattingEnabled = true;
            this.ResultListBox.ItemHeight = 24;
            this.ResultListBox.Items.AddRange(new object[] {
            "Under weight: Less then 18.5",
            "Normal: Between 18.5 and 24.9",
            "Overweight: Between 25 and 29.5",
            "Obese: 30 or greater"});
            this.ResultListBox.Location = new System.Drawing.Point(3, 223);
            this.ResultListBox.Name = "ResultListBox";
            this.ResultListBox.Size = new System.Drawing.Size(291, 100);
            this.ResultListBox.TabIndex = 5;
            // 
            // CalculateButton
            // 
            this.BMITableLayoutPanel.SetColumnSpan(this.CalculateButton, 2);
            this.CalculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculateButton.Location = new System.Drawing.Point(3, 179);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(92, 38);
            this.CalculateButton.TabIndex = 6;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // ClearButton
            // 
            this.BMITableLayoutPanel.SetColumnSpan(this.ClearButton, 2);
            this.ClearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButton.Location = new System.Drawing.Point(101, 179);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(92, 38);
            this.ClearButton.TabIndex = 7;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // HeightTextBox
            // 
            this.HeightTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BMITableLayoutPanel.SetColumnSpan(this.HeightTextBox, 2);
            this.HeightTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeightTextBox.Location = new System.Drawing.Point(103, 95);
            this.HeightTextBox.Name = "HeightTextBox";
            this.HeightTextBox.Size = new System.Drawing.Size(88, 29);
            this.HeightTextBox.TabIndex = 8;
            // 
            // WeightTextBox
            // 
            this.WeightTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BMITableLayoutPanel.SetColumnSpan(this.WeightTextBox, 2);
            this.WeightTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeightTextBox.Location = new System.Drawing.Point(103, 139);
            this.WeightTextBox.Name = "WeightTextBox";
            this.WeightTextBox.Size = new System.Drawing.Size(88, 29);
            this.WeightTextBox.TabIndex = 9;
            // 
            // BmiCalculatorLabel
            // 
            this.BmiCalculatorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BmiCalculatorLabel.AutoSize = true;
            this.BMITableLayoutPanel.SetColumnSpan(this.BmiCalculatorLabel, 6);
            this.BmiCalculatorLabel.Location = new System.Drawing.Point(3, 0);
            this.BmiCalculatorLabel.Name = "BmiCalculatorLabel";
            this.BmiCalculatorLabel.Size = new System.Drawing.Size(291, 44);
            this.BmiCalculatorLabel.TabIndex = 0;
            this.BmiCalculatorLabel.Text = "BMI Calculator";
            this.BmiCalculatorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HeightLabel
            // 
            this.HeightLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.HeightLabel.AutoSize = true;
            this.BMITableLayoutPanel.SetColumnSpan(this.HeightLabel, 2);
            this.HeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeightLabel.Location = new System.Drawing.Point(15, 100);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(80, 20);
            this.HeightLabel.TabIndex = 1;
            this.HeightLabel.Text = "My Height";
            this.HeightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HeightUnitLabel
            // 
            this.HeightUnitLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.HeightUnitLabel.AutoSize = true;
            this.BMITableLayoutPanel.SetColumnSpan(this.HeightUnitLabel, 2);
            this.HeightUnitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeightUnitLabel.Location = new System.Drawing.Point(213, 98);
            this.HeightUnitLabel.Name = "HeightUnitLabel";
            this.HeightUnitLabel.Size = new System.Drawing.Size(66, 24);
            this.HeightUnitLabel.TabIndex = 10;
            this.HeightUnitLabel.Text = "Inches";
            // 
            // WeightUnitLabel
            // 
            this.WeightUnitLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.WeightUnitLabel.AutoSize = true;
            this.BMITableLayoutPanel.SetColumnSpan(this.WeightUnitLabel, 2);
            this.WeightUnitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeightUnitLabel.Location = new System.Drawing.Point(209, 142);
            this.WeightUnitLabel.Name = "WeightUnitLabel";
            this.WeightUnitLabel.Size = new System.Drawing.Size(75, 24);
            this.WeightUnitLabel.TabIndex = 11;
            this.WeightUnitLabel.Text = "Pounds";
            // 
            // resultTextBox
            // 
            this.BMITableLayoutPanel.SetColumnSpan(this.resultTextBox, 2);
            this.resultTextBox.Location = new System.Drawing.Point(199, 179);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.Size = new System.Drawing.Size(95, 38);
            this.resultTextBox.TabIndex = 12;
            // 
            // MetricRadioButton
            // 
            this.MetricRadioButton.AutoSize = true;
            this.BMITableLayoutPanel.SetColumnSpan(this.MetricRadioButton, 3);
            this.MetricRadioButton.Location = new System.Drawing.Point(150, 47);
            this.MetricRadioButton.Name = "MetricRadioButton";
            this.MetricRadioButton.Size = new System.Drawing.Size(106, 35);
            this.MetricRadioButton.TabIndex = 4;
            this.MetricRadioButton.TabStop = true;
            this.MetricRadioButton.Text = "Metric";
            this.MetricRadioButton.UseVisualStyleBackColor = true;
            this.MetricRadioButton.CheckedChanged += new System.EventHandler(this.MetricRadioButton_CheckedChanged);
            // 
            // ImperialRadioButton
            // 
            this.ImperialRadioButton.AutoSize = true;
            this.BMITableLayoutPanel.SetColumnSpan(this.ImperialRadioButton, 3);
            this.ImperialRadioButton.Location = new System.Drawing.Point(3, 47);
            this.ImperialRadioButton.Name = "ImperialRadioButton";
            this.ImperialRadioButton.Size = new System.Drawing.Size(128, 35);
            this.ImperialRadioButton.TabIndex = 3;
            this.ImperialRadioButton.TabStop = true;
            this.ImperialRadioButton.Text = "Imperial";
            this.ImperialRadioButton.UseVisualStyleBackColor = true;
            this.ImperialRadioButton.CheckedChanged += new System.EventHandler(this.ImperialRadioButton_CheckedChanged);
            // 
            // BMIProgressBar
            // 
            this.BMITableLayoutPanel.SetColumnSpan(this.BMIProgressBar, 6);
            this.BMIProgressBar.Location = new System.Drawing.Point(3, 399);
            this.BMIProgressBar.Name = "BMIProgressBar";
            this.BMIProgressBar.Size = new System.Drawing.Size(291, 15);
            this.BMIProgressBar.TabIndex = 13;
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
        private System.Windows.Forms.Label HeightUnitLabel;
        private System.Windows.Forms.Label WeightUnitLabel;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.ProgressBar BMIProgressBar;
    }
}

