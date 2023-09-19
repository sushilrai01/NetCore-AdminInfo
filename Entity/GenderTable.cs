using System;
using System.Collections.Generic;

namespace NetCoreAdminInfo.Entity;

public partial class GenderTable
{
    public int GenderId { get; set; }

    public string Category { get; set; } = null!;

    public virtual ICollection<DriverTable> DriverTables { get; set; } = new List<DriverTable>();
}
