using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory1
{
    public class HeavyAttack : AttackState
    {

      
        // Possible state pattern: What type of attack 
        // Heavy, Light, Projectile

        public void Attack()
        {
            Console.WriteLine("Heavy attack deals 80 damage");
        }



    }
}
