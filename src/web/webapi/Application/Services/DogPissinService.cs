using DogPissNCo.webapi.Application.Interfaces;
namespace DogPissNCo.webapi.Application.Services
{
    public class DogPissinService : IDogPissinService
    {
        IDogRepository _dogeRepository;

        public DogPissinService(IDogRepository dogRepository)
        {
            _dogeRepository = dogRepository;
        }

        public int PissDogs()
        {
            int dogsPissed = 0;
            var dog = _dogeRepository.GetDog();
            if (dog.AmountOfPeeMl > 0){
                dog.AmountOfPeeMl = 0;
                dogsPissed++;
            }

            return dogsPissed;
        }
    }
}

