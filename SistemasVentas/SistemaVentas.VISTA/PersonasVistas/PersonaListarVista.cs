using SistemasVentas.BSS;
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

namespace SistemaVentas.VISTA.PersonasVistas
{
    public partial class PersonaListarVista : Form
    {
        public PersonaListarVista()
        {
            InitializeComponent();
        }
        PersonaBss bss = new PersonaBss();

        private void PersonaListarVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarPersonaBss();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            UsuarioInsertarVistas.IdPersonaSelecionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int idPersonaSeleionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DialogResult result = MessageBox.Show("Esta seguro de eliminar esta persona", "Eliminando", MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes)
            {
                bss.EliminarPersonaBss(idPersonaSeleionada);
                dataGridView1.DataSource = bss.ListarPersonaBss();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PersonaInsertarVista fr = new PersonaInsertarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListarPersonaBss();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int idPersonaSeleionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            PersonaEditarVista fr = new PersonaEditarVista(idPersonaSeleionada);
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource= bss.ListarPersonaBss();
            }
        }
    }
}
