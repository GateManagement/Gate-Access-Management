using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gate_Access_Management.Models;

public class DaysScheduled
{
    [Key]
    public int DaysScheduledId { get; set; }

    [Required]
    public string DayOfWeek { get; set; } = string.Empty;

    public int AccessScheduleId { get; set; }

    [ForeignKey(nameof(AccessScheduleId))]
    public AccessSchedule? AccessSchedule { get; set; }

    public TimeOnly StartTime { get; set; }

    public TimeOnly EndTime { get; set; }
}
