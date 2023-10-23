using System;
using System.Collections.Generic;

namespace AUTOCAREMANAGER.DOMAIN.Core.Entities;

public partial class TbEmpleado
{
    public int CodEmpleado { get; set; }

    public string Nombres { get; set; } = null!;

    public string Apellidos { get; set; } = null!;

    public string NumIdent { get; set; } = null!;

    public string? Cargo { get; set; }

    public string Estado { get; set; } = null!;

    public int CodTaller { get; set; }

    public int? UserCode { get; set; }

    public virtual TbTaller CodTallerNavigation { get; set; } = null!;

    public virtual ICollection<TbFactVentaCab> TbFactVentaCab { get; set; } = new List<TbFactVentaCab>();

    public virtual TbUsuario? UserCodeNavigation { get; set; }
}
