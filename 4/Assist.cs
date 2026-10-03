using System;
using System.Collections.Generic;
using System.Text;

namespace _4
{
    internal class Assist : GameCharacter
    {
        public string StunAbility { get; set; }
        public string SupportAbility { get; set; }
        public override void Attack()
        {
            Console.WriteLine($"{Name} made balloonrescue with a {StunAbility}!");
        }

        public override void Defend()
        {
            Console.WriteLine($"{Name} used {SupportAbility} to support teammate!");
        }

        public override string? ToString()
        {
            return base.ToString();
        }
    }
}
