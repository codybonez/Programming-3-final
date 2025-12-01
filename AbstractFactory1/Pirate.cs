using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory1
{
    public class Pirate : IEnemy
    {
        public void GetStatus(string name, string description, string weapon, int hp, string type)
        {
            Console.WriteLine("\nInsert name for the pirate\n");
            name = Console.ReadLine();

            Console.WriteLine("\nInsert description for the pirate\n");
            description = Console.ReadLine();

            Console.WriteLine("\nInsert weapon for the pirate\n");
            weapon = Console.ReadLine();

            Console.WriteLine("\nInsert health points the pirate\n");
            hp = Int32.Parse(Console.ReadLine());

            Console.WriteLine("\nInsert Type of  pirate\n");
            type = Console.ReadLine();



            Console.WriteLine($"\nPress any button to view the stats of the pirate\n");

            Console.ReadKey();



            Console.WriteLine($"\nPirates name: {name}");
            Console.WriteLine($"\nPirates description: {description}");
            Console.WriteLine($"\nPirates weapon: {weapon}");
            Console.WriteLine($"\nPirates health points: {hp}");
            Console.WriteLine($"\nPirates type: {type}"); ;



        }
    }
}
