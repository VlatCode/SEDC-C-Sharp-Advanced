using Exercise.Models;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a Dog, Cat and fish store with 2 pets each
            Dog dog1 = new Dog("Rex", 7, "German Shepherd", true, "Pork");
            Dog dog2 = new Dog("Frank", 10, "Pug", false, "Ham");
            Dog dog3 = new Dog("Archie", 7, "French Bulldog", true, "Chicken wings");
            Dog dog4 = new Dog("Daisy", 10, "West Highland Terrier", false, "Crackers");
            Dog dog5 = new Dog("Bruno", 7, "Stray dog", true, "Bones");
            Dog dog6 = new Dog("Hugo", 10, "Beagle", false, "Beef steak");

            Cat cat1 = new Cat("Chris", 15, "Bengal cat", false, 4);
            Cat cat2 = new Cat("Garfield", 7, "Sphynx", true, 7);
            Cat cat3 = new Cat("Luna", 2, "Siamese cat", false, 3);
            Cat cat4 = new Cat("Bella", 7, "Van cat", true, 1);
            Cat cat5 = new Cat("Loki", 6, "Siberian cat", false, 5);
            Cat cat6 = new Cat("Leo", 3, "Scottish Fold", true, 6);

            Fish fish1 = new Fish("Nemo", 2, "Clownfish", "Orange & White", 1);
            Fish fish2 = new Fish("Seadog", 3, "Shark", "Grey", 3);

            // ▹ Call PrintPets() method on all stores
            
            // Dogs
            List<Dog> ListOfDogs = new List<Dog>();
            ListOfDogs.Add(dog1);
            ListOfDogs.Add(dog2);
            ListOfDogs.Add(dog3);
            ListOfDogs.Add(dog4);
            ListOfDogs.Add(dog5);
            ListOfDogs.Add(dog6);

            List<Dog> ListOfDogsIWantToBuy = new List<Dog>();
            ListOfDogsIWantToBuy.Add(dog1);
            ListOfDogsIWantToBuy.Add(dog3);

            PetStore<Dog> dogStore = new PetStore<Dog>();
            dogStore.ListOfPets = ListOfDogs;
            dogStore.PrintPets();

            // Cats
            List<Cat> ListOfCats = new List<Cat>();
            ListOfCats.Add(cat1);
            ListOfCats.Add(cat2);

            PetStore<Cat> catStore = new PetStore<Cat>();
            catStore.ListOfPets = ListOfCats;
            catStore.PrintPets();

            // Fish
            List<Fish> ListOfFish = new List<Fish>();
            ListOfFish.Add(fish1);
            ListOfFish.Add(fish2);

            PetStore<Fish> fishStore = new PetStore<Fish>();
            fishStore.ListOfPets = ListOfFish;
            fishStore.PrintPets();

            // ▹ Buy a dog and a cat from the Dog and Cat store
            Console.WriteLine(".BuyPet() success: ");
            dogStore.BuyPet("Rex");

            Console.WriteLine(".BuyPet() fail (Exception): ");
            // Exception handler
            try
            {
                dogStore.BuyPet("Murdzo");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            ///////
            ///

            dogStore.BuyPets(ListOfDogsIWantToBuy);
        }
    }
}