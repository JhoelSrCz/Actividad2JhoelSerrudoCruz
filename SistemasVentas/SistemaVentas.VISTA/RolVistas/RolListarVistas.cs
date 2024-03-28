using SistemasVentas.BSS;
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
    public partial class RolListarVistas : Form
    {
        public RolListarVistas()
        {
            InitializeComponent();
        }
        RolBss bss = new RolBss();
        private void RolListarVistas_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarRolBss();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RolInsertarVistas.IdRolSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RolInsertarVistas fr = new RolInsertarVistas();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListarRolBss();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int IdRolSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            RolEditarVista fr = new RolEditarVista(IdRolSeleccionado);
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListarRolBss();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int IdRolSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DialogResult result = MessageBox.Show("Esta seguro de eliminar", "ELIMINANDO", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                bss.EliminarRolBss(IdRolSeleccionado);
                dataGridView1.DataSource = bss.ListarRolBss();
            }
        }
    }
}
