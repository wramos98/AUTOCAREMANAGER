using System;
using System.Collections.Generic;

namespace AUTOCAREMANAGER.DOMAIN.Core.Entities;

public partial class TbUsuario
{
    public int UserCode { get; set; }

    public string Email { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string FirmaUsuario { get; set; } = null!;

    public string Nombres { get; set; } = null!;

    public string Apellidos { get; set; } = null!;

    public string TipoUsuario { get; set; } = null!;

    public virtual ICollection<TbEmpleado> TbEmpleado { get; set; } = new List<TbEmpleado>();

    public virtual ICollection<TbSocioDeNegocio> TbSocioDeNegocio { get; set; } = new List<TbSocioDeNegocio>();
}
