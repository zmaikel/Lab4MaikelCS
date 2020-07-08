using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaDatos;
using CapaDatos.Objetos;

namespace Lab4_PrimeraParte
{
    public partial class index : System.Web.UI.Page
    {
        GestionDatos objDB;
        List<Factura> auxlist;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                cargarDatos();
            }
        }
        void cargarDatos()
        {
            objDB = new GestionDatos();
            auxlist = objDB.ListadoFactura();
            gridDetalle_Factura.DataSource = auxlist;
            gridDetalle_Factura.DataBind();
        }
        protected void gridDetalle_Factura_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                e.Row.Attributes["onclick"] = Page.ClientScript.GetPostBackClientHyperlink(gridDetalle_Factura, "Select$" + e.Row.RowIndex);
            }
        }

        protected void gridDetalle_Factura_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (GridViewRow fila in gridDetalle_Factura.Rows)
            {

                if (fila.RowIndex == gridDetalle_Factura.SelectedIndex)
                {
                    txtid_cod.Text = fila.Cells[0].Text; //obtengo el codigo de herramienta
                    txtnum_caja.Text = fila.Cells[1].Text;
                    txtcod_producto.Text = fila.Cells[2].Text;
                    txtdetalle.Text = fila.Cells[3].Text;
                    txtcantidad.Text = fila.Cells[4].Text;
                    txtcosto.Text = fila.Cells[5].Text;
                    txttotal.Text = fila.Cells[6].Text;
                    fila.BackColor = ColorTranslator.FromHtml("#A1DCF2");
                }
                else
                {
                    fila.BackColor = ColorTranslator.FromHtml("#FFFFFF");
                }

            }

            cargarDatos();
        }
    }
    
} 