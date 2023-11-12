using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AUTOCAREMANAGER.DOMAIN.Core.DTO
{
    internal class ArticuloDTO
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

    public class ArticuloActualizarDTO
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

}
