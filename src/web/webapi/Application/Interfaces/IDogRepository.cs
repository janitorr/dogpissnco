using DogPissNCo.webapi.Models;

namespace DogPissNCo.webapi.Application.Interfaces
{
    public interface IDogRepository
    {
        Dog GetDog();
        ICollection<Dog> GetDogs();
    }
}