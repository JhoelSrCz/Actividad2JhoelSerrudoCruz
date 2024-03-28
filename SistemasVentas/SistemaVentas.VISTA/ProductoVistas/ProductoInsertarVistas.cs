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

namespace SistemaVentas.VISTA.ProductoVistas
{
    public partial class ProductoInsertarVistas : Form
    {
        public ProductoInsertarVistas()
        {
            InitializeComponent();
        }
        ProductoBss bss = new ProductoBss();
        private void button1_Click(object sender, EventArgs e)
        {
            Producto pd = new Producto();
            pd.IdTipoProducto = Convert.ToInt32(txtIdTipoProd.Text);
            pd.IdMarca = Convert.ToInt32(txtIdMarca.Text);
            pd.Nombre = txtNombre.Text;
            pd.CodigoBarra = txtCodigoBarra.Text;
            pd.Unidad = Convert.ToInt32(txtUnidad.Text);
            pd.Descripcion = txtDescripcion.Text;

            bss.InsertarProductoBss(pd);

            MessageBox.Show("Se guardo correctamente");
        }
    }
}
