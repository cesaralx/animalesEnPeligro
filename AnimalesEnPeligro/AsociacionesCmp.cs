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
    public partial class AsociacionesCmp : UserControl
    {
        public AsociacionesCmp()
        {
            InitializeComponent();
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            AsociacionesForm alta = new AsociacionesForm();
            alta.ShowDialog(this);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            AsociacionesForm modi = new AsociacionesForm();
            modi.ShowDialog(this);
        }
    }
}
