using System.ComponentModel.DataAnnotations;

namespace CoffeeShopRegistration.Models;

public class User
{
    public int UserId { get; set; }
    [Required(ErrorMessage = "First name is required")]
    public string FirstName { get; set; }
    [Required(ErrorMessage = "Last name is required")]
    public string LastName { get; set; }
    [EmailAddress]
    public string Email { get; set; }
    [Required(ErrorMessage = "Password is required")]
    [MinLength(8, ErrorMessage = "Password myst be 8 characters long")]//modeling=taking a real world thing and turning it into a c# object 
    public string Password { get; set; }
}
