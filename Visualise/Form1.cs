using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Visualise
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var rnd = new Random();

            using (var g = panel1.CreateGraphics())
            {
                panel1.SuspendLayout();

                for (int y = 0; y < panel1.Height; y++)
                {
                    for (int x = 0; x < panel1.Width; x++)
                    {
                        if (rnd.NextDouble() < 0.5)
                            g.DrawRectangle(Pens.Red, x, y, 1, 1);
                    }
                }

                panel1.ResumeLayout();
            }
        }

    
    }
}
