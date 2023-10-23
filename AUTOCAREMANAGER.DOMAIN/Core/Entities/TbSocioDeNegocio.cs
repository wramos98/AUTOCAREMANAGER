using System;
using System.Collections.Generic;

namespace AUTOCAREMANAGER.DOMAIN.Core.Entities;

public partial class TbSocioDeNegocio
{
    public int CodSn { get; set; }

    public string RazonSocial { get; set; } = null!;

    public string NumIdent { get; set; } = null!;

    public string? PersonaContacto { get; set; }

    public string? Telefono { get; set; }

    public string Email { get; set; } = null!;

    public string? Direccion { get; set; }

    public string Estado { get; set; } = null!;

    public int? UserCode { get; set; }

    public virtual ICollection<TbFactVentaCab> TbFactVentaCab { get; set; } = new List<TbFactVentaCab>();

    public virtual ICollection<TbVehiculo> TbVehiculo { get; set; } = new List<TbVehiculo>();

    public virtual TbUsuario? UserCodeNavigation { get; set; }
}
