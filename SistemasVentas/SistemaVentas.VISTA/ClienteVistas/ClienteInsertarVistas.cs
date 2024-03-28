﻿using SistemasVentas.BSS;
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

namespace SistemaVentas.VISTA.ClienteVistas
{
    public partial class ClienteInsertarVistas : Form
    {
        public ClienteInsertarVistas()
        {
            InitializeComponent();
        }
        ClienteBss bss = new ClienteBss();
        private void button1_Click(object sender, EventArgs e)
        {
            Cliente c = new Cliente();
            c.IdPersona = Convert.ToInt32(txtIdPersona.Text);
            c.TipoCliente = txtTipoCliente.Text;
            c.CodigoClie = txtCodigoCliente.Text;

            bss.InsertarClienteBss(c);

            MessageBox.Show("Se guardo correctamente");
        }
    }
}
