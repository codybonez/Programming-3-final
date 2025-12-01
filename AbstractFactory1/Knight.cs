using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AbstractFactory1
{
    public   class Knight : IPlayer
    {
  
        public void GetStatus(string name, string description,string weapon, int hp, string type)
        {
            Console.WriteLine("\nInsert name for the knight\n");
            name = Console.ReadLine();

            Console.WriteLine("\nInsert description for the knight\n");
            description = Console.ReadLine();

            Console.WriteLine("\nInsert weapon for the knight\n");
            weapon = Console.ReadLine();

            Console.WriteLine("\nInsert health points for knight\n");
            hp = Int32.Parse(Console.ReadLine());

            Console.WriteLine("\nInsert Type of  knight\n");
            type = Console.ReadLine();



            Console.WriteLine($"\nPress any button to view the stats of knight\n");

            Console.ReadKey();




            Console.WriteLine($"\nKnights name: {name}");
            Console.WriteLine($"\nKnights description: {description}");
            Console.WriteLine($"\nKnight weapon: {weapon}");
            Console.WriteLine($"\nKnight health points: {hp}");
            Console.WriteLine($"\nKnight type: {type}");



        }
      
    }
}
