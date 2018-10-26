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
    public partial class ObservadoresCmp : UserControl
    {
        observadores observa = new observadores();
        Conexion BD = new Conexion();

        public ObservadoresCmp()
        {
            InitializeComponent();
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            ObservadoresForm observaAlta = new ObservadoresForm();
            observaAlta.Show(this);
            observaAlta.FormClosed += new FormClosedEventHandler(refreshGrid);

        }

        private void refreshGrid(object sender, FormClosedEventArgs e)
        {
            observa.MuestraDataObservadores(dataObservadores);

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            

            try
            {
                var idObservacion = dataObservadores.CurrentRow.Cells[0].Value.ToString();
                ObservadoresForm observaModi = new ObservadoresForm(Convert.ToInt32(idObservacion));
                observaModi.Show(this);
                observaModi.FormClosed += new FormClosedEventHandler(refreshGrid);

            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message);
            }

        }

        private void ObservadoresCmp_Load(object sender, EventArgs e)
        {
            observa.MuestraDataObservadores(dataObservadores);
        }

 

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                var idObservacion = dataObservadores.CurrentRow.Cells[0].Value.ToString();
                observa.deleteObservadores(Convert.ToInt32(idObservacion));
                observa.MuestraDataObservadores(dataObservadores);
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message);
            }
        }
    }
}
