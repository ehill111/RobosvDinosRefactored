using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaursRefactored
{
    class Battlefield
    {   //Member variables have/has a/an...
        public Fleet fleet;//Dot notation gives me direct access to everything pertaining to robots.
        public Herd herd;//Dont notation gives me direct access to everything pertaining to dinosaurs.

        //Constructor makes mold.
        public Battlefield()
        {
            fleet = new Fleet();
            herd = new Herd();
        }
        //Methods do something.
        public void StartBattle()
        {
            //robot attacks dino
            fleet.robots[0].AttackDinosaur(herd.dinosaurs[0]);
            //dino attacks robot
            herd.dinosaurs[0].AttackRobot(fleet.robots[0]);
        }
        








    }
}
