<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" EnableEventValidation="false" Inherits="Lab4_PrimeraParte.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        <asp:GridView ID="gridDetalle_Factura" runat="server" 
            AutoGenerateColumns="False" 
            CellPadding="3" 
            DataKeyNames="idFactura" 
            OnRowDataBound="gridDetalle_Factura_RowDataBound"
            OnSelectedIndexChanged="gridDetalle_Factura_SelectedIndexChanged"
            GridLines="Vertical" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px">
            <AlternatingRowStyle BackColor="#DCDCDC" />
            <Columns>
                    <asp:BoundField DataField="idFactura" HeaderText="Código Factura" />
                    <asp:BoundField DataField="numLinea" HeaderText="Número de Caja" />
                    <asp:BoundField DataField="codProducto" HeaderText="Código Producto" />
                    <asp:BoundField DataField="detProducto" HeaderText="Detalle" />
                    <asp:BoundField DataField="canProducto" HeaderText="Cantitdad" />
                    <asp:BoundField DataField="costUnitario" HeaderText="Costo Unitario" />
                    <asp:BoundField DataField="totalLinea" HeaderText="Total" />
                </Columns>
            <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
            <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
            <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
            <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#0000A9" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#000065" />
        </asp:GridView>
        </div>
        <br />
        <br />
        <table>
            <tr>
                <td>Código Factura</td>
                <td><asp:TextBox ID="txtid_cod" runat="server" /></td>
            </tr>
            <tr>
                <td>Número de Caja</td>
                <td><asp:TextBox ID="txtnum_caja" runat="server" /></td>
            </tr>
            <tr>
                <td>Código Producto</td>
                <td><asp:TextBox ID="txtcod_producto" runat="server" /></td>
            </tr>
            <tr>
                <td>Detalle</td>
                <td><asp:TextBox ID="txtdetalle" runat="server" /></td>
            </tr>
            <tr>
                <td>Cantidad</td>
                <td><asp:TextBox ID="txtcantidad" runat="server" /></td>
            </tr>
            <tr>
                <td>Costo Unitario</td>
                <td><asp:TextBox ID="txtcosto" runat="server" /></td>
            </tr>
            <tr>
                <td>Total</td>
                <td><asp:TextBox ID="txttotal" runat="server" /></td>
            </tr>
        </table>
    </form>
</body>
</html>
