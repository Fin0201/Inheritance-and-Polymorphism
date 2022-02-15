using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_and_Polymorphism
{
    internal class Vehicle
    {

        private int NumOfWheels { get; set; }
        public int numOfWheels
        {
            get
            {
                return numOfWheels;
            }
            set
            {
                if (value < 0)
                    numOfWheels = value;
            }
        }
        public int NumOfDoors { get; set;}
        public int EngineSize { get; set;}
        public string? Colour { get; set; }
        public string? Make { get; set; }
        public string? Model { get; set; }



        public Vehicle(int numOfWheels,
                       int numOfDoors,
                       int engineSize,
                       string? colour,
                       string? make,
                       string? model)
        {
            NumOfWheels = numOfWheels;
            NumOfDoors = numOfDoors;
            EngineSize = engineSize;
            Colour = colour;
            Make = make;
            Model = model;
        }


        public override string? ToString()
        {
            return $"car: {Make} {Model}";
        }
    }
}