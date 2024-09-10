using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinjaJedi
{
    public class Character
    {
        private int health;
        private int strength;

        public string Faction { get; set; }

        public int Health
        {
            get { return health; }
            set
            {
                if (value < 0)
                {
                    health = 0;
                }
                else
                {
                    health = value;
                }
            }
        }

        public int Strength
        {
            get { return strength; }
            set
            {
                if (value < 0)
                {
                    strength = 0;
                }
                else
                {
                    strength = value;
                }
            }
        }

        public string SpecialSkill { get; set; }

        public Character(string faction, int health, int strength, string specialSkill)
        {
            Faction = faction;
            Health = health;
            Strength = strength;
            SpecialSkill = specialSkill;
        }

        public void DisplayCharacterInfo()
        {
            Console.WriteLine($"Faction: {Faction}");
            Console.WriteLine($"Health: {Health}");
            Console.WriteLine($"Strength: {Strength}");
            Console.WriteLine($"Special Skill: {SpecialSkill}");
        }

        public void UseSpecialSkill()
        {
            Console.WriteLine($"Using special skill: {SpecialSkill}");
        }
    }
}
