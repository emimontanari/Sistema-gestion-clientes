namespace sistemaGestionClientes
{
    partial class frmBuscarCliente
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
            this.grpDatosCliente = new System.Windows.Forms.GroupBox();
            this.lblNombreResultado = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblLimiteCreditoResultado = new System.Windows.Forms.Label();
            this.lblDeudaResultado = new System.Windows.Forms.Label();
            this.lblLimiteCredito = new System.Windows.Forms.Label();
            this.lblDeuda = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblCodigoCliente = new System.Windows.Forms.Label();
            this.txtCodigoCliente = new System.Windows.Forms.TextBox();
            this.grpDatosCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDatosCliente
            // 
            this.grpDatosCliente.Controls.Add(this.lblNombreResultado);
            this.grpDatosCliente.Controls.Add(this.lblNombre);
            this.grpDatosCliente.Controls.Add(this.lblLimiteCreditoResultado);
            this.grpDatosCliente.Controls.Add(this.lblDeudaResultado);
            this.grpDatosCliente.Controls.Add(this.lblLimiteCredito);
            this.grpDatosCliente.Controls.Add(this.lblDeuda);
            this.grpDatosCliente.Location = new System.Drawing.Point(10, 80);
            this.grpDatosCliente.Name = "grpDatosCliente";
            this.grpDatosCliente.Size = new System.Drawing.Size(282, 132);
            this.grpDatosCliente.TabIndex = 7;
            this.grpDatosCliente.TabStop = false;
            this.grpDatosCliente.Text = "Datos del cliente";
            // 
            // lblNombreResultado
            // 
            this.lblNombreResultado.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lblNombreResultado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNombreResultado.Location = new System.Drawing.Point(140, 96);
            this.lblNombreResultado.Name = "lblNombreResultado";
            this.lblNombreResultado.Size = new System.Drawing.Size(136, 23);
            this.lblNombreResultado.TabIndex = 5;
            this.lblNombreResultado.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(28, 96);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblLimiteCreditoResultado
            // 
            this.lblLimiteCreditoResultado.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lblLimiteCreditoResultado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLimiteCreditoResultado.Location = new System.Drawing.Point(140, 61);
            this.lblLimiteCreditoResultado.Name = "lblLimiteCreditoResultado";
            this.lblLimiteCreditoResultado.Size = new System.Drawing.Size(136, 23);
            this.lblLimiteCreditoResultado.TabIndex = 3;
            this.lblLimiteCreditoResultado.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblDeudaResultado
            // 
            this.lblDeudaResultado.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lblDeudaResultado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDeudaResultado.Location = new System.Drawing.Point(140, 30);
            this.lblDeudaResultado.Name = "lblDeudaResultado";
            this.lblDeudaResultado.Size = new System.Drawing.Size(136, 23);
            this.lblDeudaResultado.TabIndex = 2;
            this.lblDeudaResultado.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblLimiteCredito
            // 
            this.lblLimiteCredito.AutoSize = true;
            this.lblLimiteCredito.Location = new System.Drawing.Point(28, 61);
            this.lblLimiteCredito.Name = "lblLimiteCredito";
            this.lblLimiteCredito.Size = new System.Drawing.Size(87, 13);
            this.lblLimiteCredito.TabIndex = 1;
            this.lblLimiteCredito.Text = "Limite de credito:";
            // 
            // lblDeuda
            // 
            this.lblDeuda.AutoSize = true;
            this.lblDeuda.Location = new System.Drawing.Point(28, 30);
            this.lblDeuda.Name = "lblDeuda";
            this.lblDeuda.Size = new System.Drawing.Size(42, 13);
            this.lblDeuda.TabIndex = 0;
            this.lblDeuda.Text = "Deuda:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(131, 39);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(161, 23);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblCodigoCliente
            // 
            this.lblCodigoCliente.AutoSize = true;
            this.lblCodigoCliente.Location = new System.Drawing.Point(18, 12);
            this.lblCodigoCliente.Name = "lblCodigoCliente";
            this.lblCodigoCliente.Size = new System.Drawing.Size(94, 13);
            this.lblCodigoCliente.TabIndex = 4;
            this.lblCodigoCliente.Text = "Codigo del cliente:";
            this.lblCodigoCliente.Click += new System.EventHandler(this.lblCodigoCliente_Click);
            // 
            // txtCodigoCliente
            // 
            this.txtCodigoCliente.Location = new System.Drawing.Point(131, 12);
            this.txtCodigoCliente.Name = "txtCodigoCliente";
            this.txtCodigoCliente.Size = new System.Drawing.Size(161, 20);
            this.txtCodigoCliente.TabIndex = 8;
            this.txtCodigoCliente.TextChanged += new System.EventHandler(this.txtCodigoCliente_TextChanged);
            // 
            // frmBuscarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 233);
            this.Controls.Add(this.txtCodigoCliente);
            this.Controls.Add(this.grpDatosCliente);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblCodigoCliente);
            this.Name = "frmBuscarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Cliente";
            this.grpDatosCliente.ResumeLayout(false);
            this.grpDatosCliente.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDatosCliente;
        private System.Windows.Forms.Label lblLimiteCreditoResultado;
        private System.Windows.Forms.Label lblDeudaResultado;
        private System.Windows.Forms.Label lblLimiteCredito;
        private System.Windows.Forms.Label lblDeuda;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblCodigoCliente;
        private System.Windows.Forms.TextBox txtCodigoCliente;
        private System.Windows.Forms.Label lblNombreResultado;
        private System.Windows.Forms.Label lblNombre;
    }
}