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
    public partial class FrmProductos : Form
    {
        public FrmProductos()
        {
            InitializeComponent();
        }

        private const string V = "Café Borbon";

        /// <summary>
        //Creacion de una lista estaica que simalara la Db
        public static List<Producto> listaProductos = new List<Producto>();
        private readonly object dgvProductos;

        public object ListaProductos { get; private set; }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void chkEstado_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void FrmProductos_Load(object sender, EventArgs e)
        {
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
                listaProductos.Add(new Producto { Id = 2, Nombre ="Café Borbon" , Descripcion = "De Altura", Precio = 20.0m, Stock = 50, Estado = true });
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

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            //Validaciones Basicas
            if (string.IsNullOrWhiteSpace(TxtNombre.Text))
            {
                MessageBox.Show("El nombre del producto es obligatorio.", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!Validaciones.EsDecimal(TxtPrecio.Text)) ;
                        {
                MessageBox.Show("El precio del producto debe ser un valor númerico.", "Error",
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
        }
    }
}
