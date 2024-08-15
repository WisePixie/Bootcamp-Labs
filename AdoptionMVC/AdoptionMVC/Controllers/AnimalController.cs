using AdoptionMVC.Models;
using AdoptionMVC.Models.Data;
using Microsoft.AspNetCore.Mvc;
namespace AdoptionMVC.data;

public class AnimalController : Controller
{

    //Dependency injection  container DI for short
    private readonly AppDbContext _dbContext;//Controller is a class also a pattern to follow

    public AnimalController(AppDbContext dbContext)
    {
        _dbContext = dbContext;//by typing this out in this pattern it will give us a copy of the app dbcontext,DI, Like a fridge, go to the fridge and get me a fresh dbcontext.
    }
    
    [HttpPost]
    public IActionResult SearchAnimals(string breedInput)
    {
        //SELECT * FROM Animals WHERE Breed = breedInput
        return View();

        var animals = _dbContext.Animals.Where(x => x.Breed == breedInput).ToList();    
        return View(animals);
    }

}
