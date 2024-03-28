using SistemasVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.DAL
{
    public class ProductoDal
    {
        public DataTable ListarProductoDal()
        {
            string consulta = "SELECT PRODUCTO.IDPRODUCTO, TIPOPROD.NOMBRE AS TIPO_PRODUCTO, " +
                                "MARCA.NOMBRE AS MARCA, PRODUCTO.NOMBRE AS PRODUCTO, PRODUCTO.CODIGOBARRA, " +
                                "PRODUCTO.UNIDAD, PRODUCTO.DESCRIPCION, PRODUCTO.ESTADO\r\n" +
                                "FROM     PRODUCTO INNER JOIN\r\n                  " +
                                "TIPOPROD ON PRODUCTO.IDTIPOPROD = TIPOPROD.IDTIPOPROD INNER JOIN\r\n" +
                                "MARCA ON PRODUCTO.IDMARCA = MARCA.IDMARCA";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public void InsertarProductoDal(Producto producto)
        {
            string consulta = "insert into producto values(" + producto.IdTipoProducto + "," +
                                                            "" + producto.IdMarca + "," +
                                                            "'" + producto.Nombre + "'," +
                                                            "'" + producto.CodigoBarra + "'," +
                                                            "" + producto.Unidad + "," +
                                                            "'" + producto.Descripcion + "'," +
                                                            "'Activo')";
            conexion.Ejecutar(consulta);
        }
    }
}
