using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory1
{
    public class Dragon : IEnemy
    {
        public void GetStatus(string name, string description, string weapon, int hp, string type)
        {


            Projectile projectile = new Projectile();
            Console.WriteLine("\nInsert name for the Dragon\n");
            name = Console.ReadLine();

            Console.WriteLine("\nInsert description for the Dragon\n");
            description = Console.ReadLine();

            Console.WriteLine("\nInsert weapon for the Dragon\n");
            weapon = Console.ReadLine();

            Console.WriteLine("\nInsert health points for Dragon\n");
            hp = Int32.Parse(Console.ReadLine());

            Console.WriteLine("\nInsert Type of  Dragon\n");
            type = Console.ReadLine();



            Console.WriteLine($"\nPress any button to view the stats of Dragon\n");

            Console.ReadKey();



            projectile.Attack();
            Console.WriteLine($"Dragon deals additional damage when shooting fire");

            Console.WriteLine($"\nDragons name: {name}");
            Console.WriteLine($"\nDragons description: {description}");
            Console.WriteLine($"\nDragons weapon: {weapon}");
            Console.WriteLine($"\nDragons health points: {hp}");
            Console.WriteLine($"\nDragons type: {type}");



        }
    }
}
