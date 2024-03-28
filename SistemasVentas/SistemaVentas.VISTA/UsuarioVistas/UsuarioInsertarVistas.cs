using SistemasVentas.BSS;
using SistemasVentas.Modelos;
using SistemaVentas.VISTA.PersonasVistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVentas.VISTA.UsuarioVistas
{
    public partial class UsuarioInsertarVistas : Form
    {
        public UsuarioInsertarVistas()
        {
            InitializeComponent();
        }
        public static int IdPersonaSelecionada = 0;
        UsuarioBss bssu = new UsuarioBss();
        PersonaBss bss = new PersonaBss();
        private void button1_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.IdPersona = IdPersonaSelecionada;
            usuario.NombreUser = txtNombreUser.Text;
            usuario.Contraseña = txtContraseña.Text;
            usuario.FechaReg = dateTimePicker1.Value;

            bssu.InsertarUsuarioBss(usuario);

            MessageBox.Show("Usuario Registrado");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PersonaListarVista fr = new PersonaListarVista();
            if(fr.ShowDialog() == DialogResult.OK)
            {
                Persona persona = bss.ObtenerIdBss(IdPersonaSelecionada);
                txtIdPersona.Text = persona.Nombre + " " + persona.Apellido;
            }
        }
    }
}
