using System;
using System.Collections.Generic;

namespace NetCoreAdminInfo.Entity;

public partial class DriverTable
{
    public int DriverId { get; set; }

    public string? Name { get; set; }

    public string? ContactNo { get; set; }

    public int? GenderId { get; set; }

    public int? IsActive { get; set; }

    public string? Hobby { get; set; }

    public bool? Football { get; set; }

    public bool? Cricket { get; set; }

    public bool? Basketball { get; set; }

    public bool? Singing { get; set; }

    public bool? Dancing { get; set; }

    public bool? Reading { get; set; }

    public bool? Travelling { get; set; }

    public string? ImageFilePath { get; set; }

    public string? DocFilePath { get; set; }

    public virtual GenderTable? Gender { get; set; }

    public virtual ActivityTable? IsActiveNavigation { get; set; }
}
