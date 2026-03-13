using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gate_Access_Management.Models;

public class Tenant
{
    [Key] public int TenantId { get; set; }

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
    public string Phone { get; set; } = string.Empty;

    [EmailAddress]
    [Display(Name = "Email")]
    [StringLength(100)]
    public string? Email { get; set; }

    [StringLength(100)]
    [Display(Name = "Address")]
    public string? Address { get; set; }

    [StringLength(50)]
    [Display(Name = "City")]
    public string? City { get; set; }

    [StringLength(50)]
    [Display(Name = "State")]
    public string? State { get; set; }

    [StringLength(10)]
    [Display(Name = "Zip Code")]
    public string? ZipCode { get; set; }

    [Required]
    [DataType(DataType.Password)]
    [StringLength(100, MinimumLength = 4)]
    public string AccessCode { get; set; } = string.Empty;

    public int AccessScheduleId { get; set; }

    [ForeignKey(nameof(AccessScheduleId))]
    public AccessSchedule? AccessSchedule { get; set; }

    [Display(Name = "Is Gate Access Enabled")] 
    public bool IsGateAccessEnabled { get; set; } = true;

    [Display(Name = "Is Enabled")] 
    public bool IsEnabled { get; set; } = true;

    [DataType(DataType.DateTime)]
    [Display(Name = "Created On")]
    public DateTime CreatedOn { get; set; } = DateTime.Now;

    [DataType(DataType.DateTime)]
    [Display(Name = "Updated On")]
    public DateTime? UpdatedOn { get; set; }

    [Display(Name = "Is Deleted")] public bool IsUserDeleted { get; set; } = false;

    [DataType(DataType.DateTime)]
    [Display(Name = "Last User Entrance")]
    public DateTime? LastUserEntrance { get; set; }

    [DataType(DataType.Text)]
    [Display(Name = "Notes")]
    public string? Notes { get; set; } = string.Empty;
}