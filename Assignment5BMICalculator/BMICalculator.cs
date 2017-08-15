using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
Name: Anupom Roy
ID  :300853516
Date: August 3, 2017
Description: UI Controls  Modify BMICalculator  Demo Project
Version: 0.4 Imperial and Metric RadioButton implemented
 */
namespace Assignment5BMICalculator
{
    public partial class BMICalculator : Form
    {
        //PRIVATE INSTANCES VARIABLES
        private double _result;

        //PUBLIC PROPERTIES
        public double RESULT
        {
            get
            {
                return this._result;
            }
            set
            {
                this._result = value;
            }
        }
        public BMICalculator()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            double height, wedth, result;
             height = Convert.ToDouble(HeightTextBox.Text);
             wedth = Convert.ToDouble(WeightTextBox.Text);
            result = (wedth * 703) / (height * height);

        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            HeightTextBox.Text = "";
            WeightTextBox.Text = "";
        }

        private void MetricRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            HeightUnitLabel.Text = "Meters";
            WeightUnitLabel.Text = "Kg";
        }

        private void ImperialRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            HeightUnitLabel.Text = "Inches";
            WeightUnitLabel.Text = "Pounds";
        }
    }
}
