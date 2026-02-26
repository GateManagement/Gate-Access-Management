using System.ComponentModel.DataAnnotations;

namespace Gate_Access_Management.Models;

public class GaragePreset
{
    [Key] public int GaragePresetId { get; set; }

    [Required]
    [DataType(DataType.Currency)]
    public decimal GarageCost { get; set; }

    [Required] public int Length { get; set; }

    [Required] public int Width { get; set; }
}