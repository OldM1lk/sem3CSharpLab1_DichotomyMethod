using System;
using System.Drawing;
using System.Windows.Forms;
using org.mariuszgromada.math.mxparser;
using OxyPlot.Series;
using OxyPlot;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Lab1__Dichotomy_Method_
{
    public partial class GoldenRatioForm : Form
    {
        private Expression expression;
        private Function function;
        private int precision;

        private Size formOriginalSize;
        private Rectangle recCalculateButton;
        private Rectangle recFunctionTextBox;
        private Rectangle recGraph;
        private Rectangle recLabel1;
        private Rectangle recLabel2;
        private Rectangle recLabel3;
        private Rectangle recLabel4;
        private Rectangle recLabel5;
        private Rectangle recLabel6;
        private Rectangle recPlotButton;
        private Rectangle recTextBoxA;
        private Rectangle recTextBoxB;
        private Rectangle recTextBoxE;

        private void AutoResize(Control control, Rectangle rectangle)
        {
            double xRatio = (double)(this.Width) / (double)(formOriginalSize.Width);
            double yRatio = (double)(this.Height) / (double)(formOriginalSize.Height);
            int newX = (int)(rectangle.X * xRatio);
            int newY = (int)(rectangle.Y * yRatio);

            int newWidth = (int)(rectangle.Width * xRatio);
            int newHeight = (int)(rectangle.Height * yRatio);

            control.Location = new Point(newX, newY);
            control.Size = new Size(newWidth, newHeight);
        }

        public GoldenRatioForm()
        {
            InitializeComponent();

            this.Resize += GoldenRatioForm_Resize;
            formOriginalSize = this.Size;
            recCalculateButton = new Rectangle(calculateButton.Location, calculateButton.Size);
            recFunctionTextBox = new Rectangle(functionTextBox.Location, functionTextBox.Size);
            recGraph = new Rectangle(graph.Location, graph.Size);
            recLabel1 = new Rectangle(label1.Location, label1.Size);
            recLabel2 = new Rectangle(label2.Location, label2.Size);
            recLabel3 = new Rectangle(label3.Location, label3.Size);
            recLabel4 = new Rectangle(label4.Location, label4.Size);
            recLabel5 = new Rectangle(label5.Location, label5.Size);
            recLabel6 = new Rectangle(label6.Location, label6.Size);
            recPlotButton = new Rectangle(plotButton.Location, plotButton.Size);
            recTextBoxA = new Rectangle(textBoxA.Location, textBoxA.Size);
            recTextBoxB = new Rectangle(textBoxB.Location, textBoxB.Size);
            recTextBoxE = new Rectangle(textBoxE.Location, textBoxE.Size);
        }

        private void GoldenRatioForm_Resize(object sender, EventArgs e)
        {
            AutoResize(calculateButton, recCalculateButton);
            AutoResize(functionTextBox, recFunctionTextBox);
            AutoResize(graph, recGraph);
            AutoResize(label1, recLabel1);
            AutoResize(label2, recLabel2);
            AutoResize(label3, recLabel3);
            AutoResize(label4, recLabel4);
            AutoResize(label5, recLabel5);
            AutoResize(label6, recLabel6);
            AutoResize(plotButton, recPlotButton);
            AutoResize(textBoxA, recTextBoxA);
            AutoResize(textBoxB, recTextBoxB);
            AutoResize(textBoxE, recTextBoxE);
        }

        private void GoldenRatioForm_Load(object sender, EventArgs e)
        {
            GoldenRatioForm_Resize(sender, e);
        }

        private void plotButton_Click(object sender, EventArgs e)
        {
            plotGraph();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            plotGraph();

            if (IsTextValid())
            {
                var output = GoldenRatioMethod(function, leftRestriction(), rightRestriction(), epsilon());
                ShowResult(output);
            }
        }

        private double leftRestriction()
        {
            return Convert.ToDouble(textBoxA.Text.Replace(".", ","));
        }

        private double rightRestriction()
        {
            return Convert.ToDouble(textBoxB.Text.Replace(".", ","));
        }

        private double epsilon()
        {
            if (textBoxE.Text.Replace(".", ",").Contains(","))
            {
                MessageBox.Show("Неправильно задано значение E, оно будет заменено на значение по умолчанию", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 3;
            }

            precision = Convert.ToInt16(textBoxE.Text.Replace(".", ","));

            if (precision < 0)
            {
                MessageBox.Show("Неправильно задано значение E, оно будет заменено на значение по умолчанию", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 3;
            }
            else if (precision > 13)
            {
                MessageBox.Show("Слишком большое значение E, оно будет заменено на значение по умолчанию", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 3;
            }
            else
            {
                return Math.Pow(10, -precision);
            }
        }

        private void plotGraph()
        {
            List<DataPoint> dot = new List<DataPoint>();

            var plotModel = new PlotModel { Title = "График функции" };

            var absicc = new LineSeries
            {
                Title = "Ось абсцисс",
                Color = OxyColor.FromRgb(0, 0, 0),
                StrokeThickness = 2
            };

            absicc.Points.Add(new DataPoint(-100, 0));
            absicc.Points.Add(new DataPoint(100, 0));

            var ordinate = new LineSeries
            {
                Title = "Ось ординат",
                Color = OxyColor.FromRgb(0, 0, 0),
                StrokeThickness = 2,
            };

            ordinate.Points.Add(new DataPoint(0, 100));
            ordinate.Points.Add(new DataPoint(0, -100));

            var lineSeries = new LineSeries
            {
                Title = "f(x)",
                Color = OxyColor.FromRgb(0, 255, 0)
            };

            function = new Function("f(x) = " + functionTextBox.Text);

            for (int pointIndex = -200; pointIndex <= 200; ++pointIndex)
            {
                expression = new Expression($"f({pointIndex})", function);
                double y = expression.calculate();
                dot.Add(new DataPoint(pointIndex, y));
            }

            lineSeries.Points.AddRange(dot);
            plotModel.Series.Add(lineSeries);
            plotModel.Series.Add(ordinate);
            plotModel.Series.Add(absicc);

            this.graph.Model = plotModel;
        }

        private double SolveFunction(Function function, string x)
        {
            return new Expression($"f({x})", function).calculate();
        }

        private void ShowResult(double result)
        {
            double resultValue = SolveFunction(function, result.ToString().Replace(",", "."));
            resultValue = Math.Round(resultValue, precision);
            result = Math.Round(result, precision);
            MessageBox.Show($"x = {result}\nf(x) = {resultValue}", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private bool IsTextValid()
        {
            Regex regex = new Regex(@"^[\d,.-]+$");
            bool result = true;

            if (string.IsNullOrEmpty(textBoxA.Text) || !regex.IsMatch(textBoxA.Text))
            {
                result = false;
                MessageBox.Show("Неправильно задана точка A", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(textBoxB.Text) || !regex.IsMatch(textBoxB.Text))
            {
                result = false;
                MessageBox.Show("Неправильно задана точка B", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(textBoxE.Text) || !regex.IsMatch(textBoxE.Text))
            {
                result = false;
                MessageBox.Show("Неправильно задано значение E", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return result;
        }

        public double GoldenRatioMethod(Function function, double leftRestriction, double rightRestriction, double epsilon)
        {
            double result = double.NaN;

            double leftValue = SolveFunction(function, leftRestriction.ToString().Replace(",", "."));
            double rightValue = SolveFunction(function, rightRestriction.ToString().Replace(",", "."));

            double d = (Math.Sqrt(5) - 1) / 2;

            double xFirst = rightRestriction - d * (rightRestriction - leftRestriction);
            double xSecond = leftRestriction + d * (rightRestriction - leftRestriction);

            double firstResult = SolveFunction(function, xFirst.ToString().Replace(",", "."));
            double secondResult = SolveFunction(function, xSecond.ToString().Replace(",", "."));


            while (Math.Abs(rightRestriction - leftRestriction) > epsilon)
            {
                if (firstResult < secondResult)
                {
                    rightRestriction = xSecond;
                    xSecond = xFirst;
                    xFirst = rightRestriction - d * (rightRestriction - leftRestriction);
                    firstResult = SolveFunction(function, xFirst.ToString().Replace(",", "."));
                    secondResult = SolveFunction(function, xSecond.ToString().Replace(",", "."));
                }
                else
                {
                    leftRestriction = xFirst;
                    xFirst = xSecond;
                    xSecond = leftRestriction + d * (rightRestriction - leftRestriction);
                    firstResult = SolveFunction(function, xFirst.ToString().Replace(",", "."));
                    secondResult = SolveFunction(function, xSecond.ToString().Replace(",", "."));
                }
            }

            result = (leftRestriction + rightRestriction) / 2;

            return result;
        }
    }
}
