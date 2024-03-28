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

namespace SistemaVentas.VISTA.IngresoVistas
{
    public partial class IngresoInsertarVistas : Form
    {
        public IngresoInsertarVistas()
        {
            InitializeComponent();
        }
        IngresoBss bss = new IngresoBss();
        private void button1_Click(object sender, EventArgs e)
        {
            Ingreso i = new Ingreso();
            i.IdProveedor = Convert.ToInt32(txtIdProveedor.Text);
            i.FechaIngreso = DateTime.Parse(txtFechaIngreso.Text);
            i.Total = Convert.ToDecimal(txtTotal.Text);

            bss.InsertarIngresoBss(i);

            MessageBox.Show("Se guardo correctamente");

        }
    }
}
