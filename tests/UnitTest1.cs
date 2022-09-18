using DogPissNCo.webapi.Application.Interfaces;
using DogPissNCo.webapi.Application.Services;
namespace tests;

public class DogPissinServiceTests
{
    IDogRepository _dogRepository;
    IDogPissinService _sut;
    public DogPissinServiceTests()
    {
        _sut = new DogPissinService(null);
    }
    [Fact]
    public void Test1()
    {

    }
}