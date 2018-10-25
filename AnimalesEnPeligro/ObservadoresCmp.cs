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
    public partial class ObservadoresCmp : UserControl
    {
        public ObservadoresCmp()
        {
            InitializeComponent();
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            ObservadoresForm observaAlta = new ObservadoresForm();
            observaAlta.ShowDialog(this);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ObservadoresForm observaModi = new ObservadoresForm();
            observaModi.ShowDialog(this);
        }
    }
}
