using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // DONE Create a class Animal
            // DONE give this class 4 members that all Animals have in common


            // DONE Create a class Bird
            // DONE give this class 4 members that are specific to Bird
            // DONE Set this class to inherit from your Animal Class

            // DONE Create a class Reptile
            // DONE give this class 4 members that are specific to Reptile
            // DONE Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            Bird Canary = new Bird()
            {
                DoesFly = true,
                HasHookedBeak = false,
                IsAquatic = false,
                IsPredatory = false,
                Name = "Canary"
            };
            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
            Reptile Alligator = new Reptile() 
            { 
                Color = "green", 
                HasShell = false, 
                IsVenomous = false, 
                IsWarmedBLooded = false, 
                LaysEggs = true, 
                LivesInWater = true, 
                NumberOfLegs = 4, 
                Slithers = false, 
                Name = "Alligator"
            };
            
            Canary.PrintDetails();
            Console.WriteLine();
            Alligator.PrintDetails();

        }
    }
}
