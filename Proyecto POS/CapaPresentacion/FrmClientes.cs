using Proyecto_POS.CapaEntidades;
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
    public partial class FrmClientes : Form
    {
        public FrmClientes()
        {
            InitializeComponent();
        }
        //Creacion de una lista estatica que simalara la Db
        public static List<Cliente> listaClientes = new List<Cliente>();
        private readonly object dgvClientes;

        public object ListaClientes { get; private set; }

        public object MenssageBoxButtons { get; private set; }
        public object MensageBox { get; private set; }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void chkEstado_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label_Click(object sender, EventArgs e)
        {

        }


        private void habilitarBotones()
        {
            BtnModificar.Enabled = true;
            BtnElminar.Enabled = true;
            BtnLimpiarCampo.Enabled = true;
            BtnNuevo.Enabled = false;

        }
        private void DeshabilitarBotones()
        {
            BtnModificar.Enabled = false;
            BtnElminar.Enabled = false;
            BtnLimpiarCampo.Enabled = false;
            BtnNuevo.Enabled = true;

        }
        private void FrmClientes_Load(object sender, EventArgs e)
            
        {
            DeshabilitarBotones();
            //Vamos a cargar los datos iniciales
            if (!listaClientes.Any())
            {
                listaClientes.Add(new Cliente
                {
                    Id = 1,
                    Nombre = "Anthony",
                     Dui = 23456789,
                     Email = "anthonyelmago@.com",
                    Telefono = 72901221,
                    Estado = true
                });
                listaClientes.Add(new Cliente
                {
                    Id = 2,
                    Nombre = "Stiven",
                   Dui = 87654321,
                     Email = "stivenmago@.com",
                    Telefono = 71881808,
                    Estado = true
                });
                listaClientes.Add(new Cliente
                {
                    Id = 3,
                    Nombre = "Graciela",
                   Dui = 12345678,
                   Email = "anthonielmago@.com",    
                    Telefono = 60357572,
                    Estado = true
                });
            }
            RefrescarGrid();//mando a llamar el metdo ara refrescar el datagridview
        }

        private void RefrescarGrid()
        {
            DgvClientes.DataSource = null;//Limpiar el dataSource antes de realizarlo
            DgvClientes.DataSource = listaClientes;//Asignar la lista como DataSource
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            //Validaciones Basicas

            if (string.IsNullOrWhiteSpace(TxtNombre.Text.Trim()))
            {
                MessageBox.Show("Ingrese el nombre del cliente es obligatorio", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtNombre.Focus();
                return;
            }
            if(!Validaciones.EsEntero(TxtDui.Text))
            {
                MessageBox.Show("El dui del cliente debe ser escrito con numeros y sin guion.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtDui.Focus();
                return;
            }
            if (!Validaciones.EsEntero(TxtTelefono.Text))
            {
                MessageBox.Show("El telefono del cliente debe ser escrito con numeros.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtTelefono.Focus();
                return;
            }
            if (!Validaciones.EsCorreoValido(TxtEmail.Text))
            {
                MessageBox.Show("El correo electronico no es valido.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtEmail.Focus();
                return;
            }
            //Crear objeto cliente y asignar Id incrementable manualmente
            //Crear un nuevo cliente
            Cliente nuevoCliente = new Cliente
            {
                Id = listaClientes.Any() ? listaClientes.Max(x => x.Id) + 1 : 1,
                Nombre = TxtNombre.Text.Trim(),
               Dui = Convert.ToInt32(TxtDui.Text.Trim()),
                Email = TxtEmail.Text.Trim(),
                Telefono = Convert.ToInt32(TxtTelefono.Text.Trim()),
                Estado = ChkEstado.Checked
            };
            //Agregar el nuevo cliente a la lista
            listaClientes.Add(nuevoCliente);
            //Refrescar el datagridview para mostrar el nuevo cliente
            RefrescarGrid();
            //Limpiar los controles
            LimpiarCampos();
            habilitarBotones();
        }
        //Limpiar los campos del formulario
        private void LimpiarCampos()
        {
            TxtNombre.Clear();
            TxtDui.Clear();
            TxtEmail.Clear();
            TxtTelefono.Clear();
            ChkEstado.Checked = true;
        }

        private void BtnLimpiarCampo_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void BtnElminar_Click(object sender, EventArgs e)
        {
            DeshabilitarBotones();
            //Evento para eliinar un cliente
            if (!int.TryParse(TxtId.Text, out int Id))
            {
                MessageBox.Show("Selecione un cliente válido para eliminar.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var client = listaClientes.FirstOrDefault(x => x.Id == Id);
            if (client == null)
            {
                MessageBox.Show("Cliente no encontrado.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (MessageBox.Show("¿Está seguro de eliminar el cliente seleccionado?", "Confirmar eliminación",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                listaClientes.Remove(client);
                RefrescarGrid();
                LimpiarCampos();
            }

        }

        private void DgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            {
               if (e.RowIndex >= 0)
               {
                   DataGridViewRow row = DgvClientes.Rows[e.RowIndex];
                    TxtId.Text = row.Cells["Id"].Value.ToString();
                    TxtNombre.Text = row.Cells["Nombre"].Value.ToString();
                    TxtDui.Text = row.Cells["Dui"].Value.ToString();
                    TxtEmail.Text = row.Cells["Email"].Value.ToString();
                    TxtTelefono.Text = row.Cells["Telefono"].Value.ToString();
                    ChkEstado.Checked = Convert.ToBoolean(row.Cells["Estado"].Value);
                }
            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            DeshabilitarBotones();
            //Evento para eliinar un cliente
            if (!int.TryParse(TxtId.Text, out int Id))
            {
                MessageBox.Show("Selecione un cliente válido para eliminar.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var client = listaClientes.FirstOrDefault(x => x.Id == Id);
            if (client == null)
            {
                MessageBox.Show("Cliente no encontrado.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //Validaciones identicas ala del boton guardar
            if (string.IsNullOrWhiteSpace(TxtNombre.Text.Trim()))
            {
                MessageBox.Show("Ingrese el nombre del cliente es obligatorio", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtNombre.Focus();
                return;
            }
            if (!Validaciones.EsEntero(TxtDui.Text))
            {
                MessageBox.Show("El dui del cliente debe ser modificado con numeros y sin guion.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtDui.Focus();
                return;
            }
            if (!Validaciones.EsEntero(TxtTelefono.Text))
            {
                MessageBox.Show("El telefono del cliente debe ser modificado con numeros.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtTelefono.Focus();
                return;
            }
            if (!Validaciones.EsCorreoValido(TxtEmail.Text))
            {
                MessageBox.Show("El correo electronico no es valido.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtEmail.Focus();
                return;
            }


            //Actalizar los campos en memoria
            client.Id = int.Parse(TxtId.Text.Trim());
            client.Nombre = TxtNombre.Text.Trim();
            client.Email = TxtEmail.Text.Trim();
            client.Dui = int.Parse(TxtDui.Text.Trim());
            client.Telefono = int.Parse(TxtTelefono.Text.Trim());
            client.Estado = ChkEstado.Checked;
            MessageBox.Show("Cliente actualizado exitosamente.", "Éxito",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            RefrescarGrid();//refrescar el datagridview
            //limpiar los controles
            LimpiarCampos();
        }
        

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TxtDui_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
