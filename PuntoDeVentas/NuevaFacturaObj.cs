using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoDeVentas
{
    public class NuevaFacturaObj
    {

        public int id_factura {  get; set; }

        public int id_usuario {  get; set; }

        public string fecha_emision { get; set; }

        public int id_cliente {  get; set; }

        public decimal total_factura { get; set; }

    }
}
