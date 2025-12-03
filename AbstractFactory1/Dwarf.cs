using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory1
{
    public class Dwarf : IPlayer
    {
        public void GetStatus(string name, string description, string weapon, int hp, string type)
        {
            HeavyAttack attack = new HeavyAttack();
            Console.WriteLine("\nInsert name for the Dwarf\n");
            name = Console.ReadLine();

            Console.WriteLine("\nInsert description for the Dwarf\n");
            description = Console.ReadLine();

            Console.WriteLine("\nInsert weapon for the Dwarf\n");
            weapon = Console.ReadLine();

            Console.WriteLine("\nInsert health points for Dwarf\n");
            hp = Int32.Parse(Console.ReadLine());

            Console.WriteLine("\nInsert Type of  Dwarf\n");
            type = Console.ReadLine();



            Console.WriteLine($"\nPress any button to view the stats of Dwarf\n");

            Console.ReadKey();



            attack.Attack();
            Console.WriteLine($"\nDwarf name: {name}");
            Console.WriteLine($"\nDwarf description: {description}");
            Console.WriteLine($"\nDwarf weapon: {weapon}");
            Console.WriteLine($"\nDwarf health points: {hp}");
            Console.WriteLine($"\nDwarf type: {type}");



        }



    }
}
