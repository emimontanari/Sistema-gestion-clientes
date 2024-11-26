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
    public partial class frmConsultaDeUnCliente : Form
    {
        public frmConsultaDeUnCliente()
        {
            InitializeComponent();
        }

        private void frmConsultaDeUnCliente_Load(object sender, EventArgs e)
        {
            for (Int32 i = 0; i < Vector.IND; i++) {
                cmdClientes.Items.Add(Vector.cliente[i].nombre);
            }       
         }

        private void cmdClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmdClientes.Text != "")
            {
                btnMostrar.Enabled = true;
            }
            else
            {
                btnMostrar.Enabled = false;
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            Int32 i = cmdClientes.SelectedIndex;
            lblDeudaResultado.Text = Vector.cliente[i].deuda.ToString();
            lblLimiteCreditoResultado.Text = Vector.cliente[i].deuda.ToString();
        }
    }
}
