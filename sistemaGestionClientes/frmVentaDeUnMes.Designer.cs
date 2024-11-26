namespace sistemaGestionClientes
{
    partial class frmVentaDeUnMes
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
            this.btnListar = new System.Windows.Forms.Button();
            this.lblPromedioResultado = new System.Windows.Forms.Label();
            this.lblVentasResultado = new System.Windows.Forms.Label();
            this.lblPromedio = new System.Windows.Forms.Label();
            this.lblTotalVentas = new System.Windows.Forms.Label();
            this.Grilla = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbMes = new System.Windows.Forms.ComboBox();
            this.lblMes = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Grilla)).BeginInit();
            this.SuspendLayout();
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(122, 291);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(121, 34);
            this.btnListar.TabIndex = 15;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // lblPromedioResultado
            // 
            this.lblPromedioResultado.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lblPromedioResultado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPromedioResultado.Location = new System.Drawing.Point(136, 254);
            this.lblPromedioResultado.Name = "lblPromedioResultado";
            this.lblPromedioResultado.Size = new System.Drawing.Size(107, 24);
            this.lblPromedioResultado.TabIndex = 14;
            this.lblPromedioResultado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblVentasResultado
            // 
            this.lblVentasResultado.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lblVentasResultado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblVentasResultado.Location = new System.Drawing.Point(136, 213);
            this.lblVentasResultado.Name = "lblVentasResultado";
            this.lblVentasResultado.Size = new System.Drawing.Size(107, 24);
            this.lblVentasResultado.TabIndex = 13;
            this.lblVentasResultado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPromedio
            // 
            this.lblPromedio.AutoSize = true;
            this.lblPromedio.Location = new System.Drawing.Point(32, 265);
            this.lblPromedio.Name = "lblPromedio";
            this.lblPromedio.Size = new System.Drawing.Size(54, 13);
            this.lblPromedio.TabIndex = 12;
            this.lblPromedio.Text = "Promedio:";
            // 
            // lblTotalVentas
            // 
            this.lblTotalVentas.AutoSize = true;
            this.lblTotalVentas.Location = new System.Drawing.Point(32, 224);
            this.lblTotalVentas.Name = "lblTotalVentas";
            this.lblTotalVentas.Size = new System.Drawing.Size(84, 13);
            this.lblTotalVentas.TabIndex = 11;
            this.lblTotalVentas.Text = "Total de ventas:";
            // 
            // Grilla
            // 
            this.Grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grilla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.Grilla.Location = new System.Drawing.Point(12, 48);
            this.Grilla.Name = "Grilla";
            this.Grilla.Size = new System.Drawing.Size(248, 150);
            this.Grilla.TabIndex = 10;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mes";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "importe";
            this.Column2.Name = "Column2";
            // 
            // cmbMes
            // 
            this.cmbMes.FormattingEnabled = true;
            this.cmbMes.Location = new System.Drawing.Point(122, 10);
            this.cmbMes.Name = "cmbMes";
            this.cmbMes.Size = new System.Drawing.Size(121, 21);
            this.cmbMes.TabIndex = 9;
            // 
            // lblMes
            // 
            this.lblMes.AutoSize = true;
            this.lblMes.Location = new System.Drawing.Point(16, 13);
            this.lblMes.Name = "lblMes";
            this.lblMes.Size = new System.Drawing.Size(51, 13);
            this.lblMes.TabIndex = 8;
            this.lblMes.Text = "Sucursal:";
            // 
            // frmVentaDeUnMes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 343);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.lblPromedioResultado);
            this.Controls.Add(this.lblVentasResultado);
            this.Controls.Add(this.lblPromedio);
            this.Controls.Add(this.lblTotalVentas);
            this.Controls.Add(this.Grilla);
            this.Controls.Add(this.cmbMes);
            this.Controls.Add(this.lblMes);
            this.Name = "frmVentaDeUnMes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventas de un mes";
            this.Load += new System.EventHandler(this.frmVentaDeUnMes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grilla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Label lblPromedioResultado;
        private System.Windows.Forms.Label lblVentasResultado;
        private System.Windows.Forms.Label lblPromedio;
        private System.Windows.Forms.Label lblTotalVentas;
        private System.Windows.Forms.DataGridView Grilla;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.ComboBox cmbMes;
        private System.Windows.Forms.Label lblMes;
    }
}