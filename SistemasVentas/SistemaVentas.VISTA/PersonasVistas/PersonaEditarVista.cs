using SistemasVentas.BSS;
using SistemasVentas.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVentas.VISTA.PersonasVistas
{
    public partial class PersonaEditarVista : Form
    {
        int idx = 0;
        Persona p = new Persona();
        PersonaBss bss = new PersonaBss();
        public PersonaEditarVista(int id)
        {
            idx = id;
            InitializeComponent();
        }

        private void PersonaEditarVista_Load(object sender, EventArgs e)
        {
            p = bss.ObtenerIdBss(idx);
            txtNombre.Text = p.Nombre;
            txtApellido.Text = p.Apellido;
            txtTelefono.Text = p.Telefono;
            txtCi.Text = p.Ci;
            txtCorreo.Text = p.Correo;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            p.Nombre = txtNombre.Text;
            p.Apellido = txtApellido.Text;
            p.Telefono = txtTelefono.Text;
            p.Ci = txtCi.Text;
            p.Correo = txtCorreo.Text;

            bss.EditarPersonaBss(p);

            MessageBox.Show("Datos actualizados");
        }
    }
}
