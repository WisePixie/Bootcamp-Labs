using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TacoFastFoodAPI.Data;
using TacoFastFoodAPI.Models.Dto;
using TacoFastFoodAPI.Models;
using TacoFastFoodAPI.Models.Dto;


namespace TacoFastFoodAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class DrinksController : ControllerBase
{
    private readonly DrinksDbContext _drinksDB;

    public DrinksController(DrinksDbContext drinksDbContext)
    {
        _drinksDB = drinksDbContext;
    }

    [HttpGet]
    public IActionResult GetAllDrinks()
    {
        return Ok(_drinksDB.Drinks.ToList());
    }

    [HttpGet("{id}")]
    public IActionResult GetDrinksById(int id) 
    {
        var drinks = _drinksDB.Drinks.Find(id);

        if (drinks == null)
        {
            return NotFound();
        }

        return Ok(drinks);
    }

    [HttpPost]
    public IActionResult CreateDrinks([FromBody] CreateDrinksDto drinks)
    {
        Drinks newDrinks = new Drinks();

        newDrinks.Name = drinks.Name;
        newDrinks.Cost = drinks.Cost;
        newDrinks.Slushie = drinks.Slushie;


        _drinksDB.Add(newDrinks);
        _drinksDB.SaveChanges();

        return Ok(newDrinks);
    }

    [HttpPut("{id}")]
    public IActionResult UpdateDrinks(int id, [FromBody]UpdateDrinksDto updateDrinks)
    {
        var drinks = _drinksDB.Drinks.Find(id);

        if(drinks == null)
        {
            return NotFound();
        }

        drinks.Name = updateDrinks.Name;
        drinks.Cost= updateDrinks.Cost;
        drinks.Slushie= updateDrinks.Slushie;

        _drinksDB.Add(drinks);
        _drinksDB.SaveChanges();

        return Ok(drinks);
    }

}
