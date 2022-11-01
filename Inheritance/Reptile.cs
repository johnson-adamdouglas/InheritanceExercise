using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Reptile : Animal
    {
        public Reptile()
        {
            NumberOfLegs = 4;
            IsWarmedBLooded = false;
            LivesInWater = true;
            LaysEggs = true;
        }

        public string Color { get; set; }
        public bool Slithers { get; set; }
        public bool HasShell { get; set; }
        public bool IsVenomous { get; set; }

        public string Name { get; set; }


        public void PrintDetails()
        {
            Console.WriteLine($"{GetType().Name}");
            Console.WriteLine($"{Name}");
            Console.WriteLine($"Color is {Color}");
            Console.WriteLine($"Mobility - slither: {Slithers}");
        }

    }
}
