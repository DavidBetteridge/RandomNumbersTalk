using System.Globalization;

namespace PackOfCards
{
    public readonly struct Card : System.IEquatable<Card>
    {
        public Card(Suit suit, int value)
        {
            Suit = suit;
            Value = value;
        }

        public Suit Suit { get; }
        public int Value { get; }

        public override string ToString()
        {
            var value = Value switch
            {
                1 => "Ace",
                11 => "Jack",
                12 => "Queen",
                13 => "King",
                _ => Value.ToString(CultureInfo.InvariantCulture)
            };

            return $"{value} of {Suit}s";
        }

        public string ToUnicode() =>
            Value switch
            {
                1 when Suit == Suit.Spade => "\U0001F0A1",
                2 when Suit == Suit.Spade => "\U0001F0A2",
                3 when Suit == Suit.Spade => "\U0001F0A3",
                4 when Suit == Suit.Spade => "\U0001F0A4",
                5 when Suit == Suit.Spade => "\U0001F0A5",
                6 when Suit == Suit.Spade => "\U0001F0A6",
                7 when Suit == Suit.Spade => "\U0001F0A7",
                8 when Suit == Suit.Spade => "\U0001F0A8",
                9 when Suit == Suit.Spade => "\U0001F0A9",
                10 when Suit == Suit.Spade => "\U0001F0AA",
                11 when Suit == Suit.Spade => "\U0001F0AB",
                12 when Suit == Suit.Spade => "\U0001F0AD",
                13 when Suit == Suit.Spade => "\U0001F0AE",
                1 when Suit == Suit.Heart => "\U0001F0B1",
                2 when Suit == Suit.Heart => "\U0001F0B2",
                3 when Suit == Suit.Heart => "\U0001F0B3",
                4 when Suit == Suit.Heart => "\U0001F0B4",
                5 when Suit == Suit.Heart => "\U0001F0B5",
                6 when Suit == Suit.Heart => "\U0001F0B6",
                7 when Suit == Suit.Heart => "\U0001F0B7",
                8 when Suit == Suit.Heart => "\U0001F0B8",
                9 when Suit == Suit.Heart => "\U0001F0B9",
                10 when Suit == Suit.Heart => "\U0001F0BA",
                11 when Suit == Suit.Heart => "\U0001F0BB",
                12 when Suit == Suit.Heart => "\U0001F0BD",
                13 when Suit == Suit.Heart => "\U0001F0BE",
                1 when Suit == Suit.Diamond => "\U0001F0C1",
                2 when Suit == Suit.Diamond => "\U0001F0C2",
                3 when Suit == Suit.Diamond => "\U0001F0C3",
                4 when Suit == Suit.Diamond => "\U0001F0C4",
                5 when Suit == Suit.Diamond => "\U0001F0C5",
                6 when Suit == Suit.Diamond => "\U0001F0C6",
                7 when Suit == Suit.Diamond => "\U0001F0C7",
                8 when Suit == Suit.Diamond => "\U0001F0C8",
                9 when Suit == Suit.Diamond => "\U0001F0C9",
                10 when Suit == Suit.Diamond => "\U0001F0CA",
                11 when Suit == Suit.Diamond => "\U0001F0CB",
                12 when Suit == Suit.Diamond => "\U0001F0CD",
                13 when Suit == Suit.Diamond => "\U0001F0CE",
                1 when Suit == Suit.Club => "\U0001F0D1",
                2 when Suit == Suit.Club => "\U0001F0D2",
                3 when Suit == Suit.Club => "\U0001F0D3",
                4 when Suit == Suit.Club => "\U0001F0D4",
                5 when Suit == Suit.Club => "\U0001F0D5",
                6 when Suit == Suit.Club => "\U0001F0D6",
                7 when Suit == Suit.Club => "\U0001F0D7",
                8 when Suit == Suit.Club => "\U0001F0D8",
                9 when Suit == Suit.Club => "\U0001F0D9",
                10 when Suit == Suit.Club => "\U0001F0DA",
                11 when Suit == Suit.Club => "\U0001F0DB",
                12 when Suit == Suit.Club => "\U0001F0DD",
                13 when Suit == Suit.Club => "\U0001F0DE",
                _ => " "
            };

        public override bool Equals(object? obj) => (obj is Card otherCard) && otherCard.Equals(this);

        public override int GetHashCode() => this.Value.GetHashCode();

        public static bool operator ==(Card left, Card right)=> left.Equals(right);

        public static bool operator !=(Card left, Card right) => !(left == right);

        public bool Equals(Card other) => (other.Suit == Suit && other.Value == Value);
    }
}
