using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01
{
    // Create a static class called DogShelter that has: List of Dogs; PrintAll() - prints all dogs from List of Dogs
    public static class DogShelter
    {
        public static List<Dog> dogs = new List<Dog>();

        public static void PrintAll()
        {
            for (int i = 0; i < dogs.Count; i++)
            {
                Console.WriteLine($" ID:{dogs[i].Id}, name: {dogs[i].Name}, color: {dogs[i].Color}");
            }
        }
    }
}
