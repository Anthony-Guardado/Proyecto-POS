namespace Proyecto_POS
{
    partial class FrmMenuPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.MenuSuperior = new System.Windows.Forms.MenuStrip();
            this.gestionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarCategoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verCategoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historialDeVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDiarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productoMasVedidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cierreDeCajaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarClaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PanelIzquierdo = new System.Windows.Forms.Panel();
            this.PanelCentral = new System.Windows.Forms.Panel();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.LogoPOSS = new System.Windows.Forms.PictureBox();
            this.BtnGenerarReporte = new FontAwesome.Sharp.IconButton();
            this.btnUsuarios = new FontAwesome.Sharp.IconButton();
            this.BtnVentaRapida = new FontAwesome.Sharp.IconButton();
            this.BtnProductos = new FontAwesome.Sharp.IconButton();
            this.BtnClientes = new FontAwesome.Sharp.IconButton();
            this.BtnInventario = new FontAwesome.Sharp.IconButton();
            this.BtnCorteCaja = new FontAwesome.Sharp.IconButton();
            this.BtnSalir = new FontAwesome.Sharp.IconButton();
            this.MenuSuperior.SuspendLayout();
            this.PanelIzquierdo.SuspendLayout();
            this.PanelCentral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPOSS)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuSuperior
            // 
            this.MenuSuperior.BackColor = System.Drawing.Color.LightGray;
            this.MenuSuperior.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionToolStripMenuItem,
            this.ventasToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.salirToolStripMenuItem,
            this.cambiarClaveToolStripMenuItem});
            this.MenuSuperior.Location = new System.Drawing.Point(0, 0);
            this.MenuSuperior.Name = "MenuSuperior";
            this.MenuSuperior.Size = new System.Drawing.Size(784, 24);
            this.MenuSuperior.TabIndex = 0;
            this.MenuSuperior.Text = "menuStrip1";
            this.MenuSuperior.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MenuSuperior_ItemClicked);
            // 
            // gestionToolStripMenuItem
            // 
            this.gestionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productosToolStripMenuItem,
            this.categoriasToolStripMenuItem,
            this.clientesToolStripMenuItem});
            this.gestionToolStripMenuItem.Name = "gestionToolStripMenuItem";
            this.gestionToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.gestionToolStripMenuItem.Text = "Gestion";
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarProductosToolStripMenuItem,
            this.verProductoToolStripMenuItem});
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.productosToolStripMenuItem.Text = "Productos";
            // 
            // agregarProductosToolStripMenuItem
            // 
            this.agregarProductosToolStripMenuItem.Name = "agregarProductosToolStripMenuItem";
            this.agregarProductosToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.agregarProductosToolStripMenuItem.Text = "Agregar Productos";
            // 
            // verProductoToolStripMenuItem
            // 
            this.verProductoToolStripMenuItem.Name = "verProductoToolStripMenuItem";
            this.verProductoToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.verProductoToolStripMenuItem.Text = "Ver Producto";
            // 
            // categoriasToolStripMenuItem
            // 
            this.categoriasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarCategoriaToolStripMenuItem,
            this.verCategoriaToolStripMenuItem});
            this.categoriasToolStripMenuItem.Name = "categoriasToolStripMenuItem";
            this.categoriasToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.categoriasToolStripMenuItem.Text = "Categorias";
            // 
            // agregarCategoriaToolStripMenuItem
            // 
            this.agregarCategoriaToolStripMenuItem.Name = "agregarCategoriaToolStripMenuItem";
            this.agregarCategoriaToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.agregarCategoriaToolStripMenuItem.Text = "Agregar Categoria";
            // 
            // verCategoriaToolStripMenuItem
            // 
            this.verCategoriaToolStripMenuItem.Name = "verCategoriaToolStripMenuItem";
            this.verCategoriaToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.verCategoriaToolStripMenuItem.Text = "Ver Categoria";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarClienteToolStripMenuItem,
            this.verClienteToolStripMenuItem});
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // agregarClienteToolStripMenuItem
            // 
            this.agregarClienteToolStripMenuItem.Name = "agregarClienteToolStripMenuItem";
            this.agregarClienteToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.agregarClienteToolStripMenuItem.Text = "Agregar Cliente";
            // 
            // verClienteToolStripMenuItem
            // 
            this.verClienteToolStripMenuItem.Name = "verClienteToolStripMenuItem";
            this.verClienteToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.verClienteToolStripMenuItem.Text = "Ver Cliente";
            // 
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarVentasToolStripMenuItem,
            this.historialDeVentasToolStripMenuItem});
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ventasToolStripMenuItem.Text = "Ventas";
            this.ventasToolStripMenuItem.Click += new System.EventHandler(this.ventasToolStripMenuItem_Click);
            // 
            // registrarVentasToolStripMenuItem
            // 
            this.registrarVentasToolStripMenuItem.Name = "registrarVentasToolStripMenuItem";
            this.registrarVentasToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.registrarVentasToolStripMenuItem.Text = "Registrar Ventas";
            // 
            // historialDeVentasToolStripMenuItem
            // 
            this.historialDeVentasToolStripMenuItem.Name = "historialDeVentasToolStripMenuItem";
            this.historialDeVentasToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.historialDeVentasToolStripMenuItem.Text = "Historial De Ventas";
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reporteDiarioToolStripMenuItem,
            this.productoMasVedidoToolStripMenuItem,
            this.cierreDeCajaToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // reporteDiarioToolStripMenuItem
            // 
            this.reporteDiarioToolStripMenuItem.Name = "reporteDiarioToolStripMenuItem";
            this.reporteDiarioToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.reporteDiarioToolStripMenuItem.Text = "Reporte Diario";
            // 
            // productoMasVedidoToolStripMenuItem
            // 
            this.productoMasVedidoToolStripMenuItem.Name = "productoMasVedidoToolStripMenuItem";
            this.productoMasVedidoToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.productoMasVedidoToolStripMenuItem.Text = "Producto mas Vedido";
            this.productoMasVedidoToolStripMenuItem.Click += new System.EventHandler(this.productoMasVedidoToolStripMenuItem_Click);
            // 
            // cierreDeCajaToolStripMenuItem
            // 
            this.cierreDeCajaToolStripMenuItem.Name = "cierreDeCajaToolStripMenuItem";
            this.cierreDeCajaToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.cierreDeCajaToolStripMenuItem.Text = "Cierre de Caja";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // cambiarClaveToolStripMenuItem
            // 
            this.cambiarClaveToolStripMenuItem.Name = "cambiarClaveToolStripMenuItem";
            this.cambiarClaveToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.cambiarClaveToolStripMenuItem.Text = "Cambiar Clave";
            this.cambiarClaveToolStripMenuItem.Click += new System.EventHandler(this.cambiarClaveToolStripMenuItem_Click);
            // 
            // PanelIzquierdo
            // 
            this.PanelIzquierdo.BackColor = System.Drawing.Color.SandyBrown;
            this.PanelIzquierdo.Controls.Add(this.BtnGenerarReporte);
            this.PanelIzquierdo.Controls.Add(this.btnUsuarios);
            this.PanelIzquierdo.Controls.Add(this.BtnVentaRapida);
            this.PanelIzquierdo.Controls.Add(this.BtnProductos);
            this.PanelIzquierdo.Controls.Add(this.BtnClientes);
            this.PanelIzquierdo.Controls.Add(this.BtnInventario);
            this.PanelIzquierdo.Controls.Add(this.BtnCorteCaja);
            this.PanelIzquierdo.Controls.Add(this.BtnSalir);
            this.PanelIzquierdo.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelIzquierdo.Location = new System.Drawing.Point(0, 24);
            this.PanelIzquierdo.Name = "PanelIzquierdo";
            this.PanelIzquierdo.Size = new System.Drawing.Size(223, 637);
            this.PanelIzquierdo.TabIndex = 1;
            // 
            // PanelCentral
            // 
            this.PanelCentral.Controls.Add(this.LogoPOSS);
            this.PanelCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelCentral.Location = new System.Drawing.Point(223, 24);
            this.PanelCentral.Name = "PanelCentral";
            this.PanelCentral.Size = new System.Drawing.Size(561, 637);
            this.PanelCentral.TabIndex = 2;
            this.PanelCentral.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelCentral_Paint);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(523, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(65, 25);
            this.lblUsuario.TabIndex = 3;
            this.lblUsuario.Text = "label1";
            this.lblUsuario.Click += new System.EventHandler(this.lblUsuario_Click);
            // 
            // LogoPOSS
            // 
            this.LogoPOSS.Image = global::Proyecto_POS.Properties.Resources.Logo_de_la_Cafeteria;
            this.LogoPOSS.Location = new System.Drawing.Point(43, 43);
            this.LogoPOSS.Name = "LogoPOSS";
            this.LogoPOSS.Size = new System.Drawing.Size(424, 491);
            this.LogoPOSS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoPOSS.TabIndex = 0;
            this.LogoPOSS.TabStop = false;
            // 
            // BtnGenerarReporte
            // 
            this.BtnGenerarReporte.BackColor = System.Drawing.Color.Bisque;
            this.BtnGenerarReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGenerarReporte.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGenerarReporte.IconChar = FontAwesome.Sharp.IconChar.RectangleList;
            this.BtnGenerarReporte.IconColor = System.Drawing.Color.Black;
            this.BtnGenerarReporte.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnGenerarReporte.IconSize = 25;
            this.BtnGenerarReporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGenerarReporte.Location = new System.Drawing.Point(10, 456);
            this.BtnGenerarReporte.Name = "BtnGenerarReporte";
            this.BtnGenerarReporte.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.BtnGenerarReporte.Size = new System.Drawing.Size(190, 55);
            this.BtnGenerarReporte.TabIndex = 13;
            this.BtnGenerarReporte.Text = "Generar Reporte";
            this.BtnGenerarReporte.UseVisualStyleBackColor = false;
            this.BtnGenerarReporte.Click += new System.EventHandler(this.BtnGenerarReporte_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.BackColor = System.Drawing.Color.Bisque;
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarios.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.btnUsuarios.IconColor = System.Drawing.Color.Black;
            this.btnUsuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUsuarios.IconSize = 25;
            this.btnUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuarios.Location = new System.Drawing.Point(10, 382);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnUsuarios.Size = new System.Drawing.Size(190, 55);
            this.btnUsuarios.TabIndex = 12;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.UseVisualStyleBackColor = false;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // BtnVentaRapida
            // 
            this.BtnVentaRapida.BackColor = System.Drawing.Color.Bisque;
            this.BtnVentaRapida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVentaRapida.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVentaRapida.IconChar = FontAwesome.Sharp.IconChar.CartShopping;
            this.BtnVentaRapida.IconColor = System.Drawing.Color.Black;
            this.BtnVentaRapida.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnVentaRapida.IconSize = 25;
            this.BtnVentaRapida.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnVentaRapida.Location = new System.Drawing.Point(12, 21);
            this.BtnVentaRapida.Name = "BtnVentaRapida";
            this.BtnVentaRapida.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.BtnVentaRapida.Size = new System.Drawing.Size(188, 55);
            this.BtnVentaRapida.TabIndex = 11;
            this.BtnVentaRapida.Text = "Venta Rápida";
            this.BtnVentaRapida.UseVisualStyleBackColor = false;
            this.BtnVentaRapida.Click += new System.EventHandler(this.BtnVentaRapida_Click);
            // 
            // BtnProductos
            // 
            this.BtnProductos.BackColor = System.Drawing.Color.Bisque;
            this.BtnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProductos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProductos.IconChar = FontAwesome.Sharp.IconChar.LayerGroup;
            this.BtnProductos.IconColor = System.Drawing.Color.Black;
            this.BtnProductos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnProductos.IconSize = 25;
            this.BtnProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnProductos.Location = new System.Drawing.Point(14, 92);
            this.BtnProductos.Name = "BtnProductos";
            this.BtnProductos.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.BtnProductos.Size = new System.Drawing.Size(186, 55);
            this.BtnProductos.TabIndex = 10;
            this.BtnProductos.Text = "Productos";
            this.BtnProductos.UseVisualStyleBackColor = false;
            this.BtnProductos.Click += new System.EventHandler(this.BtnProductos_Click);
            // 
            // BtnClientes
            // 
            this.BtnClientes.BackColor = System.Drawing.Color.Bisque;
            this.BtnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClientes.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClientes.IconChar = FontAwesome.Sharp.IconChar.Person;
            this.BtnClientes.IconColor = System.Drawing.Color.Black;
            this.BtnClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnClientes.IconSize = 25;
            this.BtnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnClientes.Location = new System.Drawing.Point(10, 167);
            this.BtnClientes.Name = "BtnClientes";
            this.BtnClientes.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.BtnClientes.Size = new System.Drawing.Size(190, 55);
            this.BtnClientes.TabIndex = 9;
            this.BtnClientes.Text = "Clientes";
            this.BtnClientes.UseVisualStyleBackColor = false;
            this.BtnClientes.Click += new System.EventHandler(this.BtnClientes_Click);
            // 
            // BtnInventario
            // 
            this.BtnInventario.BackColor = System.Drawing.Color.Bisque;
            this.BtnInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInventario.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInventario.IconChar = FontAwesome.Sharp.IconChar.FolderOpen;
            this.BtnInventario.IconColor = System.Drawing.Color.Black;
            this.BtnInventario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnInventario.IconSize = 25;
            this.BtnInventario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnInventario.Location = new System.Drawing.Point(10, 241);
            this.BtnInventario.Name = "BtnInventario";
            this.BtnInventario.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.BtnInventario.Size = new System.Drawing.Size(190, 55);
            this.BtnInventario.TabIndex = 8;
            this.BtnInventario.Text = "Inventario";
            this.BtnInventario.UseVisualStyleBackColor = false;
            // 
            // BtnCorteCaja
            // 
            this.BtnCorteCaja.BackColor = System.Drawing.Color.Bisque;
            this.BtnCorteCaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCorteCaja.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCorteCaja.IconChar = FontAwesome.Sharp.IconChar.Ticket;
            this.BtnCorteCaja.IconColor = System.Drawing.Color.Black;
            this.BtnCorteCaja.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnCorteCaja.IconSize = 25;
            this.BtnCorteCaja.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCorteCaja.Location = new System.Drawing.Point(10, 309);
            this.BtnCorteCaja.Name = "BtnCorteCaja";
            this.BtnCorteCaja.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.BtnCorteCaja.Size = new System.Drawing.Size(190, 55);
            this.BtnCorteCaja.TabIndex = 7;
            this.BtnCorteCaja.Text = "Corte de Caja";
            this.BtnCorteCaja.UseVisualStyleBackColor = false;
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.Color.Bisque;
            this.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalir.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.IconChar = FontAwesome.Sharp.IconChar.Share;
            this.BtnSalir.IconColor = System.Drawing.Color.Black;
            this.BtnSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnSalir.IconSize = 25;
            this.BtnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSalir.Location = new System.Drawing.Point(10, 537);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.BtnSalir.Size = new System.Drawing.Size(190, 55);
            this.BtnSalir.TabIndex = 6;
            this.BtnSalir.Text = "Cerra Sesión";
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // FrmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 661);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.PanelCentral);
            this.Controls.Add(this.PanelIzquierdo);
            this.Controls.Add(this.MenuSuperior);
            this.MainMenuStrip = this.MenuSuperior;
            this.MaximizeBox = false;
            this.Name = "FrmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema POS Cafeteria Dulce Aroma";
            this.Load += new System.EventHandler(this.FrmMenuPrincipal_Load);
            this.MenuSuperior.ResumeLayout(false);
            this.MenuSuperior.PerformLayout();
            this.PanelIzquierdo.ResumeLayout(false);
            this.PanelCentral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LogoPOSS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuSuperior;
        private System.Windows.Forms.ToolStripMenuItem gestionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarCategoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verCategoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarVentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historialDeVentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDiarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productoMasVedidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cierreDeCajaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.Panel PanelIzquierdo;
        private System.Windows.Forms.Panel PanelCentral;
        private System.Windows.Forms.PictureBox LogoPOSS;
        private FontAwesome.Sharp.IconButton BtnSalir;
        private FontAwesome.Sharp.IconButton BtnCorteCaja;
        private FontAwesome.Sharp.IconButton BtnInventario;
        private FontAwesome.Sharp.IconButton BtnVentaRapida;
        private FontAwesome.Sharp.IconButton BtnProductos;
        private FontAwesome.Sharp.IconButton BtnClientes;
        private System.Windows.Forms.Label lblUsuario;
        private FontAwesome.Sharp.IconButton btnUsuarios;
        private System.Windows.Forms.ToolStripMenuItem cambiarClaveToolStripMenuItem;
        private FontAwesome.Sharp.IconButton BtnGenerarReporte;
    }
}

