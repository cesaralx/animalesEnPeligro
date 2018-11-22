using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AnimalesEnPeligro.Reportes;

namespace AnimalesEnPeligro.formReportes
{
    public partial class ReporteUno : Form
    {
        Reporte1 CRProd = new Reporte1();

        public ReporteUno(DataTable dt)
        {
            InitializeComponent();
            CRProd.SetDataSource(dt);
            crystalReportViewer1.ReportSource = CRProd;
        }

        private void ReporteUno_Load(object sender, EventArgs e)
        {

        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
