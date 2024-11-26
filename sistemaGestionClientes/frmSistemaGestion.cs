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
    public partial class frmSistemaGestion : Form
    {
        public frmSistemaGestion()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAcercaDe ventana = new frmAcercaDe();
            ventana.ShowDialog();
        }

        private void agregarNuevosClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAgregarNuevoCliente ventana = new frmAgregarNuevoCliente();
            ventana.ShowDialog();
        }

        private void buscarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBuscarCliente ventana = new frmBuscarCliente();
            ventana.ShowDialog();
        }

        private void consultaDeUnClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaDeUnCliente ventana = new frmConsultaDeUnCliente();
            ventana.ShowDialog();
        }

        private void listadoDeTodosLosClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListadoDeTodosLosClientes ventana = new frmListadoDeTodosLosClientes();
            ventana.ShowDialog();
        }

        private void listadoDeClientesDeudoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListadoDeClientesDeudores ventana = new frmListadoDeClientesDeudores();
            ventana.ShowDialog();
        }



        private void frmSistemaGestion_Load(object sender, EventArgs e)
        {
            Vector.cliente[0].codigo = 10;
            Vector.cliente[0].nombre = "Eliel";
            Vector.cliente[0].deuda = 100;
            Vector.cliente[0].limite = 1000;

            Vector.cliente[0].codigo = 20;
            Vector.cliente[0].nombre = "Facu";
            Vector.cliente[0].deuda = 300;
            Vector.cliente[0].limite = 3000;

            Vector.cliente[0].codigo = 30;
            Vector.cliente[0].nombre = "Eva";
            Vector.cliente[0].deuda = 0;
            Vector.cliente[0].limite = 2000;

            Vector.IND = 3;
        }

        private void cToolStripMenuItem_Click(object sender, EventArgs e)
        {       
                frmCargarUnaVenta ventana = new frmCargarUnaVenta();
                ventana.ShowDialog();       
        }

        private void consultarUnaVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultarUnaVenta ventana = new frmConsultarUnaVenta();
            ventana.ShowDialog();
        }

        private void adicionarUnValorAUnaVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdicionarValorVenta ventana = new frmAdicionarValorVenta();
            ventana.ShowDialog();
        }

        private void ventasDeUnaSucursalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVentasDeUnaSucursal ventana = new frmVentasDeUnaSucursal();
            ventana.ShowDialog();
        }

        private void ventasDeUnMesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVentaDeUnMes ventana = new frmVentaDeUnMes();
            ventana.ShowDialog();
        }

        private void consultarTotalGeneralToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsutalTotalGeneral ventana = new frmConsutalTotalGeneral();
            ventana.ShowDialog();
        }

        private void borrarTodosLosDatosDeLaMatrizToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBorrarDatosDeLaMatriz ventana = new frmBorrarDatosDeLaMatriz();
            ventana.ShowDialog();
        }
    }
}
