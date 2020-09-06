using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaursRefactored
{
    class Dinosaur
    {   //Member variables have/has a/an...
        public string type;
        public int health;
        public int energy;
        public int attackPower;
        //Constructor makes mold.
        public Dinosaur(string name)
        {
            health = 100;
            energy = 100;
            attackPower = 100;
            //type comes later
            
        }


    }

        //Methods do something.

}
