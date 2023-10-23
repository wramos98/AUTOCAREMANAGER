using System;
using System.Collections.Generic;

namespace AUTOCAREMANAGER.DOMAIN.Core.Entities;

public partial class TbTaller
{
    public int CodTaller { get; set; }

    public string DesTaller { get; set; } = null!;

    public string? Direccion { get; set; }

    public string? Ciudad { get; set; }

    public string? País { get; set; }

    public virtual ICollection<TbEmpleado> TbEmpleado { get; set; } = new List<TbEmpleado>();
}
