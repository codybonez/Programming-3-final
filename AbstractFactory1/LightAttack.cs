using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory1
{
    public abstract class LightAttack : AttackState
    {
      

        public void Attack()
        {
            Console.WriteLine("Light attack deals 50 damage");
        }
    }
}
