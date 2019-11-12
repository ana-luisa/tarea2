using BL_Fiestas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fiestas
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void resarvasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formLogin = new FormLogin();
            formLogin.ShowDialog();

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mesasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formgaleria = new FormGaleria();
            formgaleria.ShowDialog();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            var formLogin = new FormLogin();
            formLogin.ShowDialog();
        }

        private void contratoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mesasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var formReservar = new FormReservar();
            formReservar.ShowDialog();
        }

        private void politicasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formPolitica = new FormPolitica();
            formPolitica.ShowDialog();
        }

        private void contratoFinalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formContrato = new FormContrato();
            formContrato.ShowDialog();
        }

        private void sociosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formSocios = new FormSocios();
            formSocios.ShowDialog();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formClientes = new FormCliente();
            formClientes.ShowDialog();
        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var ReporteCliente = new ReporteCliente();
            ReporteCliente.ShowDialog();
        }

        private void sociosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var reporteSocios = new ReportoSocios();
            reporteSocios.ShowDialog();
        }

        private void reservasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var reporteReservas = new ReporteReservas();
            reporteReservas.ShowDialog();
        }
    }
}
