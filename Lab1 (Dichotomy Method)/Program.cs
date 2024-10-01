using org.mariuszgromada.math.mxparser;
using OxyPlot.Series;
using OxyPlot;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Lab1__Dichotomy_Method_
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
