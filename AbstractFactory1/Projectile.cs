using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory1
{
    internal class Projectile : AttackState
    {
        public void Attack()
        {
            Console.WriteLine("Projectile attack goes for 40 damage");
        }
    }
}
