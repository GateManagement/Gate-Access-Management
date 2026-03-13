using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Gate_Access_Management.Models;

[Index(nameof(UnitCode), IsUnique = true)]
public class Unit
{
    [Key] public int UnitId { get; set; }

    [Display(Name = "Unit Code")] public string UnitCode { get; set; } = string.Empty;

    public int UnitTypeId { get; set; }

    [ForeignKey(nameof(UnitTypeId))] public UnitType? UnitType { get; set; }

    public bool IsEnabled { get; set; }

    public DateTime ModifiedOn { get; set; }

    public DateTime CreatedOn { get; set; }

    public string? Notes { get; set; }
}