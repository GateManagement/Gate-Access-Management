using System.ComponentModel.DataAnnotations;

namespace Gate_Access_Management.Models;

public class Garage
{
    [Key] public int GarageId { get; set; }

    [Required] public int GarageBuilding { get; set; }

    // [Required]
    // public User User { get; set; }

    public GaragePreset GaragePreset { get; set; }
}