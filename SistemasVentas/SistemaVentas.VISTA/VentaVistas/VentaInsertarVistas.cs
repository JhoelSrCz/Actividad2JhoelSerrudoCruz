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

namespace SistemaVentas.VISTA.VentaVistas
{
    public partial class VentaInsertarVistas : Form
    {
        public VentaInsertarVistas()
        {
            InitializeComponent();
        }
        VentaBss bss = new VentaBss();
        private void button1_Click(object sender, EventArgs e)
        {
            Venta v = new Venta();
            v.IdCliente = Convert.ToInt32(txtIdCliente.Text);
            v.IdVendedor = Convert.ToInt32(txtIdVendedor.Text);
            v.Fecha = DateTime.Parse(txtFecha.Text);
            v.Total = Convert.ToDecimal(txtTotal.Text);
        }
    }
}
