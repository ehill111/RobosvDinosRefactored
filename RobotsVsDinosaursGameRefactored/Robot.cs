using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaursRefactored
{
    public class Robot
    {   //Member variables have/has a/an...
        public string name;
        public int health;
        public int powerLevel;
        public Weapon weapon;
        public int attackPower;
        //public List<Weapon> weapon;
        
        //Constructor makes mold.
        public Robot(string name, string weaponType)
        {
            this.name = name;
            //this.weapon = weapon;
            health = 100;
            powerLevel = 100;
            Random attackPowerRng = new Random();
            attackPower = attackPowerRng.Next(50, 101);
            weapon = new Weapon(weaponType);
            //Weapon weapon = new Weapon();
            //List<Weapon> weapons = new List<Weapon>();
            //Weapon weapon1 = new Weapon("Club");
            //Weapon weapon2 = new Weapon("Axe");
            //Weapon weapon3 = new Weapon("Sword");
            //weapons.Add(weapon1);
            //weapons.Add(weapon2);
            //weapons.Add(weapon3);
            //this.weapon = weapon;   

        }
        public void AttackDinosaur(Dinosaur attackedDinosaur)
            //Illogical for Robot class to simply create a dinosaur to attack.
            //1. A robot does not "have" a dinosaur.
            //2. A dinosaur created in Robot class would not be a Dinosaur class robot.
            //Access Dinosaur class through a parameter.
        {
            attackedDinosaur.health -= weapon.attackPower;
        }

        



    }
}
