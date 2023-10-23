using System;
using System.Collections.Generic;

namespace AUTOCAREMANAGER.DOMAIN.Core.Entities;

public partial class TbFactVentaDet
{
    public int DocId { get; set; }

    public int NumLinea { get; set; }

    public int CodArticulo { get; set; }

    public int Cantidad { get; set; }

    public decimal Precio { get; set; }

    public decimal Subtotal { get; set; }

    public virtual TbArticulo CodArticuloNavigation { get; set; } = null!;

    public virtual TbFactVentaCab Doc { get; set; } = null!;
}
