using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory1
{
    public class Slime : IEnemy
    {
        public void GetStatus(string name, string description, string weapon, int hp, string type)
        {


            Projectile projectile = new Projectile();
            Console.WriteLine("\nInsert name for the Slime\n");
            name = Console.ReadLine();

            Console.WriteLine("\nInsert description for the Slime\n");
            description = Console.ReadLine();

            Console.WriteLine("\nInsert weapon for the Slime\n");
            weapon = Console.ReadLine();

            Console.WriteLine("\nInsert health points for Slime\n");
            hp = Int32.Parse(Console.ReadLine());

            Console.WriteLine("\nInsert Type of  Slime\n");
            type = Console.ReadLine();



            Console.WriteLine($"\nPress any button to view the stats of Slime\n");

            Console.ReadKey();



            projectile.Attack();
        
        
            Console.WriteLine($"\nSlimes name: {name}");
            Console.WriteLine($"\nSlimes description: {description}");
            Console.WriteLine($"\nSlimes weapon: {weapon}");
            Console.WriteLine($"\nSlimes health points: {hp}");
            Console.WriteLine($"\nSlimes type: {type}");
        }

    }
}
