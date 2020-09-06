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
        public Weapon weapon;
        public int attackPower;
        public List<Weapon> type;
        
        //Constructor makes mold.
        public Robot(string name, string weaponType)
        {
            //Random rnd = new Random();
            //{ "Club", "Axe", "Sword" };

            //Weapon weapon = new Weapon(weaponType);
            List<Weapon> weapons = new List<Weapon>();
            Weapon weapon1 = new Weapon("Club");
            Weapon weapon2 = new Weapon("Axe");
            Weapon weapon3 = new Weapon("Sword");
            weapons.Add(weapon1);
            weapons.Add(weapon2);
            weapons.Add(weapon3);

            this.name = name;
            health = 100;
            powerLevel = 100;
             
            Random attackPowerRng = new Random();
            attackPower = attackPowerRng.Next(50, 101);
             
            
            
           

        }
    }
}
