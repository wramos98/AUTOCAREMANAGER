using System;
using System.Collections.Generic;

namespace AUTOCAREMANAGER.DOMAIN.Core.Entities;

public partial class TbVehiculo
{
    public int CodVehiculo { get; set; }

    public string Placa { get; set; } = null!;

    public string? Marca { get; set; }

    public string? Modelo { get; set; }

    public string? Año { get; set; }

    public DateTime? FecUltMant { get; set; }

    public int CodSn { get; set; }

    public virtual TbSocioDeNegocio CodSnNavigation { get; set; } = null!;

    public virtual ICollection<TbActServicio> TbActServicio { get; set; } = new List<TbActServicio>();
}
