using System;
using System.Collections.Generic;
using System.Text;

namespace _4
{
    internal abstract class GameCharacter
    {
        public string Name { get; set; }
        public int Hp { get; set; }
        public int Lvl { get; set; }
        public abstract void Attack();
        public abstract void Defend();
        public void ShowInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Hp: {Hp}%");
            if (Lvl == 100)
            {
                Console.WriteLine($"Ability is unlimited");
            }
            else if (Lvl > 3)
            {
                Console.WriteLine($"Ability has usage scale");
            }
            else
            {
                Console.WriteLine($"The ability has {Lvl} uses");
            }
        }
    }
}
