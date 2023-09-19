using System;
using System.Collections.Generic;

namespace NetCoreAdminInfo.Entity;

public partial class AdminDetail
{
    public int AdminId { get; set; }

    public string? Name { get; set; }

    public int? GenderId { get; set; }

    public int? ActiveId { get; set; }

    public string? Hobby { get; set; }

    public string? ImagePath { get; set; }

    public bool? Football { get; set; }

    public bool? Basketball { get; set; }

    public bool? Singing { get; set; }

    public bool? Travelling { get; set; }

    public DateTime? RegisterDate { get; set; }
}
