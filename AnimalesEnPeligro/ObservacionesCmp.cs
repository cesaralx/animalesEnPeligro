using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimalesEnPeligro
{
    public partial class ObservacionesCmp : UserControl
    {
        public ObservacionesCmp()
        {
            InitializeComponent();
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            ObservacionesForm observaAlta = new ObservacionesForm();
            observaAlta.ShowDialog(this);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ObservacionesForm observaModi = new ObservacionesForm();
            observaModi.ShowDialog(this);
        }
    }
}
