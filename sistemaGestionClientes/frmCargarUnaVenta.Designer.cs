namespace sistemaGestionClientes
{
    partial class frmCargarUnaVenta
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
            this.lblMes = new System.Windows.Forms.Label();
            this.lblSucursal = new System.Windows.Forms.Label();
            this.lblImporteVenta = new System.Windows.Forms.Label();
            this.cmbMes = new System.Windows.Forms.ComboBox();
            this.cmbSucursal = new System.Windows.Forms.ComboBox();
            this.txtImporteVenta = new System.Windows.Forms.TextBox();
            this.btnCargar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMes
            // 
            this.lblMes.AutoSize = true;
            this.lblMes.Location = new System.Drawing.Point(12, 19);
            this.lblMes.Name = "lblMes";
            this.lblMes.Size = new System.Drawing.Size(30, 13);
            this.lblMes.TabIndex = 0;
            this.lblMes.Text = "Mes:";
            // 
            // lblSucursal
            // 
            this.lblSucursal.AutoSize = true;
            this.lblSucursal.Location = new System.Drawing.Point(12, 58);
            this.lblSucursal.Name = "lblSucursal";
            this.lblSucursal.Size = new System.Drawing.Size(51, 13);
            this.lblSucursal.TabIndex = 1;
            this.lblSucursal.Text = "Sucursal:";
            // 
            // lblImporteVenta
            // 
            this.lblImporteVenta.AutoSize = true;
            this.lblImporteVenta.Location = new System.Drawing.Point(12, 95);
            this.lblImporteVenta.Name = "lblImporteVenta";
            this.lblImporteVenta.Size = new System.Drawing.Size(90, 13);
            this.lblImporteVenta.TabIndex = 2;
            this.lblImporteVenta.Text = "Importe de venta:";
            // 
            // cmbMes
            // 
            this.cmbMes.FormattingEnabled = true;
            this.cmbMes.Location = new System.Drawing.Point(119, 16);
            this.cmbMes.Name = "cmbMes";
            this.cmbMes.Size = new System.Drawing.Size(121, 21);
            this.cmbMes.TabIndex = 3;
            // 
            // cmbSucursal
            // 
            this.cmbSucursal.FormattingEnabled = true;
            this.cmbSucursal.Location = new System.Drawing.Point(119, 50);
            this.cmbSucursal.Name = "cmbSucursal";
            this.cmbSucursal.Size = new System.Drawing.Size(121, 21);
            this.cmbSucursal.TabIndex = 4;
            // 
            // txtImporteVenta
            // 
            this.txtImporteVenta.Location = new System.Drawing.Point(119, 88);
            this.txtImporteVenta.Name = "txtImporteVenta";
            this.txtImporteVenta.Size = new System.Drawing.Size(121, 20);
            this.txtImporteVenta.TabIndex = 5;
            this.txtImporteVenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtImporteVenta.TextChanged += new System.EventHandler(this.txtImporteVenta_TextChanged);
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(119, 126);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(121, 28);
            this.btnCargar.TabIndex = 6;
            this.btnCargar.Text = "cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // frmCargarUnaVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 169);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.txtImporteVenta);
            this.Controls.Add(this.cmbSucursal);
            this.Controls.Add(this.cmbMes);
            this.Controls.Add(this.lblImporteVenta);
            this.Controls.Add(this.lblSucursal);
            this.Controls.Add(this.lblMes);
            this.Name = "frmCargarUnaVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Carga de ventas";
            this.Load += new System.EventHandler(this.cmbSucursal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMes;
        private System.Windows.Forms.Label lblSucursal;
        private System.Windows.Forms.Label lblImporteVenta;
        private System.Windows.Forms.ComboBox cmbMes;
        private System.Windows.Forms.ComboBox cmbSucursal;
        private System.Windows.Forms.TextBox txtImporteVenta;
        private System.Windows.Forms.Button btnCargar;
    }
}