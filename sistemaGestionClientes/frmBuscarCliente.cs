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
    public partial class frmBuscarCliente : Form
    {
        public frmBuscarCliente()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Int32 i = 0;
            Int32 cod = Convert.ToInt32(txtCodigoCliente.Text);

            while (i < Vector.IND && Vector.cliente[i].codigo != cod) { 
                i++;
            }
            if (i == Vector.IND) {
                lblNombreResultado.Text = "";
                lblLimiteCreditoResultado.Text = "";
                lblDeudaResultado.Text = "";
                MessageBox.Show("Ese codigo no corresponde a ningun cliente");
            }
            else
            {
                lblNombreResultado.Text = Vector.cliente[i].nombre;
                lblLimiteCreditoResultado.Text = Vector.cliente[i].deuda.ToString();
                lblDeudaResultado.Text = Vector.cliente[i].limite.ToString();
            }
        }

        private void txtCodigoCliente_TextChanged(object sender, EventArgs e)
        {
            if (txtCodigoCliente.Text != "")
            {
                btnBuscar.Enabled = true;
            }
            else
            {
                btnBuscar.Enabled = false;
            }
        }

        private void lblCodigoCliente_Click(object sender, EventArgs e)
        {

        }
    }
}
