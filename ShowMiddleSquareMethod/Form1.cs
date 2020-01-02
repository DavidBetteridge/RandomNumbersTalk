using System;
using System.Drawing;
using System.Windows.Forms;

namespace ShowMiddleSquareMethod
{
    public partial class Form1 : Form
    {
        private long _seed = int.MinValue;
        private int _n = int.MinValue;
        private int _y = 150;

        public Form1()
        {
            InitializeComponent();
            txtStartingValue.Text = "42";
        }

        private void cmdNext_Click(object sender, EventArgs e)
        {
            if (_seed == int.MinValue)
            {
                _seed = long.Parse(txtStartingValue.Text);
                _n = txtStartingValue.Text.Length;
                txtStartingValue.Enabled = false;
            }

            using (var g = this.CreateGraphics())
            {
                var x = 100;
                x += AddText(g, $"{_seed}", x, _y, Brushes.Black);
                x += AddText(g, $"2", x, _y - 10, Brushes.Black);
                x += AddText(g, $" = ", x, _y, Brushes.Black);

                var squared = (_seed * _seed);
                x += AddText(g, $"{squared}", x, _y, Brushes.Black);

                x += AddText(g, $" = ", x, _y, Brushes.Black);

                var leadingZeros = "".PadLeft(_n * 2 - squared.ToString().Length, '0');
                var padded = $"{leadingZeros}{squared}";
                x += AddText(g, $"{leadingZeros}", x, _y, Brushes.Green);
                x += AddText(g, $"{squared}", x, _y, Brushes.Black);

                x += AddText(g, $" = ", x, _y, Brushes.Black);


                var left = padded.Substring(0, _n / 2);
                var middle = padded.Substring(_n / 2, _n);
                var right = padded.Substring((_n / 2) + _n);
                x += AddText(g, $"{left}", x, _y, Brushes.Black);
                x += AddText(g, $"{middle}", x, _y, Brushes.Green);
                x += AddText(g, $"{right}", x, _y, Brushes.Black);

                x += AddText(g, $" => ", x, _y, Brushes.Black);

                x += AddText(g, middle, x, _y, Brushes.Black);


                _y += 50;
            }


            _seed = Next(_n, _seed);
        }

        private int AddText(Graphics g, string text, int x, int y, Brush brush)
        {
            g.DrawString(text, this.Font, brush, new Point(x, y));
            var space = g.MeasureString(text, this.Font, new Point(x, y), new StringFormat(StringFormatFlags.MeasureTrailingSpaces));
            return (int)space.Width - 10;
        }

        private static long Next(int n, long seed)
        {
            var squared = (seed * seed);
            var padded = squared.ToString().PadLeft(n * 2, '0');
            var middle = padded.Substring(n / 2, n);

            return long.Parse(middle);
        }
    }
}
