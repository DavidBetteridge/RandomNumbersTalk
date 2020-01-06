using System;
using System.Numerics;
using System.Windows.Forms;

namespace MiddleSquareWeylSequence
{
    public partial class Form1 : Form
    {
        UInt64 x;
        UInt64 w;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UInt64 s = 0xb5ad4eceda1ce2a9;
            x = 0xace983fe671dbd09;

            x = BigInt_to_Ulong(BigInteger.Pow(x, 2));

            w += s; // the weyl sequence
            x += BigInt_to_Ulong(BigInteger.Add(new BigInteger(x), new BigInteger(w))); // apply to x
            x = (x >> 32) | (x << 32); // return the middle 32-bits

        }

        private ulong BigInt_to_Ulong(BigInteger bigInteger)
        {
            var mask = BigInteger.Pow(2, 64) - 1;
            var x = (bigInteger & mask);
            return (ulong)x;
        }
    }
}
