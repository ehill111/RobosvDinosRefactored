using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaursRefactored
{
    class Herd
    {   //Member variables have/has a/an...
        List<Dinosaur> dinosaurs;

        //Constructor makes mold.
        public Herd()
        {
            List<Dinosaur> dinosaurs = new List<Dinosaur>();//Constructor instantiates list.
            Dinosaur dinosaur1 = new Dinosaur("Glockosaurus");//Constructor instantiates three dinosaurs.
            Dinosaur dinosaur2 = new Dinosaur("Bitebuttasaurus");
            Dinosaur dinosaur3 = new Dinosaur("Salivasaurus");
            dinosaurs.Add(dinosaur1);//Constructor adds three dinosaurs to list.
            dinosaurs.Add(dinosaur2);
            dinosaurs.Add(dinosaur3);
        }


       
    }
}
