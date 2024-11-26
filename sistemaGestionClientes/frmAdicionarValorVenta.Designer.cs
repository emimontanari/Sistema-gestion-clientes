namespace sistemaGestionClientes
{
    partial class frmAdicionarValorVenta
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
            this.btnAdicionarValor = new System.Windows.Forms.Button();
            this.txtImporteVenta = new System.Windows.Forms.TextBox();
            this.cmbSucursal = new System.Windows.Forms.ComboBox();
            this.cmbMes = new System.Windows.Forms.ComboBox();
            this.lblImporteVenta = new System.Windows.Forms.Label();
            this.lblSucursal = new System.Windows.Forms.Label();
            this.lblMes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAdicionarValor
            // 
            this.btnAdicionarValor.Location = new System.Drawing.Point(118, 122);
            this.btnAdicionarValor.Name = "btnAdicionarValor";
            this.btnAdicionarValor.Size = new System.Drawing.Size(121, 28);
            this.btnAdicionarValor.TabIndex = 13;
            this.btnAdicionarValor.Text = "Adicionar Valor";
            this.btnAdicionarValor.UseVisualStyleBackColor = true;
            this.btnAdicionarValor.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // txtImporteVenta
            // 
            this.txtImporteVenta.Location = new System.Drawing.Point(118, 84);
            this.txtImporteVenta.Name = "txtImporteVenta";
            this.txtImporteVenta.Size = new System.Drawing.Size(121, 20);
            this.txtImporteVenta.TabIndex = 12;
            this.txtImporteVenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtImporteVenta.TextChanged += new System.EventHandler(this.txtImporteVenta_TextChanged);
            // 
            // cmbSucursal
            // 
            this.cmbSucursal.FormattingEnabled = true;
            this.cmbSucursal.Location = new System.Drawing.Point(118, 46);
            this.cmbSucursal.Name = "cmbSucursal";
            this.cmbSucursal.Size = new System.Drawing.Size(121, 21);
            this.cmbSucursal.TabIndex = 11;
            // 
            // cmbMes
            // 
            this.cmbMes.FormattingEnabled = true;
            this.cmbMes.Location = new System.Drawing.Point(118, 12);
            this.cmbMes.Name = "cmbMes";
            this.cmbMes.Size = new System.Drawing.Size(121, 21);
            this.cmbMes.TabIndex = 10;
            // 
            // lblImporteVenta
            // 
            this.lblImporteVenta.AutoSize = true;
            this.lblImporteVenta.Location = new System.Drawing.Point(11, 91);
            this.lblImporteVenta.Name = "lblImporteVenta";
            this.lblImporteVenta.Size = new System.Drawing.Size(90, 13);
            this.lblImporteVenta.TabIndex = 9;
            this.lblImporteVenta.Text = "Importe de venta:";
            // 
            // lblSucursal
            // 
            this.lblSucursal.AutoSize = true;
            this.lblSucursal.Location = new System.Drawing.Point(11, 54);
            this.lblSucursal.Name = "lblSucursal";
            this.lblSucursal.Size = new System.Drawing.Size(51, 13);
            this.lblSucursal.TabIndex = 8;
            this.lblSucursal.Text = "Sucursal:";
            // 
            // lblMes
            // 
            this.lblMes.AutoSize = true;
            this.lblMes.Location = new System.Drawing.Point(11, 15);
            this.lblMes.Name = "lblMes";
            this.lblMes.Size = new System.Drawing.Size(30, 13);
            this.lblMes.TabIndex = 7;
            this.lblMes.Text = "Mes:";
            // 
            // frmAdicionarValorVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 165);
            this.Controls.Add(this.btnAdicionarValor);
            this.Controls.Add(this.txtImporteVenta);
            this.Controls.Add(this.cmbSucursal);
            this.Controls.Add(this.cmbMes);
            this.Controls.Add(this.lblImporteVenta);
            this.Controls.Add(this.lblSucursal);
            this.Controls.Add(this.lblMes);
            this.Name = "frmAdicionarValorVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar valor de venta";
            this.Load += new System.EventHandler(this.frmAdicionarValorVenta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdicionarValor;
        private System.Windows.Forms.TextBox txtImporteVenta;
        private System.Windows.Forms.ComboBox cmbSucursal;
        private System.Windows.Forms.ComboBox cmbMes;
        private System.Windows.Forms.Label lblImporteVenta;
        private System.Windows.Forms.Label lblSucursal;
        private System.Windows.Forms.Label lblMes;
    }
}