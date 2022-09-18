using DogPissNCo.webapi.Application.Interfaces;
using DogPissNCo.webapi.Application.Services;

using Microsoft.AspNetCore.Mvc;
namespace DogPissNCo.webapi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    class DogPissinController : ControllerBase
    {
        IDogPissinService _dogPissingService;
        public DogPissinController(IDogPissinService dogPissingService)
        {
            _dogPissingService = dogPissingService;
        }

        [HttpGet]
        public ActionResult Get(){
        _dogPissingService.PissDogs();
        return new OkResult();
        }
    }
}