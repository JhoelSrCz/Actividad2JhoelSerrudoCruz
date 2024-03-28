using SistemasVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.DAL
{
    public class UsuarioDal
    {
        public UsuarioDal() { }
        public DataTable ListarUsuarioDal()
        {
            string consulta = "SELECT USUARIO.IDUSUARIO, (PERSONA.NOMBRE +' '+ PERSONA.APELLIDO)NOMBRE_COMPLETO, " +
                                    "USUARIO.NOMBREUSER, USUARIO.CONTRASEÑA, USUARIO.FECHAREG AS FECHA_DE_REGISTRO\r\n" +
                                    "FROM     PERSONA INNER JOIN\r\n                  " +
                                    "USUARIO ON PERSONA.IDPERSONA = USUARIO.IDPERSONA";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public void InsertarUsuarioDal(Usuario usuario)
        {
            string consulta = "insert into usuario values(" + usuario.IdPersona +
                                                            "','" + usuario.NombreUser +
                                                            "','" + usuario.Contraseña + 
                                                            "','" + usuario.FechaReg + "')";
            conexion.Ejecutar(consulta);
        }
        Usuario usuario1 = new Usuario();
        public Usuario ObtenerUsuarioIdDal(int id)
        {
            string consulta = "select * from usuario where idusuario=" + id;
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "asdas");
            if (tabla.Rows.Count > 0)
            {
                usuario1.IdUsuario = Convert.ToInt32(tabla.Rows[0]["idusuario"]);
                usuario1.IdPersona = Convert.ToInt32(tabla.Rows[0]["idpersona"]);
                usuario1.NombreUser = tabla.Rows[0]["nombreuser"].ToString();
                usuario1.Contraseña = tabla.Rows[0]["contraseña"].ToString();
                usuario1.FechaReg = Convert.ToDateTime(tabla.Rows[0]["fechareg"]);
            }
            return usuario1;
        }
        public void EditarUsuarioDal(Usuario usuario)
        {
            string consulta = "update usuario set idpersona=" + usuario.IdPersona + "," +
                                                        "nombreuser='" + usuario.NombreUser + "'," +
                                                        "contraseña='" + usuario.Contraseña + "'," +
                                                        "fechareg='" + usuario.FechaReg + "' " +
                                                "where idusuario=" + usuario.IdUsuario;
            conexion.Ejecutar(consulta);
        }
        public void EliminarUsuarioDal(int id)
        {
            string consulta = "delete from usuario where idusuario=" + id;
            conexion.Ejecutar(consulta);
        }
    }
}
