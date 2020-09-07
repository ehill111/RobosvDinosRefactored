using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaursRefactored
{
    public class Dinosaur
    {   //Member variables have/has a/an...
        public string type;
        public int health;
        public int energy;
        public int attackPower;
        //Constructor makes mold.
        public Dinosaur(string type)
        {

            this.type = type;
            health = 100;
            energy = 100;
            Random attackPowerRng = new Random();
            attackPower = attackPowerRng.Next(50, 101);
            //type comes later
        }
        public void AttackRobot(Robot AttackedRobot)
        {
            AttackedRobot.health -= attackPower
        }

    }

        //Methods do something.

}
