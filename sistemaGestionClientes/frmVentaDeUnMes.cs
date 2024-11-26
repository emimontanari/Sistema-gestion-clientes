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
    public partial class frmVentaDeUnMes : Form
    {
        public frmVentaDeUnMes()
        {
            InitializeComponent();
        }

        private void frmVentaDeUnMes_Load(object sender, EventArgs e)
        {
            cmbMes.Items.Clear();
            for (int i = 0; i < Vector.sucursales.Length; i++)
            {
                cmbMes.Items.Add(Vector.sucursales[i]);
            }
            cmbMes.SelectedIndex = 0;
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            Decimal Total = 0;
            Int32 c = cmbMes.SelectedIndex;
            Int32 cantidad = 0;
            Grilla.Rows.Clear();
            for (Int32 f = 0; f < Vector.sucursales.Length; f++)
            {
                Grilla.Rows.Add(Vector.sucursales[c], matriz.ventas[f, c]);
                Total = Total + matriz.ventas[f, c];
                cantidad ++;
            }
            lblVentasResultado.Text = Total.ToString();
            lblPromedioResultado.Text = (Total / cantidad).ToString("0.##");
        }
    }
}
