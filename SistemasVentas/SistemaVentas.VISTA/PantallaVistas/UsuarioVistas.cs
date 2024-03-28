using SistemasVentas.BSS;
using SistemaVentas.VISTA.PersonasVistas;
using SistemaVentas.VISTA.UsuarioVistas;
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
    public partial class UsuarioVistas : Form
    {
        public UsuarioVistas()
        {
            InitializeComponent();
        }
        UsuarioBss bss = new UsuarioBss();

        private void UsuarioVistas_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarUsuarioBss();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UsuarioInsertarVistas fr = new UsuarioInsertarVistas();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListarUsuarioBss();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int idUsuarioSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            UsuarioEditarVistas fr = new UsuarioEditarVistas(idUsuarioSeleccionado);
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListarUsuarioBss();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int IdPersonaSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DialogResult result = MessageBox.Show("¿Esta seguro de Eliminar esta Usuario?", "Eliminando", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                bss.EliminarUsuarioBss(IdPersonaSeleccionada);
                dataGridView1.DataSource = bss.ListarUsuarioBss();
            }
        }
    }
}
