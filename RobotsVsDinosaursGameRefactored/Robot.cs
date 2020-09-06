using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaursRefactored
{
    class Robot
    {   //Member variables have/has a/an...
        public string name;
        public int health;
        public int powerLevel;
        public Weapon type;
        public int attackPower;
        
        //Constructor makes mold.
        public Robot()
        {
            Robot robot = new Robot();
            health = 10;
            powerLevel = 10;
            attackPower = 10;
            //Weapon type will be assigned later.

        }
    }
}
