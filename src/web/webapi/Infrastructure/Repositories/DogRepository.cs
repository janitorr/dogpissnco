using DogPissNCo.webapi.Application.Interfaces;
using DogPissNCo.webapi.Models;

namespace DogPissNCo.webapi.Infastructure.Repositores
{
    class DogRepository : IDogRepository
    {
        public Dog GetDog()
        {
            return new Dog() {
                Name = "Ambassador",
                AmountOfPeeMl = 12,
                MaxPeeMl = 50
            };
        }

        public ICollection<Dog> GetDogs()
        {
            return new List<Dog>();
        }
    }
}