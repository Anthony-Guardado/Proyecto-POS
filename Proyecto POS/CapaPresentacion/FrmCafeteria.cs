using System;
using System.Windows.Forms;
using Proyecto_POS.CapaPresentacion;
using Proyecto_POS.Pruebas;

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
            Close();
        }

        private void BtnVentaRapida_Click(object sender, EventArgs e)
        {
            FrmRegistrarVenta frm = new FrmRegistrarVenta();
            //muestro el formulario
            frm.ShowDialog();
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

        private void BtnClientes_Click(object sender, EventArgs e)
        {
            //Creo una instancia del formulario FrmClientes
            FrmCliente2 frm = new FrmCliente2();
            //muestro el formulario
            frm.ShowDialog();
        }
    }

   
}

