using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise.Models
{
    public class Cat : Pet
    {
        // Cat( from Pet ) with Lazy and LivesLeft
        public bool Lazy { get; set; }
        public int LivesLeft { get; set; }

        public Cat(string name, int age, string breed, bool lazy, int livesLeft) : base(name, age)
        {
            Breed = breed;
            Lazy = lazy;
            LivesLeft = livesLeft;
        }

        public override void PrintInfo()
        {
            if (Lazy = true)
            {
                Console.WriteLine($"{Name} is a lazy cat and it has {LivesLeft} lives left.");
            }
            else
            {
                Console.WriteLine($"{Name} is very playful and active. It has {LivesLeft} lives left!");
            }
        }
    }
}
