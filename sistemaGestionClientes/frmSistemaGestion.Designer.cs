namespace sistemaGestionClientes
{
    partial class frmSistemaGestion
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarNuevosClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.buscarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaDeUnClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.listadoDeTodosLosClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeClientesDeudoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarUnaVentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionarUnValorAUnaVentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.ventasDeUnaSucursalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasDeUnMesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.consultarTotalGeneralToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrarTodosLosDatosDeLaMatrizToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sistemaToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.ventasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(618, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sistemaToolStripMenuItem
            // 
            this.sistemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem,
            this.toolStripMenuItem1,
            this.salirToolStripMenuItem});
            this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.sistemaToolStripMenuItem.Text = "Sistema";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.acercaDeToolStripMenuItem.Text = "Acerca de ...";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(135, 6);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarNuevosClientesToolStripMenuItem,
            this.toolStripMenuItem2,
            this.buscarClienteToolStripMenuItem,
            this.consultaDeUnClienteToolStripMenuItem,
            this.toolStripMenuItem3,
            this.listadoDeTodosLosClientesToolStripMenuItem,
            this.listadoDeClientesDeudoresToolStripMenuItem});
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // agregarNuevosClientesToolStripMenuItem
            // 
            this.agregarNuevosClientesToolStripMenuItem.Name = "agregarNuevosClientesToolStripMenuItem";
            this.agregarNuevosClientesToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.agregarNuevosClientesToolStripMenuItem.Text = "Agregar nuevos clientes...";
            this.agregarNuevosClientesToolStripMenuItem.Click += new System.EventHandler(this.agregarNuevosClientesToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(230, 6);
            // 
            // buscarClienteToolStripMenuItem
            // 
            this.buscarClienteToolStripMenuItem.Name = "buscarClienteToolStripMenuItem";
            this.buscarClienteToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.buscarClienteToolStripMenuItem.Text = "Buscar Cliente...";
            this.buscarClienteToolStripMenuItem.Click += new System.EventHandler(this.buscarClienteToolStripMenuItem_Click);
            // 
            // consultaDeUnClienteToolStripMenuItem
            // 
            this.consultaDeUnClienteToolStripMenuItem.Name = "consultaDeUnClienteToolStripMenuItem";
            this.consultaDeUnClienteToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.consultaDeUnClienteToolStripMenuItem.Text = "Consulta de un cliente...";
            this.consultaDeUnClienteToolStripMenuItem.Click += new System.EventHandler(this.consultaDeUnClienteToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(230, 6);
            // 
            // listadoDeTodosLosClientesToolStripMenuItem
            // 
            this.listadoDeTodosLosClientesToolStripMenuItem.Name = "listadoDeTodosLosClientesToolStripMenuItem";
            this.listadoDeTodosLosClientesToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.listadoDeTodosLosClientesToolStripMenuItem.Text = "Listado de todos los clientes...";
            this.listadoDeTodosLosClientesToolStripMenuItem.Click += new System.EventHandler(this.listadoDeTodosLosClientesToolStripMenuItem_Click);
            // 
            // listadoDeClientesDeudoresToolStripMenuItem
            // 
            this.listadoDeClientesDeudoresToolStripMenuItem.Name = "listadoDeClientesDeudoresToolStripMenuItem";
            this.listadoDeClientesDeudoresToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.listadoDeClientesDeudoresToolStripMenuItem.Text = "Listado de clientes Deudores...";
            this.listadoDeClientesDeudoresToolStripMenuItem.Click += new System.EventHandler(this.listadoDeClientesDeudoresToolStripMenuItem_Click);
            // 
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cToolStripMenuItem,
            this.consultarUnaVentaToolStripMenuItem,
            this.adicionarUnValorAUnaVentaToolStripMenuItem,
            this.toolStripMenuItem4,
            this.ventasDeUnaSucursalToolStripMenuItem,
            this.ventasDeUnMesToolStripMenuItem,
            this.toolStripMenuItem5,
            this.consultarTotalGeneralToolStripMenuItem,
            this.borrarTodosLosDatosDeLaMatrizToolStripMenuItem});
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ventasToolStripMenuItem.Text = "Ventas";
            // 
            // cToolStripMenuItem
            // 
            this.cToolStripMenuItem.Name = "cToolStripMenuItem";
            this.cToolStripMenuItem.Size = new System.Drawing.Size(262, 22);
            this.cToolStripMenuItem.Text = "Carga una venta...";
            this.cToolStripMenuItem.Click += new System.EventHandler(this.cToolStripMenuItem_Click);
            // 
            // consultarUnaVentaToolStripMenuItem
            // 
            this.consultarUnaVentaToolStripMenuItem.Name = "consultarUnaVentaToolStripMenuItem";
            this.consultarUnaVentaToolStripMenuItem.Size = new System.Drawing.Size(262, 22);
            this.consultarUnaVentaToolStripMenuItem.Text = "Consultar una venta...";
            this.consultarUnaVentaToolStripMenuItem.Click += new System.EventHandler(this.consultarUnaVentaToolStripMenuItem_Click);
            // 
            // adicionarUnValorAUnaVentaToolStripMenuItem
            // 
            this.adicionarUnValorAUnaVentaToolStripMenuItem.Name = "adicionarUnValorAUnaVentaToolStripMenuItem";
            this.adicionarUnValorAUnaVentaToolStripMenuItem.Size = new System.Drawing.Size(262, 22);
            this.adicionarUnValorAUnaVentaToolStripMenuItem.Text = "Adicionar un valor a una venta...";
            this.adicionarUnValorAUnaVentaToolStripMenuItem.Click += new System.EventHandler(this.adicionarUnValorAUnaVentaToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(259, 6);
            // 
            // ventasDeUnaSucursalToolStripMenuItem
            // 
            this.ventasDeUnaSucursalToolStripMenuItem.Name = "ventasDeUnaSucursalToolStripMenuItem";
            this.ventasDeUnaSucursalToolStripMenuItem.Size = new System.Drawing.Size(262, 22);
            this.ventasDeUnaSucursalToolStripMenuItem.Text = "Ventas de una sucursal...";
            this.ventasDeUnaSucursalToolStripMenuItem.Click += new System.EventHandler(this.ventasDeUnaSucursalToolStripMenuItem_Click);
            // 
            // ventasDeUnMesToolStripMenuItem
            // 
            this.ventasDeUnMesToolStripMenuItem.Name = "ventasDeUnMesToolStripMenuItem";
            this.ventasDeUnMesToolStripMenuItem.Size = new System.Drawing.Size(262, 22);
            this.ventasDeUnMesToolStripMenuItem.Text = "Ventas de un mes...";
            this.ventasDeUnMesToolStripMenuItem.Click += new System.EventHandler(this.ventasDeUnMesToolStripMenuItem_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(259, 6);
            // 
            // consultarTotalGeneralToolStripMenuItem
            // 
            this.consultarTotalGeneralToolStripMenuItem.Name = "consultarTotalGeneralToolStripMenuItem";
            this.consultarTotalGeneralToolStripMenuItem.Size = new System.Drawing.Size(262, 22);
            this.consultarTotalGeneralToolStripMenuItem.Text = "Consultar total general...";
            this.consultarTotalGeneralToolStripMenuItem.Click += new System.EventHandler(this.consultarTotalGeneralToolStripMenuItem_Click);
            // 
            // borrarTodosLosDatosDeLaMatrizToolStripMenuItem
            // 
            this.borrarTodosLosDatosDeLaMatrizToolStripMenuItem.Name = "borrarTodosLosDatosDeLaMatrizToolStripMenuItem";
            this.borrarTodosLosDatosDeLaMatrizToolStripMenuItem.Size = new System.Drawing.Size(262, 22);
            this.borrarTodosLosDatosDeLaMatrizToolStripMenuItem.Text = "Borrar todos los datos de la matriz...";
            this.borrarTodosLosDatosDeLaMatrizToolStripMenuItem.Click += new System.EventHandler(this.borrarTodosLosDatosDeLaMatrizToolStripMenuItem_Click);
            // 
            // frmSistemaGestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(618, 422);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmSistemaGestion";
            this.Text = "Sistema de gestion de clientes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmSistemaGestion_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarNuevosClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem consultaDeUnClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem listadoDeTodosLosClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeClientesDeudoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarUnaVentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adicionarUnValorAUnaVentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem ventasDeUnaSucursalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasDeUnMesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem consultarTotalGeneralToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrarTodosLosDatosDeLaMatrizToolStripMenuItem;
    }
}

