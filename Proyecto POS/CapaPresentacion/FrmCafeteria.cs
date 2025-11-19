using Proyecto_POS.CapaPresentacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_POS
{
    public partial class FrmMenuPrincipal : Form
    {
        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void productoMasVedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {

        }

        private void BtnVentaRapida_Click(object sender, EventArgs e)
        {

        }

        private void BtnProductos_Click(object sender, EventArgs e)
        {
            //Creo una instancia del formulario FrmProductos
            FrmProductos frm = new FrmProductos();
            //muestro el formulario
            frm.ShowDialog();
        }

        private void PanelCentral_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
