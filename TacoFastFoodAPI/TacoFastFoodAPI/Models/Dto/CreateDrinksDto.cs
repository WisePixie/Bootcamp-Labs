﻿namespace TacoFastFoodAPI.Models.Dto;

public class CreateDrinksDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Cost { get; set; }
    public bool Slushie { get; set; }
}
