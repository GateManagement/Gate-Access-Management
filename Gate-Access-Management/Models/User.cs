using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Gate_Access_Management.Models;

public class User
{
    [Key] public int UserId { get; set; }

    [Required]
    [StringLength(50)]
    [Display(Name = "First Name")]
    public string FirstName { get; set; } = string.Empty;

    [Required]
    [StringLength(50)]
    [Display(Name = "Last Name")]
    public string LastName { get; set; } = string.Empty;

    [Required]
    [DataType(DataType.PhoneNumber)]
    [Phone]
    [Display(Name = "Phone Number")]
    public string PhoneNumber { get; set; } = string.Empty;

    [StringLength(100)]
    [Display(Name = "Address")]
    public string? Address { get; set; }

    [StringLength(50)]
    [Display(Name = "State")]
    public string? State { get; set; }

    [EmailAddress]
    [Display(Name = "Email")]
    [StringLength(100)]
    public string? Email { get; set; }

    [Required]
    [DataType(DataType.Password)]
    [StringLength(100, MinimumLength = 4)]
    public string UserPin { get; set; } = string.Empty;

    [DataType(DataType.DateTime)]
    [Display(Name = "Created On")]
    public DateTime CreatedOn { get; set; } = DateTime.Now;

    [DataType(DataType.DateTime)]
    [Display(Name = "Vacated On")]
    public DateTime? VacatedOn { get; set; }

    [Display(Name = "Is Deleted")] public bool IsUserDeleted { get; set; } = false;

    [DataType(DataType.DateTime)]
    [Display(Name = "Modified On")]
    public DateTime? ModifiedOn { get; set; }

    [DataType(DataType.DateTime)]
    [Display(Name = "Last User Entrance")]
    public DateTime? LastUserEntrance { get; set; }

    [DataType(DataType.DateTime)]
    [Display(Name = "Last User Payment")]
    public DateTime? LastUserPayment { get; set; }

    [Display(Name = "Is Disabled")] public bool IsDisabled { get; set; } = false;

    public ICollection<Garage> Garages { get; set; } = new List<Garage>();
}