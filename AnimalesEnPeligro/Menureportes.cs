using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AnimalesEnPeligro.formReportes;
using AnimalesEnPeligro.Datasets;
using System.Data.SqlClient;

namespace AnimalesEnPeligro
{
    public partial class Menureportes : UserControl
    {
        Conexion db = new Conexion();

        public Menureportes()
        {
            InitializeComponent();
            dt1.Value = DateTime.Today.AddDays(-30);
        }

        private void btnReporte1_Click(object sender, EventArgs e)
        {
            DsReporte1 dsProd = new DsReporte1();

            string date1 = dt1.Value.Date.ToString("yyyy-MM-dd"), date2 = dt2.Value.Date.ToString("yyyy-MM-dd");

            //MessageBox.Show(date1 + " " + date2);
            try
            {
                DataSet ds = new DataSet();
                var query = string.Format("SELECT  u.usuario, CONCAT(ob.nombre, ' ',  ob.apellidos) as ObservadorName, ob.curp, espe.nombreCientifico, " +
                    "espe.nombreVulgar, espe.genero, obse.cantidad, obse.fecha, espe.img, z.nombre as zonaNombre, z.estado, z.municipio from usuarios u " +
                    "inner join observadores ob " +
                    "on ob.idObservador = u.idObservador " +
                    "inner join observaciones obse " +
                    "on obse.idObservador = ob.idObservador " +
                    "inner join zonas z " +
                    "on z.idZona = ob.idzona " +
                    "inner join especies espe " +
                    "on espe.idEspecie = obse.idEspecie where obse.fecha BETWEEN '{0}' and '{1}' ", date1 ?? "1400-01-01", date2 ?? "5000-01-01");

                ds = db.Busca(query, "especies");

                if (ds.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("No se encontró ningun resultado", "Busqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    foreach (DataRow fila in ds.Tables["especies"].Rows)
                    {
                        Byte[] bytes = (Byte[])fila["img"];

                        dsProd.dtUsuariosRep1.Rows.Add(fila["usuario"].ToString(), fila["ObservadorName"].ToString(), fila["curp"].ToString(),
                            fila["nombreCientifico"].ToString(), fila["nombreVulgar"].ToString(), fila["genero"].ToString(), fila["cantidad"].ToString(),
                             fila["fecha"].ToString(), bytes, fila["zonaNombre"].ToString(), fila["estado"].ToString(), fila["municipio"].ToString());
                    }


                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Conexion.conn.Close();
            }


            ReporteUno rep1 = new ReporteUno(dsProd.dtUsuariosRep1);
            rep1.ShowDialog();
        }

        private void Menureportes_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DsReporte2 dsProd = new DsReporte2();

            try
            {
                DataSet ds = new DataSet();
                var query = "SELECT ob.codigo, CONCAT(ob.nombre,' ',ob.apellidos) AS nombreCompleto, CONCAT(dom.calle , ' ', dom.colonia, ' ', dom.municipio, ' ', dom.estado ) AS direccion,  " +
                    "obse.idObservacion, z.estado AS zonaEstado, aso.nombre AS asoNombre " +
                    "FROM observadores ob " +
                    "JOIN observaciones obse " +
                    "ON obse.idObservador = ob.idObservador " +
                    "JOIN zonas z " +
                    "ON z.idZona = ob.idZona " +
                    "JOIN domicilios dom " +
                    "ON dom.idDomicilio = ob.idDomicilio " +
                    "JOIN asociaciones aso " +
                    "ON aso.idAsociacion = ob.idAsociacion ";
                ds = db.Busca(query, "observadores");

                if (ds.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("No se encontró ningun resultado", "Busqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    foreach (DataRow fila in ds.Tables["observadores"].Rows)
                    {

                        dsProd.dtObservadores.Rows.Add(fila["codigo"].ToString(), fila["nombreCompleto"].ToString(), fila["direccion"].ToString(),
                            fila["idObservacion"].ToString(), fila["zonaEstado"].ToString(), fila["asoNombre"].ToString());
                    }


                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Conexion.conn.Close();
            }


            ReporteDos rep2 = new ReporteDos(dsProd.dtObservadores);
            rep2.ShowDialog();


        }
    }
}
