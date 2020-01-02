using System;
using System.Drawing;
using System.Windows.Forms;

namespace Welcome
{
    public partial class Form1 : Form
    {
        private string _allNumbers;
        private int _offset;
        private Random _rnd = new Random();
        private Label lblName;

        public Form1()
        {
            InitializeComponent();

            lblName = new Label
            {
                AutoSize = true,
                Font = new System.Drawing.Font("Segoe UI", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                ForeColor = System.Drawing.Color.Blue,
                Location = new System.Drawing.Point(282, 182),
                Name = "lblTitle",
                Size = new System.Drawing.Size(1071, 128),
                TabIndex = 0,
                Text = "By David Betteridge"
            };
            Controls.Add(lblName);

            _allNumbers = System.IO.File.ReadAllText("Data.txt");
            _offset = 0;
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            lblTitle.Left = (this.ClientSize.Width - lblTitle.Width) / 2;
            lblName.Top = lblTitle.Top + lblTitle.Height;
            lblName.Left = (this.ClientSize.Width - lblName.Width) / 2;
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //var _rnd = new Random();
            var digit = _allNumbers[_offset];
            if (char.IsDigit(digit))
            {
                var x = _rnd.Next(0, ClientSize.Width - 1);
                var y = _rnd.Next(0, ClientSize.Height - 1);

                var label = new Label
                {
                    Font = this.Font,
                    ForeColor = Color.Red,
                    Text = digit.ToString(),
                    AutoSize = true,
                    Location = new Point(x, y),
                };
                this.Controls.Add(label);
            }

            _offset++;
            if (_offset >= _allNumbers.Length)
                _offset = 0;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
