using Proyecto_POS.CapaEntidades;
using Proyecto_POS.CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_POS.CapaPresentacion
{
    public partial class FrmCliente2 : Form

    {
        int clienteId = 0;
        public FrmCliente2()
        {
            InitializeComponent();
        }
        ClienteBLL bll = new ClienteBLL();
        private void FrmCliente2_Load(object sender, EventArgs e)
        {
            CargarDatos();
            Limpiar();
        }
        void Limpiar()
        {
            TxtNombre.Clear();
            TxtDui.Clear();
            TxtTelefono.Clear();
            TxtCorreo.Clear();
            ChActivo.Checked = true;
            TxtBuscar.Clear();
            TxtNombre.Focus();

            clienteId = 0;

        }
        public void CargarDatos()
        {
            DgvCliente.DataSource = bll.Listar();
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            DgvCliente.DataSource = bll.Buscar(TxtBuscar.Text);
        }

        private void DgvCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                clienteId = Convert.ToInt32(DgvCliente.Rows[e.RowIndex].Cells["Id"].Value);
                TxtNombre.Text = DgvCliente.Rows[e.RowIndex].Cells["NombreCompleto"].Value.ToString();
                TxtDui.Text = DgvCliente.Rows[e.RowIndex].Cells["Dui"].Value.ToString();
                TxtTelefono.Text = DgvCliente.Rows[e.RowIndex].Cells["Telefono"].Value.ToString();
                TxtCorreo.Text = DgvCliente.Rows[e.RowIndex].Cells["Email"].Value.ToString();
                ChActivo.Checked = (bool)DgvCliente.Rows[e.RowIndex].Cells["Estado"].Value;
            }
            
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente2 c = new Cliente2
                {
                    Id = clienteId,
                    NombreCompleto = TxtNombre.Text,
                    Dui = Convert.ToInt32(TxtDui.Text),
                    Telefono = Convert.ToInt32(TxtTelefono.Text),
                    Email = TxtCorreo.Text,
                    Estado = ChActivo.Checked
                };
                int Id = bll.Guardar(c);
                MessageBox.Show("Cliente guardado con exito.", "Notificacion",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarDatos();
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el cliente: " + ex.Message,
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);






            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (clienteId == 0)
            {
                MessageBox.Show("Seleccionar un cliente ara eliminar.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (MessageBox.Show("¿Está seguro de eliminar el cliente seleccionado?", "Confirmación",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bll.Eliminar(clienteId);
                CargarDatos();
                Limpiar();
         }  }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    } 
}


