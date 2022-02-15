using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_and_Polymorphism
{
    internal class Motorbike : Vehicle
    {
        public Motorbike(int numOfDoors, int engineSize, string? colour, string? make, string? model) :
            base(
                2,
                numOfDoors,
                engineSize,
                colour,
                make,
                model)
        {

        }
    }
}