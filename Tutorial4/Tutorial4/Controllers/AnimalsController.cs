using Microsoft.AspNetCore.Mvc;
using Tutorial4.Database;

namespace Tutorial4.Controllers;

[ApiController]
[Route("[controller]")]
public class AnimalsController : ControllerBase
{

    [HttpGet]
    public IActionResult GetAnimals()
    {
        var animals = StaticData.animals;
        var Animals = new MockDb().Animals;
        return Ok(animals);
    }
    [HttpGet("{id}")]
    public IActionResult GetAnimals(int id)
    {
        var animals = StaticData.animals;
        var Animals = new MockDb().Animals;
        return Ok(animals);
    }
}