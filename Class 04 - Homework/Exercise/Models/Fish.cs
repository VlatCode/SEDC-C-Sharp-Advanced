using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise.Models
{
    public class Fish : Pet
    {
        // Fish(from Pet) with color, size
        public string Color { get; set; }
        public int Size { get; set; }

        public Fish(string name, int age, string breed, string color, int size) : base(name, age)
        {
            Breed = breed;
            Color = color;
            Size = size;
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"{Name} is of color {Color} and it is {Size} meters long!");
        }
    }
}
