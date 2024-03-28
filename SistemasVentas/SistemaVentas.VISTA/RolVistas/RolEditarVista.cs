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

namespace SistemaVentas.VISTA.RolVistas
{
    public partial class RolEditarVista : Form
    {
        int idx = 0;
        Rol rol = new Rol();
        RolBss bss = new RolBss();
        public RolEditarVista(int id)
        {
            idx = id;
            InitializeComponent();
        }

        private void RolEditarVista_Load(object sender, EventArgs e)
        {
            rol = bss.ObtenerIdBss(idx);
            txtNombre.Text = rol.Nombre;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rol.Nombre = txtNombre.Text;

            bss.EditarRolBss(rol);

            MessageBox.Show("Datos actualizados");
        }
    }
}
