using System;
using System.Collections.Generic;

namespace NetCoreAdminInfo.Entity;

public partial class MapImgDriver
{
    public int ImageId { get; set; }

    public int? DriverId { get; set; }

    public string? Filepath { get; set; }

    public string? Filename { get; set; }
}
