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
Description: BMI Calculator using windows forms and UI Controls
Version: 0.1 - Created SplashScreenTimer Tick event
 */
namespace Assignment5BMICalculator
{
    public partial class SplashScreeForm : Form
    {
        //PUBLIC PROPERTIES
        public BMICalculator BmiCalculator
        {
            get
            {
                return Program.bmiCalculator;
            }
        }

        public SplashScreeForm()
        {
            InitializeComponent();
        }

        private void SplashScreenTimer_Tick(object sender, EventArgs e)
        {
            this.BmiCalculator.Show();
            this.Hide();
            SplashScreenTimer.Enabled = false;//turned timer off

        }
    }
}
