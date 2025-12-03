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
             


            // TODO: create attack state for enemy and player

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
                            Dwarf dwarf = new Dwarf();
                            dwarf.GetStatus(Name,Description,Weapon,HP, Type);
                            break;
                        }
                        else if (preset.Equals("Archer", StringComparison.OrdinalIgnoreCase))
                        {
                            Archer archer = new Archer();
                            archer.GetStatus(Name,Description,Weapon,HP,Type);
                            break;
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
                            Goblin goblin = new Goblin();
                            goblin.GetStatus(Name, Description,Weapon,HP,Type);
                            break;
                        }
                        else if (preset.Equals("Slime", StringComparison.OrdinalIgnoreCase))
                        {
                            Slime slime = new Slime();
                            slime.GetStatus(Name, Description,Weapon,HP,Type);
                            break;

                        }
                        else if (preset.Equals("Dragon", StringComparison.OrdinalIgnoreCase))
                        {
                            Dragon dragon = new Dragon();
                            dragon.GetStatus(Name, Description, Weapon, HP, Type);
                            break;
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
