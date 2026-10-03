using System;
using System.Collections.Generic;
using System.Text;

namespace _4
{
    internal class Contain : GameCharacter
    {
        public string ContainAbility { get; set; }
        public string KiteZone { get; set; }
        public override void Attack()
        {
            Console.WriteLine($"{Name} used {ContainAbility}!");
        }

        public override void Defend()
        {
            Console.WriteLine($"{Name} used {KiteZone} to make distance!");
        }

        public override string? ToString()
        {
            return base.ToString();
        }
    }
}
