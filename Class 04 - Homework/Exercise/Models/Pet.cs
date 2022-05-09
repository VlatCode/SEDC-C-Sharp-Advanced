using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise.Models
{
    public abstract class Pet
    {
        // Pet( abstract ) with Name, Breed, Age and abstract PrintInfo()
        public string Name { get; set; }
        public int Age { get; set; }
        public string Breed { get; set; }

        protected Pet(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public abstract void PrintInfo();
    }
}
