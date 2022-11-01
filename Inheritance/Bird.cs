using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Bird : Animal
    {
    public Bird()
        {
            NumberOfLegs = 2;
            LivesInWater = false;
            IsWarmedBLooded = true;
            LaysEggs = true;
        }

        public bool DoesFly { get; set; }
        public bool HasHookedBeak { get; set; }
        public bool IsAquatic { get; set; }
        public bool IsPredatory { get; set; }
        public string Name { get; set; }

        public void PrintDetails()
        {
            Console.WriteLine($"{GetType().Name}");
            Console.WriteLine($"{Name}");
            Console.WriteLine($"Can fly: {DoesFly.ToString().ToLower()}");
            Console.WriteLine($"Has a hooked beak?: {HasHookedBeak}");
            Console.WriteLine($"Is aquatic?: {IsAquatic}");
            Console.WriteLine($"Is predatory?: {IsPredatory}");
        }

    }
}
