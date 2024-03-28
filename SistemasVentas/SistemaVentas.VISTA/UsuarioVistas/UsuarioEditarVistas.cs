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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SistemaVentas.VISTA.UsuarioVistas
{
    public partial class UsuarioEditarVistas : Form
    {
        int idx = 0;
        Usuario p = new Usuario();
        UsuarioBss bss = new UsuarioBss();
        public UsuarioEditarVistas(int id)
        {
            idx = id;
            InitializeComponent();
        }

        private void UsuarioEditarVistas_Load(object sender, EventArgs e)
        {
            p = bss.ObtenerUsuarioIdBss(idx);
            txtIdPersona.Text = p.IdPersona.ToString();
            txtNombreUser.Text = p.NombreUser;
            txtContraseña.Text = p.Contraseña;
            dateTimePicker1.Value = p.FechaReg;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            p.IdPersona = IdPersonaSeleccionada;
            p.NombreUser = txtNombreUser.Text;
            p.Contraseña = txtContraseña.Text;
            p.FechaReg = dateTimePicker1.Value;
            bss.EditarUsuarioBss(p);
            MessageBox.Show("Datos Actualizados");
        }
        public static int IdPersonaSeleccionada = 0;
        PersonaBss bssper = new PersonaBss();

        private void button3_Click(object sender, EventArgs e)
        {
            PersonaListarVista fr = new PersonaListarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Persona persona = bssper.ObtenerIdBss(IdPersonaSeleccionada);
                txtNombreUser.Text = persona.Nombre + " " + persona.Apellido;
            }
        }
    }
}
