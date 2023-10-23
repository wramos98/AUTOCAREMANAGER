using System;
using System.Collections.Generic;

namespace AUTOCAREMANAGER.DOMAIN.Core.Entities;

public partial class TbActServicio
{
    public int ActId { get; set; }

    public DateTime FecInicio { get; set; }

    public DateTime FecFin { get; set; }

    public int CodVehiculo { get; set; }

    public string DetalleReparacion { get; set; } = null!;

    public string? Estado { get; set; }

    public virtual TbVehiculo CodVehiculoNavigation { get; set; } = null!;

    public virtual ICollection<TbFactVentaCab> TbFactVentaCab { get; set; } = new List<TbFactVentaCab>();
}
