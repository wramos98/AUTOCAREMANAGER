using System;
using System.Collections.Generic;

namespace AUTOCAREMANAGER.DOMAIN.Core.Entities;

public partial class TbArticulo
{
    public int CodArticulo { get; set; }

    public string DesArticulo { get; set; } = null!;

    public string ArtInventariable { get; set; } = null!;

    public string TipoServicio { get; set; } = null!;

    public string? UnidadMedida { get; set; }

    public string? Fabricante { get; set; }

    public string ImpVenta { get; set; } = null!;

    public string Estado { get; set; } = null!;
}
