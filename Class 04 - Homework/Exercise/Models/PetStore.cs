using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise.Models
{
    internal class PetStore<T> where T : Pet
    {
        // Create a PetStore generic class with :
        // ▹ Generic list of pets - Dogs, Cats or Fish depending on what is passed as T

        public List<T> ListOfPets { get; set; } = new List<T>();

        public PetStore()
        {
            ListOfPets = new List<T>();
        }

        // ▹ Generic method printsPets() - Prints Dogs, Cats or Fish depending on what is passed as T
        public void PrintPets()
        {
            for (int i = 0; i < ListOfPets.Count; i++)
            {
                if (ListOfPets.Count == 0)
                {
                    Console.WriteLine("There are currently no pets in the store!");
                }
                else
                {
                    ListOfPets[i].PrintInfo();
                }
            }
        }

        // BuyPet() - Method that takes ‘name’ as parameter, find the first pet by that name, removes it from the list and gives a success message. If there is no pet by that name, inform the customer
        public void BuyPet(string name)
        {
            
            T pet = this.ListOfPets.FirstOrDefault(x => x.Name == name);
            if (pet == null)
            {
                throw new Exception("The pet by that name was not found!");
            }
            this.ListOfPets.Remove(pet);
            Console.WriteLine("Pet bought successfully");
        }

        public void BuyPets(List<T> ListOfPetsThatIWantToBuy)
        {
            foreach (T pet in ListOfPetsThatIWantToBuy)
            {
                this.ListOfPets.Remove(pet);
                Console.WriteLine(pet.Name);
            }
        }

        // Buy pets by name
        public void BuyPetsByName (List<string> petNamesThatIWantToBuy)
        {

        }
    }
}
