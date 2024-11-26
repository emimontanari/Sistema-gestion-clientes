namespace sistemaGestionClientes
{
    partial class frmConsultarUnaVenta
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
            this.btnConsultar = new System.Windows.Forms.Button();
            this.cmbSucursal = new System.Windows.Forms.ComboBox();
            this.cmbMes = new System.Windows.Forms.ComboBox();
            this.lblImporteVenta = new System.Windows.Forms.Label();
            this.lblSucursal = new System.Windows.Forms.Label();
            this.lblMes = new System.Windows.Forms.Label();
            this.lblVenta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(124, 122);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(121, 28);
            this.btnConsultar.TabIndex = 13;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // cmbSucursal
            // 
            this.cmbSucursal.FormattingEnabled = true;
            this.cmbSucursal.Location = new System.Drawing.Point(124, 46);
            this.cmbSucursal.Name = "cmbSucursal";
            this.cmbSucursal.Size = new System.Drawing.Size(121, 21);
            this.cmbSucursal.TabIndex = 11;
            // 
            // cmbMes
            // 
            this.cmbMes.FormattingEnabled = true;
            this.cmbMes.Location = new System.Drawing.Point(124, 12);
            this.cmbMes.Name = "cmbMes";
            this.cmbMes.Size = new System.Drawing.Size(121, 21);
            this.cmbMes.TabIndex = 10;
            // 
            // lblImporteVenta
            // 
            this.lblImporteVenta.AutoSize = true;
            this.lblImporteVenta.Location = new System.Drawing.Point(17, 91);
            this.lblImporteVenta.Name = "lblImporteVenta";
            this.lblImporteVenta.Size = new System.Drawing.Size(90, 13);
            this.lblImporteVenta.TabIndex = 9;
            this.lblImporteVenta.Text = "Importe de venta:";
            // 
            // lblSucursal
            // 
            this.lblSucursal.AutoSize = true;
            this.lblSucursal.Location = new System.Drawing.Point(17, 54);
            this.lblSucursal.Name = "lblSucursal";
            this.lblSucursal.Size = new System.Drawing.Size(51, 13);
            this.lblSucursal.TabIndex = 8;
            this.lblSucursal.Text = "Sucursal:";
            // 
            // lblMes
            // 
            this.lblMes.AutoSize = true;
            this.lblMes.Location = new System.Drawing.Point(17, 15);
            this.lblMes.Name = "lblMes";
            this.lblMes.Size = new System.Drawing.Size(30, 13);
            this.lblMes.TabIndex = 7;
            this.lblMes.Text = "Mes:";
            // 
            // lblVenta
            // 
            this.lblVenta.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lblVenta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblVenta.Location = new System.Drawing.Point(121, 83);
            this.lblVenta.Name = "lblVenta";
            this.lblVenta.Size = new System.Drawing.Size(124, 21);
            this.lblVenta.TabIndex = 14;
            this.lblVenta.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // frmConsultarUnaVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 160);
            this.Controls.Add(this.lblVenta);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.cmbSucursal);
            this.Controls.Add(this.cmbMes);
            this.Controls.Add(this.lblImporteVenta);
            this.Controls.Add(this.lblSucursal);
            this.Controls.Add(this.lblMes);
            this.Name = "frmConsultarUnaVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar venta";
            this.Load += new System.EventHandler(this.frmConsultarUnaVenta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.ComboBox cmbSucursal;
        private System.Windows.Forms.ComboBox cmbMes;
        private System.Windows.Forms.Label lblImporteVenta;
        private System.Windows.Forms.Label lblSucursal;
        private System.Windows.Forms.Label lblMes;
        private System.Windows.Forms.Label lblVenta;
    }
}