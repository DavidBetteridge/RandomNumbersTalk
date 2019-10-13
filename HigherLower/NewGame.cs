using System;
using System.Windows.Forms;

namespace HigherLower
{
    public partial class NewGame : Form
    {
        private int _currentSeed;

        public int Seed { get; private set; }

        public NewGame(int currentSeed)
        {
            InitializeComponent();
            _currentSeed = currentSeed;
        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Application.Exit();
        }

        private void cmdReplay_Click(object sender, EventArgs e)
        {
            Seed = _currentSeed;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void cmdNewGame_Click(object sender, EventArgs e)
        {
            Seed = Environment.TickCount;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
