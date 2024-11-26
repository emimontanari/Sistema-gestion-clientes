using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistemaGestionClientes
{
    public partial class frmAdicionarValorVenta : Form
    {
        public frmAdicionarValorVenta()
        {
            InitializeComponent();
        }

        private void frmAdicionarValorVenta_Load(object sender, EventArgs e)
        {
            cmbMes.Items.Clear();
            for (int i = 0; i < Vector.meses.Length; i++)
            {
                cmbMes.Items.Add(Vector.meses[i]);
            }
            cmbMes.SelectedIndex = 0;

            cmbSucursal.Items.Clear();
            for (int i = 0; i < Vector.sucursales.Length; i++)
            {
                cmbSucursal.Items.Add(Vector.sucursales[i]);
            }
            cmbSucursal.SelectedIndex = 0;
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            Int32 f = cmbMes.SelectedIndex;
            Int32 c = cmbSucursal.SelectedIndex;
            Decimal importe = Convert.ToDecimal(txtImporteVenta.Text);
            matriz.ventas[f,c] = matriz.ventas[f,c] + importe;
            MessageBox.Show("Venta registrada");
            cmbMes.SelectedIndex = 0;
            cmbSucursal.SelectedIndex = 0;
            txtImporteVenta.Text = "";
        }

        private void txtImporteVenta_TextChanged(object sender, EventArgs e)
        {
            if (txtImporteVenta.Text != "")
            {
                btnAdicionarValor.Enabled = true;
            }
            else
            {
                btnAdicionarValor.Enabled = false;
            }
        }
    }
}
