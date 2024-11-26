namespace sistemaGestionClientes
{
    partial class frmListadoDeClientesDeudores
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
            this.grpConsultaDatos = new System.Windows.Forms.GroupBox();
            this.btnListar = new System.Windows.Forms.Button();
            this.lblCantidadClienteResultado = new System.Windows.Forms.Label();
            this.lblPromedioDeudaResultado = new System.Windows.Forms.Label();
            this.lblTotalDeudasResultado = new System.Windows.Forms.Label();
            this.lblPromedioDeuda = new System.Windows.Forms.Label();
            this.lblCantidadDeClientes = new System.Windows.Forms.Label();
            this.lblTotalDeudas = new System.Windows.Forms.Label();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpConsultaDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // grpConsultaDatos
            // 
            this.grpConsultaDatos.Controls.Add(this.btnListar);
            this.grpConsultaDatos.Controls.Add(this.lblCantidadClienteResultado);
            this.grpConsultaDatos.Controls.Add(this.lblPromedioDeudaResultado);
            this.grpConsultaDatos.Controls.Add(this.lblTotalDeudasResultado);
            this.grpConsultaDatos.Controls.Add(this.lblPromedioDeuda);
            this.grpConsultaDatos.Controls.Add(this.lblCantidadDeClientes);
            this.grpConsultaDatos.Controls.Add(this.lblTotalDeudas);
            this.grpConsultaDatos.Controls.Add(this.dgvClientes);
            this.grpConsultaDatos.Location = new System.Drawing.Point(12, 12);
            this.grpConsultaDatos.Name = "grpConsultaDatos";
            this.grpConsultaDatos.Size = new System.Drawing.Size(495, 334);
            this.grpConsultaDatos.TabIndex = 1;
            this.grpConsultaDatos.TabStop = false;
            this.grpConsultaDatos.Text = "Consulta de Datos";
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(358, 281);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(98, 31);
            this.btnListar.TabIndex = 7;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // lblCantidadClienteResultado
            // 
            this.lblCantidadClienteResultado.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lblCantidadClienteResultado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCantidadClienteResultado.Location = new System.Drawing.Point(358, 215);
            this.lblCantidadClienteResultado.Name = "lblCantidadClienteResultado";
            this.lblCantidadClienteResultado.Size = new System.Drawing.Size(98, 19);
            this.lblCantidadClienteResultado.TabIndex = 6;
            this.lblCantidadClienteResultado.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblCantidadClienteResultado.Click += new System.EventHandler(this.lblCantidadClienteResultado_Click);
            // 
            // lblPromedioDeudaResultado
            // 
            this.lblPromedioDeudaResultado.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lblPromedioDeudaResultado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPromedioDeudaResultado.Location = new System.Drawing.Point(358, 248);
            this.lblPromedioDeudaResultado.Name = "lblPromedioDeudaResultado";
            this.lblPromedioDeudaResultado.Size = new System.Drawing.Size(98, 19);
            this.lblPromedioDeudaResultado.TabIndex = 5;
            this.lblPromedioDeudaResultado.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblTotalDeudasResultado
            // 
            this.lblTotalDeudasResultado.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lblTotalDeudasResultado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalDeudasResultado.Location = new System.Drawing.Point(358, 185);
            this.lblTotalDeudasResultado.Name = "lblTotalDeudasResultado";
            this.lblTotalDeudasResultado.Size = new System.Drawing.Size(98, 19);
            this.lblTotalDeudasResultado.TabIndex = 4;
            this.lblTotalDeudasResultado.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblPromedioDeuda
            // 
            this.lblPromedioDeuda.AutoSize = true;
            this.lblPromedioDeuda.Location = new System.Drawing.Point(223, 248);
            this.lblPromedioDeuda.Name = "lblPromedioDeuda";
            this.lblPromedioDeuda.Size = new System.Drawing.Size(102, 13);
            this.lblPromedioDeuda.TabIndex = 3;
            this.lblPromedioDeuda.Text = "Promedio de deuda:";
            // 
            // lblCantidadDeClientes
            // 
            this.lblCantidadDeClientes.AutoSize = true;
            this.lblCantidadDeClientes.Location = new System.Drawing.Point(223, 215);
            this.lblCantidadDeClientes.Name = "lblCantidadDeClientes";
            this.lblCantidadDeClientes.Size = new System.Drawing.Size(106, 13);
            this.lblCantidadDeClientes.TabIndex = 2;
            this.lblCantidadDeClientes.Text = "Cantidad de clientes:";
            // 
            // lblTotalDeudas
            // 
            this.lblTotalDeudas.AutoSize = true;
            this.lblTotalDeudas.Location = new System.Drawing.Point(223, 185);
            this.lblTotalDeudas.Name = "lblTotalDeudas";
            this.lblTotalDeudas.Size = new System.Drawing.Size(87, 13);
            this.lblTotalDeudas.TabIndex = 1;
            this.lblTotalDeudas.Text = "Total de deudas:";
            // 
            // dgvClientes
            // 
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvClientes.Location = new System.Drawing.Point(11, 21);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.Size = new System.Drawing.Size(478, 150);
            this.dgvClientes.TabIndex = 0;
            this.dgvClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Codigo";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre y Apellido";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Limite de credito";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Deuda";
            this.Column4.Name = "Column4";
            // 
            // frmListadoDeClientesDeudores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 358);
            this.Controls.Add(this.grpConsultaDatos);
            this.Name = "frmListadoDeClientesDeudores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado De Clientes Deudores";
            this.grpConsultaDatos.ResumeLayout(false);
            this.grpConsultaDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpConsultaDatos;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Label lblCantidadClienteResultado;
        private System.Windows.Forms.Label lblPromedioDeudaResultado;
        private System.Windows.Forms.Label lblTotalDeudasResultado;
        private System.Windows.Forms.Label lblPromedioDeuda;
        private System.Windows.Forms.Label lblCantidadDeClientes;
        private System.Windows.Forms.Label lblTotalDeudas;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}