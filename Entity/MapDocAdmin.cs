using System;
using System.Collections.Generic;

namespace NetCoreAdminInfo.Entity;

public partial class MapDocAdmin
{
    public int MapId { get; set; }

    public int? AdminId { get; set; }

    public string? FilePath { get; set; }

    public string? FileName { get; set; }
}
