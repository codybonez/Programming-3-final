namespace AbstractFactory1
{
    internal class Program 
    {
        string name;
        static void Main(string[] args)
        {
    
            string menu;
            string Name = "";
            string Weapon = "";
            int HP = 0;
            string Description = "";
            string Type = "";
             




            do
            {
                Console.WriteLine("\n\nWelcome to the character selection system.\n1. Create Player\n2. Create Enemy \n3. exit");

                menu = Console.ReadLine();
                    switch (menu)
                    {
                        case "1":
                        // Input user of preset options such as Knight, 
                        Console.WriteLine("Select preset: Knight, Dwarf, Archer,  ");
                        string preset = Console.ReadLine();
                        if (preset.Equals("Knight", StringComparison.OrdinalIgnoreCase))
                        {
                            Knight knight = new Knight();
                            
                            knight.GetStatus(Name,Description,Weapon,HP,Type);
                            break;

                        }
                        else if (preset.Equals("Dwarf", StringComparison.OrdinalIgnoreCase))
                        {
                            // make instance of dwarf class, use get status 
                        }
                        else if (preset.Equals("Archer", StringComparison.OrdinalIgnoreCase))
                        {

                        }

                            break;

                        case "2":
                        Console.WriteLine("Select preset: Pirate, Goblin, Slime, Dragon");
                         preset = Console.ReadLine();
                        if (preset.Equals("Pirate", StringComparison.OrdinalIgnoreCase))
                        {
                            Pirate pirate = new Pirate();

                            pirate.GetStatus(Name, Description,Weapon, HP, Type);
                            break;

                        }
                        else if (preset.Equals("Goblin", StringComparison.OrdinalIgnoreCase))
                        {

                        }
                        else if (preset.Equals("Slime", StringComparison.OrdinalIgnoreCase))
                        {


                        }
                        else if (preset.Equals("Dragon", StringComparison.OrdinalIgnoreCase))
                        {

                        }
                        

                            break;

                        case "3":
                        Console.WriteLine("Exiting app.");
                          
                            break;
                   

                        default:


                            Console.WriteLine("Doesn't exist, please try again.");
                     

                            break;
                    }

                
            } while (menu != "3");
        }
       
      
    }
}
