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
Version: 0.6 Added the Form "FormClosing" event handler
 */
namespace Assignment5BMICalculator
{
    public partial class BMICalculator : Form
    {
        //PRIVATE INSTANCES VARIABLES
        private double _result;

        //PRIVATE CONSTANCES
        private const int BACKSPACE = 8;
        private const int DECIMAL_PONT = 46;
        private const int ZERO = 48;
        private const int NINE = 57;
        private const int NOT_FOUND = -1;

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

        /// <summary>
        /// This is a private mathod Calculate BMI
        /// </summary>
        /// <param name="height"></param>
        /// <param name="weight"></param>
        private void Calculate_BMI(double height, double weight)
        {
            if (MetricRadioButton.Checked)
            {
                this.RESULT = weight / Math.Pow(height, 2);
                resultTextBox.Text = string.Format("{0:f}", RESULT);
            }
            else
            {
                this.RESULT = (weight * 703) / Math.Pow(height, 2);
                resultTextBox.Text = string.Format("{0:f}", this.RESULT);
            }
        }
        /// <summary>
        /// This is the CalculateBMIButton_Click method which performs the calculation 
        /// whenever the calculate bmi button is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CalculateButton_Click(object sender, EventArgs e)
        {
            double height = double.Parse(HeightTextBox.Text);
            double weight = double.Parse(WeightTextBox.Text);
            Calculate_BMI(height, weight);

            if (this.RESULT > 30)
            {
                BMIProgressBar.Value = BMIProgressBar.Maximum;
                ResultListBox.Text = "Obese: 30 or greater";             
                BMIProgressBar.ForeColor = Color.Red;
            }
            else if (this.RESULT > 24.9 && this.RESULT<30)
            {
                BMIProgressBar.Value = (int)this.RESULT;
                ResultListBox.Text = "Overweight: Between 25 and 29.5";
                BMIProgressBar.ForeColor = Color.Orange;
            }
            else if (this.RESULT > 18.5 && this.RESULT<24.9)
            {
                BMIProgressBar.Value = (int)this.RESULT;
                ResultListBox.Text = "Normal: Between 18.5 and 24.9";
                BMIProgressBar.ForeColor = Color.Green;
            }
            else
            {
                BMIProgressBar.Value = (int)this.RESULT;
                ResultListBox.Text = "Underweight: Less then 18.5";
                BMIProgressBar.ForeColor = Color.LightGreen;
            }
            BMIProgressBar.Show();

        }
     
        private void ClearButton_Click(object sender, EventArgs e)
        {
            HeightTextBox.Text = "";
            WeightTextBox.Text = "";
            resultTextBox.Text = "";
            BMIProgressBar.Hide();
        }
        /// <summary>
        /// This method display metric units if MetricRadioButton is Checked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MetricRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            HeightUnitLabel.Text = "Meters";
            WeightUnitLabel.Text = "Kg";
        }
        /// <summary>
        /// This method display imperial units if MetricRadioButton is Checked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ImperialRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            HeightUnitLabel.Text = "Inches";
            WeightUnitLabel.Text = "Pounds";
        }
        /// <summary>
        /// This is an event handler for the BMIcalculatorclosing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BMICalculator_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// This is the HeightTextBox_KeyPress method which limits user's input
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HeightTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            int keyValue = e.KeyChar;

            if ((keyValue == BACKSPACE) || ((keyValue >= ZERO) && (keyValue <= NINE)))
            {
                return;
            }

            if ((keyValue == DECIMAL_PONT) && (HeightTextBox.Text.IndexOf(".") == NOT_FOUND))
            {
                return;
            }
            e.Handled = true;
        }
        /// <summary>
        /// This is the WeightTextBox_KeyPress method which limits user's input
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WeightTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            int keyValue = e.KeyChar;

            if ((keyValue == BACKSPACE) || ((keyValue >= ZERO) && (keyValue <= NINE)))
            {
                return;
            }

            if ((keyValue == DECIMAL_PONT) && (WeightTextBox.Text.IndexOf(".") == NOT_FOUND))
            {
                return;
            }
            e.Handled = true;
        }
    }
}
