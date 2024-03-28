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

namespace SistemaVentas.VISTA.ProveedorVistas
{
    public partial class ProveedorInsertarVistas : Form
    {
        public ProveedorInsertarVistas()
        {
            InitializeComponent();
        }
        ProveedorBss bss = new ProveedorBss();  
        private void button1_Click(object sender, EventArgs e)
        {
            Proveedor p = new Proveedor();
            p.Nombre = txtNombre.Text;
            p.Telefono = txtTelefono.Text; 
            p.Direccion = txtDireccion.Text;

            bss.InsertarPorveedorBss(p);

            MessageBox.Show("Seguardo correctamente");
        }
    }
}
