namespace sistemaGestionClientes
{
    partial class frmConsultaDeUnCliente
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
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.cmdClientes = new System.Windows.Forms.ComboBox();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.grpDatosCliente = new System.Windows.Forms.GroupBox();
            this.lblDeuda = new System.Windows.Forms.Label();
            this.lblLimiteCredito = new System.Windows.Forms.Label();
            this.lblDeudaResultado = new System.Windows.Forms.Label();
            this.lblLimiteCreditoResultado = new System.Windows.Forms.Label();
            this.grpDatosCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.Location = new System.Drawing.Point(25, 20);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(98, 13);
            this.lblNombreCliente.TabIndex = 0;
            this.lblNombreCliente.Text = "Nombre del cliente:";
            // 
            // cmdClientes
            // 
            this.cmdClientes.FormattingEnabled = true;
            this.cmdClientes.Location = new System.Drawing.Point(138, 20);
            this.cmdClientes.Name = "cmdClientes";
            this.cmdClientes.Size = new System.Drawing.Size(161, 21);
            this.cmdClientes.TabIndex = 1;
            this.cmdClientes.SelectedIndexChanged += new System.EventHandler(this.cmdClientes_SelectedIndexChanged);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(138, 47);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(161, 23);
            this.btnMostrar.TabIndex = 2;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // grpDatosCliente
            // 
            this.grpDatosCliente.Controls.Add(this.lblLimiteCreditoResultado);
            this.grpDatosCliente.Controls.Add(this.lblDeudaResultado);
            this.grpDatosCliente.Controls.Add(this.lblLimiteCredito);
            this.grpDatosCliente.Controls.Add(this.lblDeuda);
            this.grpDatosCliente.Location = new System.Drawing.Point(17, 88);
            this.grpDatosCliente.Name = "grpDatosCliente";
            this.grpDatosCliente.Size = new System.Drawing.Size(282, 100);
            this.grpDatosCliente.TabIndex = 3;
            this.grpDatosCliente.TabStop = false;
            this.grpDatosCliente.Text = "Datos del cliente";
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
            // lblLimiteCredito
            // 
            this.lblLimiteCredito.AutoSize = true;
            this.lblLimiteCredito.Location = new System.Drawing.Point(28, 61);
            this.lblLimiteCredito.Name = "lblLimiteCredito";
            this.lblLimiteCredito.Size = new System.Drawing.Size(87, 13);
            this.lblLimiteCredito.TabIndex = 1;
            this.lblLimiteCredito.Text = "Limite de credito:";
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
            // frmConsultaDeUnCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 199);
            this.Controls.Add(this.grpDatosCliente);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.cmdClientes);
            this.Controls.Add(this.lblNombreCliente);
            this.Name = "frmConsultaDeUnCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta De Un Cliente";
            this.Load += new System.EventHandler(this.frmConsultaDeUnCliente_Load);
            this.grpDatosCliente.ResumeLayout(false);
            this.grpDatosCliente.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombreCliente;
        private System.Windows.Forms.ComboBox cmdClientes;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.GroupBox grpDatosCliente;
        private System.Windows.Forms.Label lblLimiteCreditoResultado;
        private System.Windows.Forms.Label lblDeudaResultado;
        private System.Windows.Forms.Label lblLimiteCredito;
        private System.Windows.Forms.Label lblDeuda;
    }
}