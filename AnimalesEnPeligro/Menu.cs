using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace AnimalesEnPeligro
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void btnMenuDesplegable_Click(object sender, EventArgs e)
        {
            if (panelSidebar.Width == 211)
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

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnMaximizar.Visible = true;
            btnRestaurar.Visible = false;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnAsociaciones_Click(object sender, EventArgs e)
        {
            panelEspecies.Visible = false;
            panelAsociaciones.Visible = true;
            panelObservaciones.Visible = false;
            panelObservadores.Visible = false;
            panelReportes.Visible = false;
            panelZonas.Visible = false;
            asociacionesCmp1.BringToFront();
        }

        private void btnObservadores_Click(object sender, EventArgs e)
        {
            panelEspecies.Visible = false;
            panelAsociaciones.Visible = false;
            panelObservaciones.Visible = false;
            panelObservadores.Visible = true;
            panelReportes.Visible = false;
            panelZonas.Visible = false;
            observadoresCmp1.BringToFront();
        }

        private void btnObservaciones_Click(object sender, EventArgs e)
        {
            panelEspecies.Visible = false;
            panelAsociaciones.Visible = false;
            panelObservaciones.Visible = true;
            panelObservadores.Visible = false;
            panelReportes.Visible = false;
            panelZonas.Visible = false;
            observacionesCmp1.BringToFront();
        }
    }
}
