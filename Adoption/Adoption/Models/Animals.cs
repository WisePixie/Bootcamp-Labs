using Microsoft.AspNetCore.Mvc;

namespace Adoption.Models;

public class Animals
{
    public int Id { get; set; }
    public string Img { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string Breed { get; set; }
    public int Age { get; set; }
}
