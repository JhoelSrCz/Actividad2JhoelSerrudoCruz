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
    public partial class RolInsertarVistas : Form
    {
        public RolInsertarVistas()
        {
            InitializeComponent();
        }
        public static int IdRolSeleccionado = 0;
        RolBss bss = new RolBss();
        private void button1_Click(object sender, EventArgs e)
        {
            Rol rol = new Rol();
            rol.Nombre = txtNombre.Text;

            bss.InsertarRolBss(rol);

            MessageBox.Show("Se guardo correctamente");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RolListarVistas fr = new RolListarVistas();
            if(fr.ShowDialog() == DialogResult.OK)
            {
                Rol rol = bss.ObtenerIdBss(IdRolSeleccionado);
                txtRol.Text = rol.Nombre + " " + rol.IdRol;
            }
        }
    }
}
