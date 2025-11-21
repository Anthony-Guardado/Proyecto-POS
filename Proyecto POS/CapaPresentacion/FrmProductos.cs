using Proyecto_POS.CapaEntidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_POS.CapaPresentacion
{
    public partial class FrmProductos : Form
    {
        public FrmProductos()
        {
            InitializeComponent();
        }

        private const string V = "Café Borbon";

        /// <summary>
        //Creacion de una lista estatica que simalara la Db
        public static List<Producto> listaProductos = new List<Producto>();
        private readonly object dgvProductos;

        public object ListaProductos { get; private set; }
        public object MenssageBoxButtons { get; private set; }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void chkEstado_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void habilitarBotones()
        {
            BtnModificar.Enabled = true;
            BtnEliminar.Enabled = true;
            BtnLimpiarCampo.Enabled = true;
            BtnNuevo.Enabled = false;

        }
        private void DeshabilitarBotones()
        {
            BtnModificar.Enabled = false;
            BtnEliminar.Enabled = false;
            BtnLimpiarCampo.Enabled = false;
            BtnNuevo.Enabled = true;

        }
        private void FrmProductos_Load(object sender, EventArgs e)
        {
            DeshabilitarBotones();
            //Vamos a cargar los datos iniciales
            if (!listaProductos.Any())
            {
                listaProductos.Add(new Producto
                {
                    Id = 1,
                    Nombre = "Café Gurmet",
                    Descripcion = "Importado",
                    Precio = 10.5m,
                    Stock = 100,
                    Estado = true
                });
                listaProductos.Add(new Producto { Id = 2, Nombre = "Café Borbon", Descripcion = "De Altura", Precio = 20.0m, Stock = 50, Estado = true });
                listaProductos.Add(new Producto { Id = 3, Nombre = "Cheescake", Descripcion = "Dulce Sabor", Precio = 15.75m, Stock = 75, Estado = true });
            }
            RefrescarGrid();//mando a llamar el metdo ara refrescar el datagridview

        }
        //Asignar la lista como Data50urce al datagriview
        private void RefrescarGrid()
        {
            DgvProductos.DataSource = null;//Limpiar el dataSource antes de realizarlo
            DgvProductos.DataSource = listaProductos;//Asignar la lista como DataSource
        }

        //Boton Guardar
        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            //Validaciones Basicas
            if (string.IsNullOrWhiteSpace(TxtNombre.Text))
            {
                MessageBox.Show("El nombre del producto es obligatorio.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }//valida que el precio ingresado sea un decimal
            if (!Validaciones.EsDecimal(TxtPrecio.Text))
            {
                MessageBox.Show("El precio del producto debe ser un valor numerico.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtPrecio.Focus();
                return;
            }
            if (!Validaciones.EsEntero(TxtStock.Text))
            {
                MessageBox.Show("El stock del producto debe ser un valor entero.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtStock.Focus();
                return;
            }
            //Crear objeto producto y asignar Id incrementable manualmente
            //Crear un nuevo producto
            Producto nuevoProducto = new Producto
            {
                Id = listaProductos.Any() ? listaProductos.Max(p => p.Id) + 1 : 1,
                Nombre = TxtNombre.Text.Trim(),
                Descripcion = TxtDescripcion.Text.Trim(),
                Precio = decimal.Parse(TxtPrecio.Text.Trim()),
                Stock = int.Parse(TxtStock.Text.Trim()),
                Estado = chkEstado.Checked
            };
            //Agregar el nuevo producto a la lista
            listaProductos.Add(nuevoProducto);
            //Refrescar el datagridview para mostrar el nuevo producto
            RefrescarGrid();
            //Limpiar los controles
            LimpiarCampos();
            habilitarBotones();
        }
        //Limpiar los campos del formulario
        private void LimpiarCampos()
        {
            TxtNombre.Clear();
            TxtDescripcion.Clear();
            TxtPrecio.Clear();
            TxtStock.Clear();
            chkEstado.Checked = true;
        }

        private void BtnLimpiarCampo_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            //Evento para eliinar un producto
            if (!int.TryParse(TxtId.Text, out int Id))
            {
                MessageBox.Show("Selecione un producto válido para eliminar.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var prod = listaProductos.FirstOrDefault(x => x.Id == Id);
            if (prod == null)
            {
                MessageBox.Show("Producto no encontrado.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (MessageBox.Show("¿Está seguro de eliminar el producto seleccionado?", "Confirmar eliminación",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                listaProductos.Remove(prod);
                RefrescarGrid();
                LimpiarCampos();
                DeshabilitarBotones();
               
            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            //Evento para eliinar un producto
            if (!int.TryParse(TxtId.Text, out int Id))
            {
                MessageBox.Show("Selecione un producto válido para eliminar.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var prod = listaProductos.FirstOrDefault(x => x.Id == Id);
            if (prod == null)
            {
                MessageBox.Show("Producto no encontrado.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //Validaciones identicas ala del boton guardar
            if (string.IsNullOrWhiteSpace(TxtNombre.Text))
            {
                MessageBox.Show("El nombre del producto es obligatorio.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtNombre.Focus();
                return;
            }//valida que el precio ingresado sea un decimal
            if (!Validaciones.EsDecimal(TxtPrecio.Text))
            {
                MessageBox.Show("El precio del producto debe ser un valor .", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtPrecio.Focus();
                return;
            }
            if (!Validaciones.EsEntero(TxtStock.Text))
            {
                MessageBox.Show("El stock del producto debe ser un valor entero.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtStock.Focus();
                return;
            }
            //Actalizar los campos en memoria
            prod.Nombre = TxtNombre.Text.Trim();
            prod.Descripcion = TxtDescripcion.Text.Trim();
            prod.Precio = decimal.Parse(TxtPrecio.Text.Trim());
            prod.Stock = int.Parse(TxtStock.Text.Trim());
            prod.Estado = chkEstado.Checked;
            MessageBox.Show("Producto actualizado correctamente.", "Éxito",
                 MessageBoxButtons.OK, MessageBoxIcon.Information);
            RefrescarGrid();//refrescar el datagridview
            LimpiarCampos();//limpiar los controles
            DeshabilitarBotones();
            
        }

        private void DgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                if (DgvProductos.CurrentRow == null) return;
                //Obtener el producto seleccionado
                TxtId.Text = DgvProductos.CurrentRow.Cells["Id"].Value.ToString();
                TxtNombre.Text = DgvProductos.CurrentRow.Cells["Nombre"].Value.ToString();
                TxtDescripcion.Text = DgvProductos.CurrentRow.Cells["Descripcion"].Value.ToString();
                TxtPrecio.Text = DgvProductos.CurrentRow.Cells["Precio"].Value.ToString();
                TxtStock.Text = DgvProductos.CurrentRow.Cells["Stock"].Value.ToString();
                chkEstado.Checked = (bool)DgvProductos.CurrentRow.Cells["Estado"].Value;
                habilitarBotones();
            }
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void iconDropDownButton1_Click(object sender, EventArgs e)
        {

        }
    }
}

