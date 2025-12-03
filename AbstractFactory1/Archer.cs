using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory1
{
    public class Archer : IPlayer
    {
        public void GetStatus(string name, string description, string weapon, int hp, string type)
        {


            Projectile projectile = new Projectile();
            Console.WriteLine("\nInsert name for the Archer\n");
            name = Console.ReadLine();

            Console.WriteLine("\nInsert description for the Archer\n");
            description = Console.ReadLine();

            Console.WriteLine("\nInsert weapon for the Archer\n");
            weapon = Console.ReadLine();

            Console.WriteLine("\nInsert health points for Archer\n");
            hp = Int32.Parse(Console.ReadLine());

            Console.WriteLine("\nInsert Type of  Archer\n");
            type = Console.ReadLine();



            Console.WriteLine($"\nPress any button to view the stats of Archer\n");

            Console.ReadKey();



            projectile.Attack();
            Console.WriteLine($"\nArchers name: {name}");
            Console.WriteLine($"\nArchers description: {description}");
            Console.WriteLine($"\nArchers weapon: {weapon}");
            Console.WriteLine($"\nArchers health points: {hp}");
            Console.WriteLine($"\nArchers type: {type}");



        
    }
      
    }
}
