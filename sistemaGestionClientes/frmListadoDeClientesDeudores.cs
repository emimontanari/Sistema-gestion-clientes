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
    public partial class frmListadoDeClientesDeudores : Form
    {
        public frmListadoDeClientesDeudores()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            decimal totalDeuda = 0;
            decimal promedio = 0;
            Int32 cantidad = 0;
            dgvClientes.Rows.Clear();
            for (int i = 0; i < Vector.IND; i++)
            {
                if (Vector.cliente[i].deuda > 0)
                {
                    dgvClientes.Rows.Add(Vector.cliente[i].codigo, Vector.cliente[i].nombre, Vector.cliente[i].limite, Vector.cliente[i].deuda);
                    cantidad++;
                    totalDeuda = totalDeuda + Vector.cliente[i].deuda;
                }
            }

            if (cantidad > 0)
            {
                promedio = totalDeuda / cantidad;
            }
            lblTotalDeudasResultado.Text = lblTotalDeudasResultado.ToString();
            lblCantidadClienteResultado.Text = lblCantidadClienteResultado.ToString();
            lblPromedioDeudaResultado.Text = lblPromedioDeudaResultado.ToString();
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblCantidadClienteResultado_Click(object sender, EventArgs e)
        {

        }
    }
}
