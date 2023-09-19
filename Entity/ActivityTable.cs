using System;
using System.Collections.Generic;

namespace NetCoreAdminInfo.Entity;

public partial class ActivityTable
{
    public int IsActive { get; set; }

    public string? Available { get; set; }

    public virtual ICollection<DriverTable> DriverTables { get; set; } = new List<DriverTable>();
}
