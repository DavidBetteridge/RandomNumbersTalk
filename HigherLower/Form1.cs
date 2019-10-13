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
            NewGame(Environment.TickCount);

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

            DisplayCards();
        }


        private void PlayAgain()
        {
            var frm = new NewGame();
            frm.ShowDialog();

            switch (frm.Result)
            {
                case NewGameResult.NewGame:
                    NewGame(Environment.TickCount);
                    break;
                case NewGameResult.Replay:
                    NewGame(_seed);
                    break;
                default:
                    Application.Exit();
                    break;
            }
        }

        private void NewGame(int seed)
        {
            _pack = new Pack();
            var rnd = new Random(seed);
            for (int i = 0; i < 100; i++)
            {
                _pack.Shuffle(rnd);
            }

            _seed = seed;
            Text = $"Higher or Lower (Seed: {seed})";

            _score = 0;
            lblScore.Text = _score.ToString();

            _currentCardIndex = 0;
            DisplayCards();
        }

        private void DisplayCards()
        {
            pbBack.Visible = _currentCardIndex < 49;
            pbBack3.Visible = _currentCardIndex < 50;
            pbBack2.Visible = _currentCardIndex < 51;

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

            if (_currentCardIndex >= 52)
            {
                MessageBox.Show("You won - well done");
                return;
            }

            DisplayCards();

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
