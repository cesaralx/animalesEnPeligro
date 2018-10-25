using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimalesEnPeligro
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnMenuDesplegable_Click(object sender, EventArgs e)
        {
            if(panelSidebar.Width == 211)
            {
                panelSidebar.Width = 71;
            }
            else
            {
                panelSidebar.Width = 211;
            }
            bunifuTransition1.ShowSync(panelSidebar);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            // Login log = new Login();
            DialogResult resul = MessageBox.Show("¿Seguro que quieres Salir?", "Salir", MessageBoxButtons.YesNo);

            if (resul == DialogResult.Yes)
            {
                Application.Exit();
                // this.Hide();
                //log.Show();
            }
        }

        private void btnEspecies_Click(object sender, EventArgs e)
        {
            panelEspecies.Visible = true;
            panelAsociaciones.Visible = false;
            panelObservaciones.Visible = false;
            panelObservadores.Visible = false;
            panelReportes.Visible = false;
            panelZonas.Visible = false;
            especieCmp1.BringToFront();
        }

        private void btnZonas_Click(object sender, EventArgs e)
        {
            panelEspecies.Visible = false;
            panelAsociaciones.Visible = false;
            panelObservaciones.Visible = false;
            panelObservadores.Visible = false;
            panelReportes.Visible = false;
            panelZonas.Visible = true;
            zonasCmp1.BringToFront();
        }
    }
}
