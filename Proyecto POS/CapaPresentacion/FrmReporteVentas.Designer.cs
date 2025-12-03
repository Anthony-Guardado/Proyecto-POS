namespace Proyecto_POS.CapaPresentacion
{
    partial class FrmReporteVentas
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
            this.lblInicio = new System.Windows.Forms.Label();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.lblFin = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // lblInicio
            // 
            this.lblInicio.AutoSize = true;
            this.lblInicio.Location = new System.Drawing.Point(108, 136);
            this.lblInicio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(158, 30);
            this.lblInicio.TabIndex = 0;
            this.lblInicio.Text = "FECHA INICIO:";
            // 
            // dtpInicio
            // 
            this.dtpInicio.CalendarFont = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicio.Location = new System.Drawing.Point(274, 130);
            this.dtpInicio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(161, 35);
            this.dtpInicio.TabIndex = 1;
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(274, 258);
            this.btnGenerar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(253, 44);
            this.btnGenerar.TabIndex = 2;
            this.btnGenerar.Text = "GENERAR REPORTES";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(423, 21);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(254, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "REPORTE DE VENTAS";
            // 
            // dtpFin
            // 
            this.dtpFin.CalendarFont = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFin.Location = new System.Drawing.Point(746, 132);
            this.dtpFin.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(167, 35);
            this.dtpFin.TabIndex = 5;
            // 
            // lblFin
            // 
            this.lblFin.AutoSize = true;
            this.lblFin.Location = new System.Drawing.Point(598, 136);
            this.lblFin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFin.Name = "lblFin";
            this.lblFin.Size = new System.Drawing.Size(126, 30);
            this.lblFin.TabIndex = 4;
            this.lblFin.Text = "FECHA FIN:";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(673, 258);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(190, 44);
            this.btnCerrar.TabIndex = 6;
            this.btnCerrar.Text = "SALIR";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // FrmReporteVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 411);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.dtpFin);
            this.Controls.Add(this.lblFin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.dtpInicio);
            this.Controls.Add(this.lblInicio);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "FrmReporteVentas";
            this.Text = "FrmReporteVentas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInicio;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFin;
        private System.Windows.Forms.Label lblFin;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}