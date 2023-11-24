using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml.Serialization;
using System.Diagnostics;
using org.mariuszgromada.math.mxparser;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Net.NetworkInformation;



namespace Exe
{
    public partial class ExeForm : Form
    {
        double begin, end;              // начало и конец интервала.
        int accuracy;
        // точность.

        public ExeForm()
        {
            InitializeComponent();
        }


        // обработчик запуска.
        private void запуститьToolStripMenuItem_Click(object sender, EventArgs eventArgs)
        {
            // проверка правильности ввода.
            if (!double.TryParse(txtInterval1.Text, out begin) || !double.TryParse(txtInterval2.Text, out end) || begin >= end)
            {
                MessageBox.Show("Введите корректные значения для интервала: ");
                return;
            }

            string accuracyString = txtAccuracy.Text.Trim();
            if (accuracyString.Contains('-'))
            {
                MessageBox.Show("Введите положительное значение для точности: ");
                return;
            }
            else
            {
                if (accuracyString.Contains(','))
                {
                    // подсчет количества знаков после запятой.
                    int decimalPlaces = accuracyString.Length - accuracyString.IndexOf(',') - 1;
                    accuracy = decimalPlaces;
                }
                else
                {
                    // Проверка корректности ввода для accuracy.
                    if (!int.TryParse(accuracyString, out accuracy))
                    {
                        MessageBox.Show("Введите корректное значение для точности: ");
                        return;
                    }
                }
            }
        }



        private void chartDichotomy_Click(object sender, EventArgs eventArgs)
            {
                double interval1Value = double.Parse(txtInterval1.Text);
                double leftBorder = interval1Value - 1;
                double interval2Value = double.Parse(txtInterval2.Text);
                double rightBorder = interval2Value + 1;
                double CoordStep = 0.1;
                double CoordX;
                double CoordY;
                this.chartDichotomy.Series[0].Points.Clear();
                chartDichotomy.ChartAreas[0].AxisX.Interval = 1;
                CoordX = leftBorder + CoordStep;
                while (CoordX <= rightBorder)
                {
                    CoordY = Func(CoordX);
                    this.chartDichotomy.Series[0].Points.AddXY(CoordX, CoordY);
                    CoordX += CoordStep;
                }
            }
            // Обработчик очисти меня.
            private void очиститьToolStripMenuItem_Click(object sender, EventArgs eventArgs)
            {
                // oчистка всех полей ввода.
                txtInterval1.Clear();
                txtInterval2.Clear();
                txtAccuracy.Clear();
                chartDichotomy.Series[0].Points.Clear();
            }


            private double MatchParser(double point)                             //ввод функции в прогу.
            {
                Argument x = new Argument("x");
                x.setArgumentValue(point); 
                Expression e = new Expression(formula.Text.ToString(), x);
                return e.calculate();

            }




            // Метод функции
            private double Func(double x)
            {
                return MatchParser(x);
            }
            private double AntiFunc(double x)
            {
                return MatchParser(-(x));
            }
            private double Derivative(double point)
            {
                Argument x = new Argument("x");
                x.setArgumentValue(point);
                string formul = formula.Text.ToString();
                string derivateFormula = "der(" + formul + ",x)";
                Expression expression = new Expression(derivateFormula, x);
                return expression.calculate();

            }

        // Метод Дихотомии
        private double Dichotomy(double begin, double end, int accuracy)
        {
            double x1 = begin;
            double x2 = end;
            double x3 = (x1 + x2) / 2;
            while (Math.Abs(x2 - x1) > Math.Pow(10, -accuracy))
            {
                double y1 = Func(x1), y2 = Func(x2), y3 = Func(x3);
                if (y1 * y3 < 0) { x2 = x3; }
                else if (y2 * y3 < 0) { x1 = x3; }
                else { break; }
                x3 = (x1 + x2) / 2;
            }
            if ((27 - 18 * x3 + 2 * Math.Pow(x3, 2)) * Math.Exp(-x3 / 3) < 0 + x3 && (27 - 18 * x3 + 2 * Math.Pow(x3, 2)) * Math.Exp(-x3 / 3) > 0 - x3)
            {
                return Math.Round(x3, accuracy);
            }
            return 0;
        }
        private double CoordinateDescent(double begin, double end, int accuracy)
        {
            double a = begin, b = end;
            double x = (a + b) / 2;
            double delta = 1 / Math.Pow(10, accuracy);
            while (b - a > delta)
            {
                if (Func(a) > Func(b)) a = x;
                else if (Func(b) > Func(a)) b = x;
                else break;
                x = (a + b) / 2;
            }
            return Math.Round(x, accuracy);
        }
        public double AntiCoordinateDescent(double begin, double end, int accuracy)
            {
                double a = begin, b = end;
                double x = (a + b) / 2; // Инициализация начального значения x
                double delta = 1 / Math.Pow(10, accuracy); // Вычисление дельты по точности n

                while (b - a > delta) // Условие остановки
                {
                    if (AntiFunc(a) < AntiFunc(b))
                        a = x; // Если значение функции в точке a больше, обновляем начальную границу
                    else
                        b = x; // Иначе обновляем конечную границу

                    x = (a + b) / 2; // Вычисление нового значения x
                }

                return Math.Round(x, accuracy); // Возвращаем значение x с заданной точностью n
            }








            private void очиститьDichotomyToolStripMenuItem_Click(object sender, EventArgs eventArgs)
            {
                // Очистка всех полей ввода
                txtInterval1.Clear();
                txtInterval2.Clear();
                txtAccuracy.Clear();
                this.chartDichotomy.Series[0].Points.Clear();
            }
            private void дихотомияToolStripMenuItem1_Click(object sender, EventArgs EventArgs)

            {
                // Решение задачи методом дихотомии
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                double resultDichotomy = Dichotomy(begin, end, accuracy);
                stopwatch.Stop();
                string dichotomyResult;
                if (resultDichotomy == begin || resultDichotomy == end)
                {
                    dichotomyResult = "Точки пересечения нет на данном интервале";
                }
                else
                {
                    dichotomyResult = resultDichotomy.ToString();
                }
                double elapsedTimeInNanoseconds = stopwatch.Elapsed.TotalMilliseconds * 1000000;
                chartDichotomy_Click(sender, EventArgs);
                MessageBox.Show($"Ноль функции: {dichotomyResult} \n Время выполнения: {elapsedTimeInNanoseconds} наносекунд");
            }





            private void DichotomyForm_Load(object sender, EventArgs e)
            {

            }

            private void lblPrecision_Click(object sender, EventArgs e)
            {

            }

            private void lblIntervalStart_Click(object sender, EventArgs e)
            {

            }

            private void покоординатныйСпускToolStripMenuItem_Click(object sender, EventArgs EventArgs)

            {

                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                double resultMin = CoordinateDescent(begin, end, accuracy);
                double resultMax = AntiCoordinateDescent(begin, end, accuracy);
                stopwatch.Stop();
                string minResult;
                string maxResult;
                if (resultMin < begin || resultMin > end)
                {
                    minResult = "Точки минимума нет на данном интервале!!";
                }
                else
                {
                    minResult = resultMin.ToString();
                }
                if (resultMax < begin || resultMax > end)
                {
                    maxResult = "Точки максимума нет на данном интервале";
                }
                else
                {
                    maxResult = resultMax.ToString();
                }
                double elapsedTimeInNanoseconds = stopwatch.Elapsed.TotalMilliseconds * 1000000;
                chartDichotomy_Click(sender, EventArgs);
                MessageBox.Show($"Точка минимума: {minResult}\n" + $"Точка максимума: {maxResult} \n Время выполнения: {elapsedTimeInNanoseconds} наносекунд");
            }
        
    }
}

