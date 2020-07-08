using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Objetos
{
    public class Factura
    {
        public int idFactura {get;set;}
        public int numLinea { get; set; }
        public string codProducto { get; set; }
        public string detProducto { get; set; }
        public int canProducto { get; set; }
        public double costUnitario { get; set; }
        public double totalLinea { get; set; }

    }
}
