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

namespace SistemaVentas.VISTA.DetalleIngVistas
{
    public partial class DetalleIngInsertarVistas : Form
    {
        public DetalleIngInsertarVistas()
        {
            InitializeComponent();
        }
        DetalleIngBss bss = new DetalleIngBss();
        private void button1_Click(object sender, EventArgs e)
        {
            Detalleing di = new Detalleing();
            di.IdIngreso = Convert.ToInt32(txtIdIngreso.Text);
            di.IdProducto = Convert.ToInt32(txtIdProducto.Text);
            di.FechaVenc = DateTime.Parse(txtFechaVenc.Text);
            di.Cantidad = Convert.ToInt32(txtCantidad.Text);
            di.PrecioCosto = Convert.ToDecimal(txtPrecioCosto.Text);
            di.PrecioVenta = Convert.ToDecimal(txtPrecioVenta.Text);
            di.SubTotal = Convert.ToDecimal(txtSubTotal.Text);

            bss.InsertarDetalleIngBss(di);

            MessageBox.Show("Se guardo correctamente");
        }
    }
}
