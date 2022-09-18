using DogPissNCo.webapi.Application.Interfaces;
using DogPissNCo.webapi.Application.Services;
using DogPissNCo.webapi.Models;
using NSubstitute;

namespace tests;

public class DogPissinServiceTests
{
    IDogRepository _dogRepositoryMock;
    IDogPissinService _DogPissinService;
    public DogPissinServiceTests()
    {
        _dogRepositoryMock = Substitute.For<IDogRepository>();
        _DogPissinService = new DogPissinService(_dogRepositoryMock);
    }
    [Fact]
    public void Test1()
    {
        var testDog = new Dog() {
            Name = Faker.Name.First(),
            MaxPeeMl = 100,
            AmountOfPeeMl = 75
        };
        _dogRepositoryMock.GetDog().Returns(testDog);
        var report = _DogPissinService.PissDogs();
        report.Should().Be(1,"Only one dog was inserted");
    }
}