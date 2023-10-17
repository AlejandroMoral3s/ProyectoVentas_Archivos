using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoDeVentas
{
    public class productosObj
    {

        public int id_producto {  get; set; }
        
        public int id_iva {  get; set; }

        public string nombre_producto { get; set; }

        public float precio {  get; set; }

        public string nota { get; set; }

    }
}
