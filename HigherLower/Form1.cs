using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PackOfCards;

namespace HigherLower
{
    public partial class Form1 : Form
    {
        private Pack _pack;
        private int _currentCardIndex;
        private int _score;
        private int _seed;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _seed = Environment.TickCount;

            StartGame();

            BackColor = Color.FromArgb(7, 99, 36);

            pbBack.Load("cards/back.png");
            pbBack.SizeMode = PictureBoxSizeMode.AutoSize;
            pbBack.BackColor = Color.White;
            pbBack.BorderStyle = BorderStyle.FixedSingle;

            pbBack2.Load("cards/back.png");
            pbBack2.SizeMode = PictureBoxSizeMode.AutoSize;
            pbBack2.BackColor = Color.White;
            pbBack2.BorderStyle = BorderStyle.FixedSingle;

            pbBack3.Load("cards/back.png");
            pbBack3.SizeMode = PictureBoxSizeMode.AutoSize;
            pbBack3.BackColor = Color.White;
            pbBack3.BorderStyle = BorderStyle.FixedSingle;

            DisplayCard();
        }


        private void PlayAgain()
        {
            var frm = new NewGame(_seed);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                _seed = frm.Seed;
                StartGame();
            }
        }

        private void StartGame()
        {
            Text = $"Higher or Lower (Seed: {_seed})";

            _pack = new Pack();
            _currentCardIndex = 0;
            _score = 0;
            lblScore.Text = _score.ToString();

            var rnd = new Random(_seed);
            for (int i = 0; i < 100; i++)
            {
                _pack.Shuffle(rnd);
            }

            DisplayCard();
        }

        private void DisplayCard()
        {
            if (_currentCardIndex > 0)
            {
                var previousCard = _pack.GetCard(_currentCardIndex - 1);
                pbPreviousCard.Load(previousCard.Filename());
                pbPreviousCard.SizeMode = PictureBoxSizeMode.AutoSize;
                pbPreviousCard.BackColor = Color.White;
                pbPreviousCard.BorderStyle = BorderStyle.FixedSingle;
                pbPreviousCard.Visible = true;
            }
            else
            {
                pbPreviousCard.Visible = false;
            }

            var card = _pack.GetCard(_currentCardIndex);
            pbNextCard.Load(card.Filename());
            pbNextCard.SizeMode = PictureBoxSizeMode.AutoSize;
            pbNextCard.BackColor = Color.White;
            pbNextCard.BorderStyle = BorderStyle.FixedSingle;
        }

        private void cmdHigher_Click(object sender, EventArgs e)
        {
            CompareCards((newCard, previousCard) => newCard.Value > previousCard.Value);
        }

        private void cmdLower_Click(object sender, EventArgs e)
        {
            CompareCards((newCard, previousCard) => newCard.Value < previousCard.Value);
        }

        private void cmdSame_Click(object sender, EventArgs e)
        {
            CompareCards((newCard, previousCard) => newCard.Value == previousCard.Value);
        }

        private void CompareCards(Func<Card, Card, bool> guess)
        {
            _currentCardIndex++;
            DisplayCard();

            var previousCard = _pack.GetCard(_currentCardIndex - 1);
            var newCard = _pack.GetCard(_currentCardIndex);

            if (guess(newCard, previousCard))
            {
                _score++;
                lblScore.Text = _score.ToString();
            }
            else
            {
                PlayAgain();
            }
        }
    }
}
