using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
    [Phone]
    [Display(Name = "Phone Number")]
    public string PhoneNumber { get; set; } = string.Empty;

    [StringLength(100)] public string? Address { get; set; }

    [StringLength(50)] public string? State { get; set; }

    [StringLength(10)]
    [Display(Name = "Zip Code")]
    public string? ZipCode { get; set; }

    [EmailAddress] [StringLength(100)] public string? Email { get; set; }

    [Required]
    [DataType(DataType.Password)]
    [StringLength(100, MinimumLength = 4)]
    public string UserPin { get; set; } = string.Empty;

    [DataType(DataType.DateTime)]
    [Display(Name = "Created On")]
    public DateTime CreatedOn { get; set; } = DateTime.Now;

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
}
