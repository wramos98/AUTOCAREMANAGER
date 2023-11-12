using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AUTOCAREMANAGER.DOMAIN.Core.DTO
{
    public class FacturaVentaDetalleDTO
    {
        public int DocID { get; set; }
        public int NumLinea { get; set; }
        public int CodArticulo { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }
        public decimal Subtotal { get; set; }
    }


    public class FacturaVentaCabeceraDTO
    {
        public int DocID { get; set; }
        // Supongamos que tienes estas propiedades adicionales en tu tabla de cabecera
        public DateTime Fecha { get; set; }
        public int ClienteID { get; set; }
        public decimal TotalFactura { get; set; }
        public List<FacturaVentaDetalleDTO> Detalles { get; set; }
    }



    public class CrearFacturaVentaDTO
    {
        public DateTime Fecha { get; set; }
        public int ClienteID { get; set; }
        public List<FacturaVentaDetalleDTO> Detalles { get; set; }
    }


    public class ActualizarFacturaVentaDTO
    {
        public int DocID { get; set; } // Se necesita para identificar la factura a actualizar
        public DateTime Fecha { get; set; }
        public int ClienteID { get; set; }
        public List<FacturaVentaDetalleDTO> Detalles { get; set; }
    }

    public class ConsultaFacturaVentaDTO
    {
        public int DocID { get; set; }
        public DateTime Fecha { get; set; }
        public int ClienteID { get; set; }
        public decimal TotalFactura { get; set; }
        public List<FacturaVentaDetalleDTO> Detalles { get; set; }
    }


}
