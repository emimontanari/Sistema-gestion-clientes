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
    public partial class frmCargarUnaVenta : Form
    {
        public frmCargarUnaVenta()
        {
            InitializeComponent();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            Int32 f = cmbMes.SelectedIndex;
            Int32 c = cmbSucursal.SelectedIndex;
            matriz.ventas[f,c] = Convert.ToDecimal(txtImporteVenta.Text);
            MessageBox.Show("Importe cargado exitosamente");
            cmbMes.SelectedIndex = 0;
            cmbSucursal.SelectedIndex = 0;
            txtImporteVenta.Text = "";
        }

        private void cmbSucursal_Load(object sender, EventArgs e)
        {
            cmbMes.Items.Clear();
            for (int i = 0; i < Vector.meses.Length; i++) { 
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

        private void txtImporteVenta_TextChanged(object sender, EventArgs e)
        {
            if (txtImporteVenta.Text != "")
            {
                btnCargar.Enabled = true;
            }
            else
            {
                btnCargar.Enabled=false;
            }
        }
    }
}
