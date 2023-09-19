using System;
using System.Collections.Generic;

namespace NetCoreAdminInfo.Entity;

public partial class HobbyTable
{
    public int HobbyId { get; set; }

    public string? Hobby { get; set; }

    public bool? IsActive { get; set; }
}
