using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01
{
    public class Dog
    {
        // Create a regular class called Dog that has: Id, Name, Color, Bark() - Prints “Bark Bark”
        public int Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }

        public void Bark()
        {
            Console.WriteLine($"Bark Bark");
        }

        // A static method Validate() - Checks if dog has all 3 properties set, if Id is not less than 0 and Name is 2 characters or longer
        public static bool Validate(Dog validateProperties) // bool because it's validation
        {
            return validateProperties.Id > 0 && validateProperties.Name.Length >= 2 && validateProperties.Color != string.Empty;
        }

        public Dog(int id, string name, string color)
        {
            Id = id;
            Name = name;
            Color = color;
        }

    }
}
