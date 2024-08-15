﻿using Microsoft.EntityFrameworkCore;

namespace Adoption.Models.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {

    }

}
