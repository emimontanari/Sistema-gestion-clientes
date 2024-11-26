using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistemaGestionClientes
{
    public partial class frmVentasDeUnaSucursal : Form
    {
        public frmVentasDeUnaSucursal()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            Decimal Total = 0;
            Int32 c = cmbSucursal.SelectedIndex;
            Grilla.Rows.Clear();
            for (Int32 f = 0; f < Vector.meses.Length; f++)
            {
                Grilla.Rows.Add(Vector.meses[f], matriz.ventas[f, c]);
                Total = Total + matriz.ventas[f, c];
            }
            lblVentasResultado.Text = Total.ToString();
            lblPromedioResultado.Text = (Total / 12).ToString("0.00");
        }

        private void frmVentasDeUnaSucursal_Load(object sender, EventArgs e)
        {
            cmbSucursal.Items.Clear();
            for (Int32 i = 0; i < Vector.sucursales.Length; i++)
            {
                cmbSucursal.Items.Add(Vector.sucursales[i]);
            }
            cmbSucursal.SelectedIndex = 0;
        }

      
    }
}
