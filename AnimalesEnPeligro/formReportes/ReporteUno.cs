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
using CrystalDecisions.Shared;

namespace AnimalesEnPeligro.formReportes
{
    public partial class ReporteUno : Form
    {
        Reporte1 CRProd = new Reporte1();

        public ReporteUno(DataTable dt, string date1, string date2)
        {
            ParameterFields paramFields = new ParameterFields();


            InitializeComponent();
            CRProd.SetDataSource(dt);

            ParameterField paramField = new ParameterField();
            ParameterDiscreteValue paramDiscreteValue = new ParameterDiscreteValue();
            paramField.Name = "@Date1";
            paramDiscreteValue.Value = date1;
            paramField.CurrentValues.Add(paramDiscreteValue);
            paramFields.Add(paramField);

            paramField = new ParameterField(); // <-- This line is added
            paramDiscreteValue = new ParameterDiscreteValue();  // <-- This line is added
            paramField.Name = "@Date2";
            paramDiscreteValue.Value = date2;
            paramField.CurrentValues.Add(paramDiscreteValue);
            paramFields.Add(paramField);


            //CRProd.SetParameterValue("@Date1", date1);
            //CRProd.SetParameterValue("@Date2", date2);

            crystalReportViewer1.ParameterFieldInfo = paramFields;
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
