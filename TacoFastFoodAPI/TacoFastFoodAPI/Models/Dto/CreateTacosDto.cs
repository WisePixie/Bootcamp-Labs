namespace TacoFastFoodAPI.Models.Dto;

public class CreateTacosDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Cost {  get; set; }
    public bool SoftShell { get; set; }
    public bool Chips { get; set; } 
}
