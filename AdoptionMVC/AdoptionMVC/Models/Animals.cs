using System.ComponentModel.DataAnnotations;
namespace AdoptionMVC.Models;

public class Animal
{
    public int Name { get; set; }
    public string IsAdopted { get; set; }
    public string Breed {  get; set; }
    public string Img { get; set; }


}
