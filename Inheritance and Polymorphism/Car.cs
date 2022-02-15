using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_and_Polymorphism
{
    internal class Car : Vehicle
    {
        public bool Radio { get; set; }
        public Car(int numOfDoors, int engineSize, string? colour, string? make, string? model, bool radio) :
            base(
                4,
                numOfDoors,
                engineSize,
                colour,
                make,
                model)
        {
            Radio = radio;
        }
    }
}