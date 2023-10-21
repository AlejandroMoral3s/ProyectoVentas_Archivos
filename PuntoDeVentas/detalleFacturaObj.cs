using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoDeVentas
{
    public class detalleFacturaObj
    {

        public int id_detalle {  get; set; }

        public int id_factura {  get; set; }

        public int id_producto {  get; set; }

        public int cantidad { get; set; }

        public decimal subtotal {  get; set; }

    }
}
