using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            var myBird = new Bird();
            myBird.Name = "Tookie";
            myBird.CanFly = false;
            myBird.WingSpan = 14.7;
            myBird.DoMigrate = false;

            Console.WriteLine($"My Bird's name is {myBird.Name}, He is {myBird.Age} years old. He lives on {myBird.LandSeaAir}. Tookie has {myBird.LegCount} legs, and his wingspan is {myBird.WingSpan}.");
            Console.WriteLine($"Some questions you may have about Tookie are; Is he still alive? this is {myBird.IsAlive}, he is. However if you were to ask, Can he fly? Or Does he migrate? " +
                $"WEll, {myBird.CanFly}, {myBird.DoMigrate}, these answers,as you see, are both false for Tookie the bird.");

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */

            var myReptile = new Reptile();
            myReptile.IsColdBlooded = true;
            myReptile.IsScaly = true;
            myReptile.Habitat = "Florida swamps";
            myReptile.HerbOmniCarni = "Carnivores";

            var  myAliigator  = new Animal[] { myReptile };
            foreach (var alligator in myAliigator)
            {
                Console.WriteLine($"These are the stats for my alligator.");
                Console.WriteLine($"Alive:{alligator.IsAlive}");
                Console.WriteLine($"Age:{alligator.Age}");
                Console.WriteLine($"Legs:{alligator.LegCount}");
                Console.WriteLine($"Land,Sea, or Air: {alligator.LandSeaAir}");




            }


        }
    }
}
