using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using TacoFastFoodAPI.Models;
using TacoFastFoodAPI.Models.Dto;



namespace TacoFastFoodAPI.Data;



public class DrinksDbContext : DbContext
{
    public DrinksDbContext(DbContextOptions<DrinksDbContext> options) : base(options)
    {

    }

    public virtual DbSet<Drinks> Drinks { get; set; }

}
