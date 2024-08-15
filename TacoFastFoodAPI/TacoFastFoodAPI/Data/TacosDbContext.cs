using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using TacoFastFoodAPI.Models;


namespace TacoFastFoodAPI.Data;

public class TacosDbContext : DbContext
{
    public TacosDbContext(DbContextOptions<TacosDbContext> options) : base(options)
    {

    }

    public virtual DbSet<Tacos> Tacos { get; set; }

}
