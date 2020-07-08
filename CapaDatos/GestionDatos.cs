using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.Objetos;

namespace CapaDatos
{
    public class GestionDatos
    {
        List<Factura> listadoFac;

        public List<Factura> ListadoFactura()
        {
            listadoFac = new List<Factura>();
            Factura objFac = new Factura();
            objFac = new Factura() { idFactura=0001,numLinea=01,codProducto="LAC_25",detProducto="Leche",canProducto=2,costUnitario=800,totalLinea=1600};
            listadoFac.Add(objFac);
            objFac = new Factura() { idFactura = 0002, numLinea = 01, codProducto = "CNR_05", detProducto = "Chuleta", canProducto = 1, costUnitario = 1800, totalLinea = 1800 };
            listadoFac.Add(objFac);
            objFac = new Factura() { idFactura = 0003, numLinea = 02, codProducto = "VRD_18", detProducto = "Yuca", canProducto = 2, costUnitario = 650, totalLinea = 1300 };
            listadoFac.Add(objFac);
            objFac = new Factura() { idFactura = 0004, numLinea = 02, codProducto = "LAC_16", detProducto = "Helado vainilla chips", canProducto = 40, costUnitario = 800, totalLinea = 32000 };
            listadoFac.Add(objFac);
            return listadoFac;
        }
    }
}
