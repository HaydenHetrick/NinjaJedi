using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinjaJedi
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Choose your faction (jedi/Ninja): ");
            string faction = Console.ReadLine();

            Console.WriteLine("Enter your health: ");
            int health = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your strength: ");
            int strength = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your special skill: ");
            string specialSkill = Console.ReadLine();

            Character playerCharacter = new Character(faction, health, strength, specialSkill);

            Console.WriteLine("\nCharacter Created Successfully!\n");
            playerCharacter.DisplayCharacterInfo();

            Console.WriteLine("\nDo you want to use your special skill? (yes/no): ");
            string useSpecialSkill = Console.ReadLine();

            if (useSpecialSkill != null)
            {
                playerCharacter.UseSpecialSkill();
            }

            Console.ReadKey();
        }
    }
}
