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

namespace SistemaVentas.VISTA.UsuarioRolVistas
{
    public partial class UsuarioRolInsertarVistas : Form
    {
        public UsuarioRolInsertarVistas()
        {
            InitializeComponent();
        }
        UsuarioRolBss bss = new UsuarioRolBss();
        private void button1_Click(object sender, EventArgs e)
        {
            UsuarioRol ur = new UsuarioRol();
            ur.IdUsuario = Convert.ToInt32(txtIdUsuario.Text);
            ur.IdRol = Convert.ToInt32(txtIdRol.Text);
            ur.FechaAsigna = DateTime.Parse(txtFechaAsigna.Text);
        }
    }
}
