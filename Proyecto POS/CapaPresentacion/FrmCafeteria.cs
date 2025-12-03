using Proyecto_POS.CapaEntidades;
using Proyecto_POS.CapaPresentacion;
using Proyecto_POS.Pruebas;
using System;
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
            Close();
            FrmLogin frm = new FrmLogin();
            //muestro el formulario
            frm.Show();
            
        }

        private void BtnVentaRapida_Click(object sender, EventArgs e)
        {
            FrmRegistrarVenta frm = new FrmRegistrarVenta();
            //muestro el formulario
            frm.Show();
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

        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = $"Usuario: {SesionActual.NombreUsuario} - Rol: {SesionActual.Rol}";
            /// Control básico por rol
//Con este codigo deshabilitamos un botón de prueba para el usuario cajero, por ejemplo que no pueda Registrar Cliente(ojo esto es solo prueba)
            switch (SesionActual.Rol)
            {
                case "Admin":
                    // todo habilitado
                    break;
                case "Cajero":
                    BtnClientes.Enabled = false;
                    btnUsuarios.Enabled = false;
                    break;
                default:
                    BtnClientes.Enabled = false;
                    btnUsuarios.Enabled = false;
                    break;

            }


        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            FrmUsuarios frm = new FrmUsuarios();
            frm.ShowDialog();

        }

        private void cambiarClaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            FrmCambiarClave frm = new FrmCambiarClave();
            frm.ShowDialog();
            

        }

        private void lblUsuario_Click(object sender, EventArgs e)
        {

        }

        private void MenuSuperior_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void BtnGenerarReporte_Click(object sender, EventArgs e)
        {
            FrmReporteVentas frm = new FrmReporteVentas();
            frm.ShowDialog();

        }
    }

   
}

