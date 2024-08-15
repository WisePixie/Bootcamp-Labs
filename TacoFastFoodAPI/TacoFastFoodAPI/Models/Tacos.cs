using System;
using System.Collections.Generic;


namespace TacoFastFoodAPI.Models;

public partial class Tacos
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Cost { get; set; }
    public bool SoftShell { get; set; }
    public bool Chips { get; set; }
}
