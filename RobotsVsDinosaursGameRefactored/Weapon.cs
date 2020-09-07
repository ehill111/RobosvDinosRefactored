using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaursRefactored
{
    public class Weapon
    {   //Member variables have/has a/an...
        public string type;
        public int attackPower;

                
        //Constructor makes mold.
        public Weapon(string type)
        {
            this.type = type;
            Random rng = new Random();
            attackPower = rng.Next(50, 101);
        }


        //Methods do something.
    }
}
