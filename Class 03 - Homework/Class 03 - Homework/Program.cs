using System;

namespace Exercise01 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create 3 Dog objects,

            Dog dog01 = new Dog(1, "Rex", "Black & Brown");
            Dog dog02 = new Dog(2, "Lora", "Grey");
            Dog dog03 = new Dog(3, "Aron", "White");

            dog01.Bark();

            // call validate on them to see if they are okay,
            Console.WriteLine(Dog.Validate(dog01));
            Console.WriteLine(Dog.Validate(dog02));
            Console.WriteLine(Dog.Validate(dog03));

            // add them in the List of Dogs,
            DogShelter.dogs.Add(dog01);
            DogShelter.dogs.Add(dog02);
            DogShelter.dogs.Add(dog03);

            // and call PrintAll();
            DogShelter.PrintAll();
        }
    }
}