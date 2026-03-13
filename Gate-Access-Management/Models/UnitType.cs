using System.ComponentModel.DataAnnotations;

namespace Gate_Access_Management.Models;

public class UnitType
{
    [Key]
    public int UnitTypeId { get; set; }

    [Required]
    public string Name { get; set; } = string.Empty;

    public int WidthFt { get; set; }

    public int LengthFt { get; set; }

    public decimal StandardMonthlyPrice { get; set; }
}
