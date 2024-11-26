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
    public partial class frmAgregarNuevoCliente : Form
    {
        public frmAgregarNuevoCliente()
        {
            InitializeComponent();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            if (Vector.IND < Vector.cliente.Length) {
                Vector.cliente[Vector.IND].codigo = Convert.ToInt32(txtCodigo.Text);
                Vector.cliente[Vector.IND].nombre = txtNombreApellido.Text;
                Vector.cliente[Vector.IND].deuda = Convert.ToDecimal(txtDeuda.Text);
                Vector.cliente[Vector.IND].limite = Convert.ToDecimal(txtLimiteCredito.Text);
                Vector.IND++;
                MessageBox.Show("Los datos se cargaron");
                txtCodigo.Text = "";
                txtDeuda.Text = "";
                txtNombreApellido.Text = "";
                txtLimiteCredito.Text = "";
            }
            else
            {
                MessageBox.Show("Ya no hay espacio para mas datos");
            }
        }

        private void controlarCajaDeTextos()
        {
            if (txtCodigo.Text != "" && txtDeuda.Text != "" && txtNombreApellido.Text != "" && txtLimiteCredito.Text != "")
            {
                btnCargar.Enabled = true;
            }
            else { 
                btnCargar.Enabled = false;
            }
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            controlarCajaDeTextos();
        }

        private void txtDeuda_TextChanged(object sender, EventArgs e)
        {
            controlarCajaDeTextos();
        }

        private void txtNombreApellido_TextChanged(object sender, EventArgs e)
        {
            controlarCajaDeTextos();
        }

        private void txtLimiteCredito_TextChanged(object sender, EventArgs e)
        {
            controlarCajaDeTextos();
        }

        private void frmAgregarNuevoCliente_Load(object sender, EventArgs e)
        {

        }
    }
}
