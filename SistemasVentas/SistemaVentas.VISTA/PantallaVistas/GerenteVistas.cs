using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVentas.VISTA.PantallaVistas
{
    public partial class GerenteVistas : Form
    {
        public GerenteVistas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UsuarioVistas user = new UsuarioVistas();
            user.Show();
        }
    }
}
