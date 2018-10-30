using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;

namespace AnimalesEnPeligro
{
    public partial class ObservacionesCmp : UserControl
    {
        observaciones observa = new observaciones();
        Conexion BD = new Conexion();

        public ObservacionesCmp()
        {
            InitializeComponent();
        }


        private void btnAlta_Click(object sender, EventArgs e)
        {
            ObservacionesForm observaAlta = new ObservacionesForm();
            observaAlta.Show(this);
            observaAlta.FormClosed += new FormClosedEventHandler(refreshGrid);

        }

        private void refreshGrid(object sender, FormClosedEventArgs e)
        {
            observa.MuestraDataObservaciones(dgObservaciones);

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                var idObservacion = dgObservaciones.CurrentRow.Cells[0].Value.ToString();
                ObservacionesForm observaModi = new ObservacionesForm(Convert.ToInt32(idObservacion));
                observaModi.Show(this);
                observaModi.FormClosed += new FormClosedEventHandler(refreshGrid);
            }
            catch(Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message);
            }

        }

        private void ObservacionesCmp_Load(object sender, EventArgs e)
        {
            observa.MuestraDataObservaciones(dgObservaciones);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                var idObservacion = dgObservaciones.CurrentRow.Cells[0].Value.ToString();
                observa.deleteObservaciones(Convert.ToInt32(idObservacion));
                observa.MuestraDataObservaciones(dgObservaciones);
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message);
            }
        }
    }
}
