using System.ComponentModel.DataAnnotations;

namespace Gate_Access_Management.Models;

public class Garage
{
    [Key]
    public int GarageId { get; set; }
    
    [Required]
    public GarageSize GarageSizeId { get; set; }
    
    [Required]
    public int GarageBuilding { get; set; }
    
    [Required]
    public int UserId { get; set; }
    
    [Required]
    [DataType(DataType.Currency)]
    public decimal GarageCost { get; set; }
    
}

public enum GarageSize
{
    Small = 1,
    Medium = 2,
    Large = 3
}