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
    public partial class frmConsultarUnaVenta : Form
    {
        public frmConsultarUnaVenta()
        {
            InitializeComponent();
        }

        private void frmConsultarUnaVenta_Load(object sender, EventArgs e)
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

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Int32 f = cmbMes.SelectedIndex;
            Int32 c = cmbSucursal.SelectedIndex;
            lblVenta.Text = matriz.ventas[f,c].ToString();
        }
    }
}
