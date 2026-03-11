using System.ComponentModel.DataAnnotations;

namespace Gate_Access_Management.Models;

public class Unit
{
    [Key] public int UnitId { get; set; }

    [DataType(DataType.Password)]
    []

    // [Required]
    // public User User { get; set; }

    public GaragePreset GaragePreset { get; set; }
}