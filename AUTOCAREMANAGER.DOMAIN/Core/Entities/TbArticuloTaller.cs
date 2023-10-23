using System;
using System.Collections.Generic;

namespace AUTOCAREMANAGER.DOMAIN.Core.Entities;

public partial class TbArticuloTaller
{
    public int CodArticulo { get; set; }

    public int CodTaller { get; set; }

    public int Stock { get; set; }

    public virtual TbArticulo CodArticuloNavigation { get; set; } = null!;

    public virtual TbTaller CodTallerNavigation { get; set; } = null!;
}
