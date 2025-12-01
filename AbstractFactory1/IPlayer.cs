using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory1
{
    public interface IPlayer 
    {

        public void GetStatus(string name, string description, string weapon, int hp, string type);
      
    }
}
