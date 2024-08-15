using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TacoFastFoodAPI.Data;
using TacoFastFoodAPI.Models.Dto;
using TacoFastFoodAPI.Models;

namespace TacoFastFoodAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TacosController : ControllerBase
{
    private readonly TacosDbContext _tacosDB;//property

    public TacosController(TacosDbContext tacosDbContext)//Constructor within ()
    {
        _tacosDB = tacosDbContext;
    }

    [HttpGet]//Get /Tacos

    public IActionResult GetAllTacos() 
    {
        return Ok(_tacosDB.Tacos.ToList());//list and 200Code
    }
    //Take in a bool as an optional query prameter for SoftShell. Filter the response if SoftShell is provided

    [HttpGet("{id}")] //Get /Tacos/{id}

    public IActionResult GetTacos(int id) 
    {
        var tacos = _tacosDB.Tacos.Find(id);

        if (tacos == null)
        {
            return NotFound();//404
        }
        return Ok(tacos);//200

        //take in int id as path parameter
    }

    [HttpPost]
    public IActionResult CreateTaco([FromBody] CreateTacosDto taco)
    {
        Tacos newTacos = new Tacos();

        newTacos.Name = taco.Name;
        newTacos.Cost = taco.Cost;
        newTacos.SoftShell = taco.SoftShell;
        newTacos.Chips = taco.Chips;

        _tacosDB.Add(newTacos);
        _tacosDB.SaveChanges();

        return Ok(newTacos);


        //The Created Taco
        //Resonse code: 201 Created
        //Take in taco from body
    }

    [HttpDelete("{id}")]

    public IActionResult DeleteTacos(int id)
    {
        var tacos = _tacosDB.Tacos.Find(id);

        if (tacos == null)//response.nothing
        {
            return NotFound();//404
        }

        _tacosDB.Tacos.Remove(tacos);
        _tacosDB.SaveChanges();

        return NoContent();//204?
    }
}
