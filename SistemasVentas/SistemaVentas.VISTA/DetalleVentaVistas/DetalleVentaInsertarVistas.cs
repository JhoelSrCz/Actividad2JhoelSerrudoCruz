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

namespace SistemaVentas.VISTA.DetalleVentaVistas
{
    public partial class DetalleVentaInsertarVistas : Form
    {
        public DetalleVentaInsertarVistas()
        {
            InitializeComponent();
        }
        DetalleVentaBss bss = new DetalleVentaBss();
        private void button1_Click(object sender, EventArgs e)
        {
            DetalleVenta dv = new DetalleVenta();
            dv.IdVenta = Convert.ToInt32(txtIdVenta.Text);
            dv.IdProducto = Convert.ToInt32(txtIdProducto.Text);
            dv.Cantidad = Convert.ToInt32(txtCantidad.Text);
            dv.PrecioVenta = Convert.ToDecimal(txtPrecioVenta.Text);
            dv.SubTotal = Convert.ToDecimal(txtSubTotal.Text);

            bss.InsertarDetalleVentaBss(dv);

            MessageBox.Show("Se guardo correctamente");
        }
    }
}
