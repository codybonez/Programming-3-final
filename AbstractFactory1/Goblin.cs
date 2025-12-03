using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory1
{
    public class Goblin : IEnemy
    {
        public void GetStatus(string name, string description, string weapon, int hp, string type)
        {
            
        
            LightAttack light = new LightAttack();
            Console.WriteLine("\nInsert name for the Goblin\n");
            name = Console.ReadLine();

            Console.WriteLine("\nInsert description for the Goblin\n");
            description = Console.ReadLine();

            Console.WriteLine("\nInsert weapon for the Goblin\n");
            weapon = Console.ReadLine();

            Console.WriteLine("\nInsert health points for Goblin\n");
            hp = Int32.Parse(Console.ReadLine());

            Console.WriteLine("\nInsert Type of  Goblin\n");
            type = Console.ReadLine();



            Console.WriteLine($"\nPress any button to view the stats of Goblin\n");

            Console.ReadKey();



            light.Attack();
            Console.WriteLine($"\nGoblins name: {name}");
            Console.WriteLine($"\nGoblins description: {description}");
            Console.WriteLine($"\nGoblins weapon: {weapon}");
            Console.WriteLine($"\nGoblins health points: {hp}");
            Console.WriteLine($"\nGoblins type: {type}");



        
    }
    }
}
