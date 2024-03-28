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

namespace SistemaVentas.VISTA.ProveeVistas
{
    public partial class ProveeInsertarVistas : Form
    {
        public ProveeInsertarVistas()
        {
            InitializeComponent();
        }
        ProveeBss bss = new ProveeBss();
        private void button1_Click(object sender, EventArgs e)
        {
            Provee pv = new Provee();
            pv.IdProducto = Convert.ToInt32(txtIdProducto);
            pv.IdProveedor = Convert.ToInt32(txtProveedor);
            pv.Fecha = DateTime.Parse(txtFecha.Text);
            pv.Precio = Convert.ToDecimal(txtPrecio.Text);  

            bss.InsertarProveeBss (pv);

            MessageBox.Show("Se guardo correctamente");
        }
    }
}
