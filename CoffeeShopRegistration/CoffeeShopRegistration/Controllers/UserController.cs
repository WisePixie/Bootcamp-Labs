using CoffeeShopRegistration.Models;
using CoffeeShopRegistration.Models.Data;
using Microsoft.AspNetCore.Mvc;
namespace CoffeeShopRegistration.Controllers;

    public class UserController : Controller
    {
        //Dependency injection DI for short
        private AppDbContext _dbContext;//controller is a class ALSO IS A PATTERN TO FOLLOW 

        public UserController(AppDbContext dbContext)
        {
            _dbContext = dbContext;//making a copy and handing it off to controller
        }
        public IActionResult Register()
        {
            return View();
        }

        //The user on line 16
        //
        [HttpPost]
        public IActionResult RegisterUser(User user)
        {
            _dbContext.Add(user);//insert user

            _dbContext.SaveChanges();//do within database

            return RedirectToAction("Index", "Home");//redirect to action kicks them back to "homepage"
        }
    }

