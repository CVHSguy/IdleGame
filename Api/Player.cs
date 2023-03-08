using System.Numerics;

namespace Api
{
    public class Player
    {
        public int PlayerID { get; set; }

        public int Points { get; set; }

        public bool[] Achievements { get; set; } = new bool[36];

        public bool[] Unlocks { get; set; } = new bool[14];
    }
}