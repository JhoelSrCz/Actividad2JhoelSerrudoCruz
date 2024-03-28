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

namespace SistemaVentas.VISTA.TipoProdVistas
{
    public partial class TipoProdInsertarVistas : Form
    {
        public TipoProdInsertarVistas()
        {
            InitializeComponent();
        }
        TipoProdBss bss = new TipoProdBss();
        private void button1_Click(object sender, EventArgs e)
        {
            TipoProd t = new TipoProd();
            t.Nombre = txtNombre.Text;

            bss.InsertarTipoProdBss(t);

            MessageBox.Show("Se guardo correctamente");
        }
    }
}
