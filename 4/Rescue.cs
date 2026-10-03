using System;
using System.Collections.Generic;
using System.Text;

namespace _4
{
    internal class Rescue : GameCharacter
    {
        public string RescueAbility { get; set; }
        public string Helpafterrescue { get; set; }
        public override void Attack()
        {
            Console.WriteLine($"{Name} used {RescueAbility} to rescue teammate!");
        }

        public override void Defend()
        {
            Console.WriteLine($"{Name} helped the teammate after rescue with {Helpafterrescue}!");
        }

        public override string? ToString()
        {
            return base.ToString();
        }
    }
}
