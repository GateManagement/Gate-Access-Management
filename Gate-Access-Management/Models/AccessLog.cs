using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gate_Access_Management.Models;

public class AccessLog
{
    [Key]
    public int AccessLogId { get; set; }

    public DateTime TimestampUtc { get; set; }

    public string GateDirection { get; set; } = string.Empty;

    public string Result { get; set; } = string.Empty;

    public string? Reason { get; set; }

    public string? CodeEntered { get; set; }

    public int? TenantId { get; set; }

    [ForeignKey(nameof(TenantId))]
    public Tenant? Tenant { get; set; }

    public int? UnitId { get; set; }

    [ForeignKey(nameof(UnitId))]
    public Unit? Unit { get; set; }
}
