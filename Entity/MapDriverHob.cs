using System;
using System.Collections.Generic;

namespace NetCoreAdminInfo.Entity;

public partial class MapDriverHob
{
    public int MapId { get; set; }

    public int? DriverId { get; set; }

    public int? HobbyId { get; set; }
}
