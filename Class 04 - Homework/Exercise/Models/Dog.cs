using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise.Models
{
    public class Dog : Pet
    {
        // Dog(from Pet) with GoodBoi and FavoriteFood
        public bool GoodBoi { get; set; }
        public string FavoriteFood { get; set; }

        public Dog(string name, int age, string breed, bool goodBoi, string favoriteFood) : base(name, age)
        {
            Breed = breed;
            GoodBoi = goodBoi;
            FavoriteFood = favoriteFood;
        }

        public override void PrintInfo()
        {
            if (GoodBoi = true)
            {
                Console.WriteLine($"The dog is called {Name} and he is a very good boi! He eats a lot and his favorite food is {FavoriteFood}.");
            }
            else
            {
                Console.WriteLine($"{Name} is not a good boi because he barks a lot, except when he eats {FavoriteFood}, because that's his favorite food.");
            }
        }
    }
}
