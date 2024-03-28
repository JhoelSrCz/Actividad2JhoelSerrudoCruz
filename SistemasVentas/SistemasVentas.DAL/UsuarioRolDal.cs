using SistemasVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.DAL
{
    public class UsuarioRolDal
    {
        public DataTable ListarUsuarioRolDal()
        {
            string consulta = "SELECT USUARIOROL.IDUSUARIOROL, (USUARIO.NOMBREUSER +'  /  '+ " +
                                "USUARIO.CONTRASEÑA)USUARIO_Y_CONTRASEÑA, ROL.NOMBRE AS ROL, " +
                                "USUARIOROL.FECHAASIGNA AS FECHA_ASIGNADA, USUARIOROL.ESTADO\r\n" +
                                "FROM     USUARIOROL INNER JOIN\r\n                 " +
                                "USUARIO ON USUARIOROL.IDUSUARIO = USUARIO.IDUSUARIO INNER JOIN\r\n" +
                                "ROL ON USUARIOROL.IDROL = ROL.IDROL";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public void InsertarUsuarioRolDal(UsuarioRol usuarioRol)
        {
            string consulta = "insert into usuariorol values(" + usuarioRol.IdUsuario + "," +
                                                            "" + usuarioRol.IdRol + "," +
                                                            "'" + usuarioRol.FechaAsigna + "'," +
                                                            "'Activo')";
            conexion.Ejecutar(consulta);
        }
    }
}
