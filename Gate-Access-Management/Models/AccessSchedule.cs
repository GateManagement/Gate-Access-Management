using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Gate_Access_Management.Models;

public class AccessSchedule
{
    [Key]
    public int AccessScheduleId { get; set; }

    [Required]
    public string Name { get; set; } = string.Empty;

    public List<DaysScheduled> DaysScheduled { get; set; } = new List<DaysScheduled>();
}
