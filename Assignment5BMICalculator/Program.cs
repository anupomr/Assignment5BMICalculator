using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
Name: Anupom Roy
ID  :300853516
Date: August 3, 2017
Description: BMICalculator  Demo Project
Version: 0.1 created an instance of the BMICalculator object
 */
namespace Assignment5BMICalculator
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new BMICalculator());
        }
    }
}
