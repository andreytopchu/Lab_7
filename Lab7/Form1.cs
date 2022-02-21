using System;
using System.Windows.Forms;

namespace Lab7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double Func(double x)
        {
            return 3 * Math.Pow(x, 2) + 1 / x;
        }

        private double Answer()
        {
            return 7 + Math.Log(2);
        }

        private double SympsonMetod(double a, double b, int n)
        {
            var h = (b - a) / n;
            var x = a;
            var result = h / 3 * (Func(a) + Func(b));

            for (var i = 1; i < n; i++)
            {
                x += h;
                if (i % 2 == 0)
                {
                    result += h / 3 * 2 * Func(x);
                }
                else
                {
                    result += h / 3 * 4 * Func(x);
                }
            }

            return result;
        }

        private double RectangleMetod(double a, double b, int n)
        {
            var h = (b - a) / n;
            var x = a;
            double result = 0;

            for (var i = 0; i < n; i++)
            {
                var func = Math.Round(Func(x + h / 2), 4);
                result += func;
                x += h;
            }

            return result * h;
        }

        private double TrapezoidMetod(double a, double b, int n)
        {
            var h = (b - a) / n;
            var x = a;
            var result = h * (Func(a) + Func(b)) / 2;

            for (var i = 1; i < n; i++)
            {
                x += h;
                result += Math.Round(Func(x), 4) * h;
            }

            return result;
        }

        private void buildGraphButton_Click(object sender, EventArgs e)
        {
            if (aBoundValue.Text == string.Empty)
            {
                aBoundValue.Text = "1";
            }

            if (bBoundValue.Text == string.Empty)
            {
                bBoundValue.Text = "2";
            }

            graph.Series[0].Points.Clear();

            double x, y;
            var b = double.NaN;

            if (!double.TryParse(aBoundValue.Text, out x) ||
                !double.TryParse(bBoundValue.Text, out b))
            {
                Error();
                return;
            }
            var eps = 0.01;
            x = Convert.ToDouble(aBoundValue.Text);
            b = Convert.ToDouble(bBoundValue.Text);

            while (x <= b)
            {
                y = Func(x);
                graph.Series[0].Points.AddXY(x, y);

                x += eps;
            }
        }

        private void findRootsButton_Click(object sender, EventArgs e)
        {
            if (aBoundValue.Text == string.Empty)
            {
                aBoundValue.Text = "1";
            }

            if (bBoundValue.Text == string.Empty)
            {
                bBoundValue.Text = "2";
            }

            if (nValue.Text == string.Empty)
            {
                nValue.Text = "10";
            }
            
            double a, b ;
            int n;

            if (!double.TryParse(aBoundValue.Text, out a) ||
                !double.TryParse(bBoundValue.Text, out b) ||
                !int.TryParse(nValue.Text, out n))
            {
                Error();
                return;
            }

            a = Convert.ToDouble(aBoundValue.Text);
            b = Convert.ToDouble(bBoundValue.Text);
            n = Convert.ToInt16(nValue.Text);

            roots.Rows.Clear();

            roots.Rows.Add();
            roots[0,0].Value = Math.Round(Answer(), 10);
            roots[1, 0].Value = Math.Round(RectangleMetod(a, b, n), 10);
            roots[2, 0].Value = Math.Round(TrapezoidMetod(a, b, n), 10);

            if (n % 2 == 0)
            {
                roots[3, 0].Value = Math.Round(SympsonMetod(a, b, n), 10);
            }
            else
            {
                roots[3, 0].Value = "Заданное число шагов нечетное! Невозможно решить данным методом";
            }
        }

        private void aBoundValue_TextChanged(object sender, EventArgs e)
        {
            aBoundValue.Text = aBoundValue.Text.Replace('.', ',');
            aBoundValue.SelectionStart = aBoundValue.TextLength;
        }

        private void bBoundValue_TextChanged(object sender, EventArgs e)
        {
            bBoundValue.Text = bBoundValue.Text.Replace('.', ',');
            bBoundValue.SelectionStart = bBoundValue.TextLength;
        }


        private void nValue_TextChanged(object sender, EventArgs e)
        {
            nValue.Text = nValue.Text.Replace('.', ',');
            nValue.SelectionStart = nValue.TextLength;
        }
        
        private void Error()
        {
            MessageBox.Show("Одно из полей содержит некорректные данные.", "Ошибка ввода", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
    }
}
