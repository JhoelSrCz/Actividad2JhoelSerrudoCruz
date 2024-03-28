using SistemasVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.DAL
{
    public class DetalleVentaDal
    {
        public DataTable ListarDetalleVentaDal()
        {
            string consulta = "SELECT DETALLEVENTA.IDDETALLEVENTA, VENTA.TOTAL AS VENTA, " +
                                "PRODUCTO.NOMBRE AS PRODUCTO, DETALLEVENTA.CANTIDAD, DETALLEVENTA.PRECIOVENTA, DETALLEVENTA.SUBTOTAL, DETALLEVENTA.ESTADO\r\n" +
                                "FROM     DETALLEVENTA INNER JOIN\r\n                  " +
                                "VENTA ON DETALLEVENTA.IDVENTA = VENTA.IDVENTA INNER JOIN\r\n                  " +
                                "PRODUCTO ON DETALLEVENTA.IDPRODUCTO = PRODUCTO.IDPRODUCTO";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public void InsertarDetalleVentaDal(DetalleVenta detalleVenta)
        {
            string consulta = "insert into detalleventa values(" + detalleVenta.IdVenta + "," +
                                                            "" + detalleVenta.IdProducto + "," +
                                                            "" + detalleVenta.Cantidad + "," +
                                                            "" + detalleVenta.PrecioVenta + "," +
                                                            "" + detalleVenta.SubTotal + "," +
                                                            "'Activo')";
            conexion.Ejecutar(consulta);
        }
    }
}
