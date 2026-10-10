using System;
using System.Collections.Generic;
using System.Text;

namespace _6
{
    internal class Participant : IComparable<Participant>
    {
        public string Name { get; set; }
        public int Score { get; set; }

        public int CompareTo(Participant? other)
        {
            return Score.CompareTo(other.Score);
        }
    }
}
