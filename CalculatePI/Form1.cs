using System;
using System.Drawing;
using System.Windows.Forms;

namespace CalculatePI
{
    public partial class Form1 : Form
    {
        private Timer timer = new Timer();
        private int _inside = 0;
        private int _outside = 0;

        public Form1()
        {
            InitializeComponent();

            pictureBox1.Height = pictureBox1.Width;

            timer.Interval = 10;
            timer.Tick += Timer_Tick;
        }



        private void cmdStart_Click(object sender, EventArgs e)
        {
            var rnd = new Random();

            var inside = 0.0;
            var outside = 0.0;
            for (int i = 0; i < 10000000; i++)
            {
                var x = rnd.NextDouble();
                var y = rnd.NextDouble();

                var dist = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
                if (dist > 1)
                    outside++;
                else
                    inside++;
            }

            var ratio = (inside / 10000000) * 4;

            lblInside.Text = inside.ToString();
            lblOutside.Text = outside.ToString();
            lblRatio.Text = ratio.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer.Enabled = true;
            using (var g = pictureBox1.CreateGraphics())
            {
                g.DrawEllipse(Pens.Red, 0, 0, pictureBox1.Width, pictureBox1.Height);
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            var rnd = new Random();
            using (var g = pictureBox1.CreateGraphics())
            {
                g.TranslateTransform(pictureBox1.Width / 2, pictureBox1.Height / 2);

                var x = rnd.NextDouble();
                var y = rnd.NextDouble();
                var xSign = rnd.Next(0, 2) == 0 ? 1 : -1;
                var ySign = rnd.Next(0, 2) == 0 ? 1 : -1;

                var r = pictureBox1.Width / 2;
                var drawX = (int)(x * r) * xSign;
                var drawY = (int)(y * r) * ySign;

                var dist = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
                if (dist > 1)
                {
                    g.FillEllipse(Brushes.Blue, drawX-5, drawY - 5, 10, 10);
                    _outside++;
                }
                else
                {
                    g.FillEllipse(Brushes.Yellow, drawX - 5, drawY - 5, 10, 10);
                    _inside++;
                }
                lblInside.Text = _inside.ToString();
                lblOutside.Text = _outside.ToString();

                var ratio = (_inside / (double)(_inside + _outside)) * 4;
                lblRatio.Text = ratio.ToString();
            }
        }
    }
}
