namespace Proyecto_POS.Pruebas
{
    partial class FrmPruebas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnProbarStock = new System.Windows.Forms.Button();
            this.btnProbarClientes = new System.Windows.Forms.Button();
            this.btnProbarPagos = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnValidarVentaOK = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnProbarStock
            // 
            this.btnProbarStock.Location = new System.Drawing.Point(114, 29);
            this.btnProbarStock.Name = "btnProbarStock";
            this.btnProbarStock.Size = new System.Drawing.Size(127, 53);
            this.btnProbarStock.TabIndex = 0;
            this.btnProbarStock.Text = "STOCK";
            this.btnProbarStock.UseVisualStyleBackColor = true;
            this.btnProbarStock.Click += new System.EventHandler(this.btnProbarStock_Click);
            // 
            // btnProbarClientes
            // 
            this.btnProbarClientes.Location = new System.Drawing.Point(114, 114);
            this.btnProbarClientes.Name = "btnProbarClientes";
            this.btnProbarClientes.Size = new System.Drawing.Size(127, 53);
            this.btnProbarClientes.TabIndex = 1;
            this.btnProbarClientes.Text = "CLIENTE ACTIVO\r\n";
            this.btnProbarClientes.UseVisualStyleBackColor = true;
            this.btnProbarClientes.Click += new System.EventHandler(this.btnProbarClientes_Click);
            // 
            // btnProbarPagos
            // 
            this.btnProbarPagos.Location = new System.Drawing.Point(114, 210);
            this.btnProbarPagos.Name = "btnProbarPagos";
            this.btnProbarPagos.Size = new System.Drawing.Size(127, 53);
            this.btnProbarPagos.TabIndex = 2;
            this.btnProbarPagos.Text = "PROBAR PAGOS";
            this.btnProbarPagos.UseVisualStyleBackColor = true;
            this.btnProbarPagos.Click += new System.EventHandler(this.btnProbarPagos_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(114, 307);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(127, 53);
            this.btnCerrar.TabIndex = 3;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnValidarVentaOK
            // 
            this.btnValidarVentaOK.Location = new System.Drawing.Point(302, 29);
            this.btnValidarVentaOK.Name = "btnValidarVentaOK";
            this.btnValidarVentaOK.Size = new System.Drawing.Size(127, 53);
            this.btnValidarVentaOK.TabIndex = 4;
            this.btnValidarVentaOK.Text = "VALIDAR VENTA";
            this.btnValidarVentaOK.UseVisualStyleBackColor = true;
            this.btnValidarVentaOK.Click += new System.EventHandler(this.btnValidarVentaOK_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(302, 114);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 53);
            this.button1.TabIndex = 5;
            this.button1.Text = "PRUEBA DE VENTA RAPIDA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmPruebas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnValidarVentaOK);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnProbarPagos);
            this.Controls.Add(this.btnProbarClientes);
            this.Controls.Add(this.btnProbarStock);
            this.Name = "FrmPruebas";
            this.Text = "FrmPruebas";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnProbarStock;
        private System.Windows.Forms.Button btnProbarClientes;
        private System.Windows.Forms.Button btnProbarPagos;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnValidarVentaOK;
        private System.Windows.Forms.Button button1;
    }
}