using SistemasVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.DAL
{
    public class ClienteDal
    {
        Cliente cliente1 = new Cliente();
        public DataTable ListarClienteDal()
        {
            string consulta = "SELECT CLIENTE.IDCLIENTE, (PERSONA.NOMBRE +' '+ PERSONA.APELLIDO)NOMBRE_COMPLETO, " +
                                    "CLIENTE.TIPOCLIENTE, CLIENTE.CODIGOCLIENTE, CLIENTE.ESTADO\r\n" +
                                    "FROM     CLIENTE INNER JOIN\r\n" +
                                    "PERSONA ON CLIENTE.IDPERSONA = PERSONA.IDPERSONA";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public void InsertarClienteDal(Cliente cliente)
        {
            string consulta = "insert into cliente values(" + cliente.IdPersona + "," +
                                                            "'" + cliente.TipoCliente + "'," +
                                                            "'" + cliente.CodigoClie + "'," +
                                                            "'Activo')";
            conexion.Ejecutar(consulta);
        }
        public Cliente ObtenerClienteId(int id)
        {
            string consulta = "select * from cliente where idcliente=" + id;
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "asdas");
            if (tabla.Rows.Count > 0)
            {
                cliente1.IdCliente = Convert.ToInt32(tabla.Rows[0]["idcliente"]);
                cliente1.IdPersona = Convert.ToInt32(tabla.Rows[0]["idpersona"]);
                cliente1.TipoCliente = tabla.Rows[0]["tipocliente"].ToString();
                cliente1.CodigoClie = tabla.Rows[0]["codigocliente"].ToString();
                cliente1.Estado = tabla.Rows[0]["estado"].ToString();

            }
            return cliente1;
        }
        public void EditarClienteDal(Cliente cliente)
        {
            string consulta = "update cliente set idpersona=" + cliente.IdPersona + "," +
                                                        "tipocliente='" + cliente.TipoCliente + "'," +
                                                        "codigocliente='" + cliente.CodigoClie + "'" +
                                                "where idcliente=" + cliente.IdCliente;
            conexion.Ejecutar(consulta);
        }
        public void EliminarClienteDal(int id)
        {
            string consulta = "delete from cliente where idcliente=" + id;
            conexion.Ejecutar(consulta);
        }
    }
}
