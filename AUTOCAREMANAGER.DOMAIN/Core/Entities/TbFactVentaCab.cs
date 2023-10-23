using System;
using System.Collections.Generic;

namespace AUTOCAREMANAGER.DOMAIN.Core.Entities;

public partial class TbFactVentaCab
{
    public int DocId { get; set; }

    public int CodSn { get; set; }

    public DateTime FecDocumento { get; set; }

    public DateTime FecVencimiento { get; set; }

    public DateTime ProxFecMant { get; set; }

    public string? CondicionPago { get; set; }

    public string Moneda { get; set; } = null!;

    public string NumSerieFiscal { get; set; } = null!;

    public string NumCorrelativo { get; set; } = null!;

    public string? Comentarios { get; set; }

    public decimal DocTotal { get; set; }

    public int CodEmpleado { get; set; }

    public int ActId { get; set; }

    public virtual TbActServicio Act { get; set; } = null!;

    public virtual TbEmpleado CodEmpleadoNavigation { get; set; } = null!;

    public virtual TbSocioDeNegocio CodSnNavigation { get; set; } = null!;
}
