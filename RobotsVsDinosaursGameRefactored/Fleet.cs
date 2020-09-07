using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaursRefactored
{
    class Fleet
    {   //Member variables have/has a/an...
        public List<Robot> robots;

        //Constructor makes mold.
        public Fleet()
        {
            List<Robot> robots = new List<Robot>();//Instantiated list.
            Robot robot1 = new Robot("Magnum", "Axe");//Instantiated robots for the list.
            Robot robot2 = new Robot("Valiant", "Club");//Passed in mandatory string values.
            Robot robot3 = new Robot("Formidable", "Sword");
            robots.Add(robot1);//Add allowed use of dot notation to pass in values.
            robots.Add(robot2);
            robots.Add(robot3);
            
            


        }

      
                
                
    }
}
