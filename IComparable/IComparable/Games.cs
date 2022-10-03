using System;

namespace IComparable
{
    public class Games : IComparable<Games>
    {
        public string Name { get; set; }
        public int NumberOfPlayers { get; set; }

        public override string ToString()
        {
            return $"Game: {Name} - Number of players: {NumberOfPlayers}";
        }

        public int CompareTo(Games? other)
        {
            if (!(other is Games))
                throw new ArgumentException("Argument not is type Games");

            Games otherGame = other as Games;
            return Name.CompareTo(otherGame.Name);
        }
    }
}
