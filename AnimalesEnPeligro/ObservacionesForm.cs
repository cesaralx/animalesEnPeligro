using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;

namespace AnimalesEnPeligro
{
    public partial class ObservacionesForm : Form
    {
        observaciones observa = new observaciones();
        Conexion BD = new Conexion();

        public ObservacionesForm()
        {
            InitializeComponent();
        }

        public ObservacionesForm(int idObservacion = 0)
        {
            InitializeComponent();

            if (idObservacion != 0)
            {
                txtIdObservador.Text = idObservacion.ToString();
                buscarObservacion(idObservacion);
            }
            
            
        }

        private void ObservacionesForm_Load(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = new DataSet();
                DataSet ds2 = new DataSet();
                ds = BD.Busca(string.Format("SELECT idEspecie, nombreCientifico, genero from especies"), "especies");

                comboEspecie.DisplayMember = "nombreCientifico";
                comboEspecie.ValueMember = "idEspecie";
                comboEspecie.DataSource = ds.Tables["especies"];

                ds2 = BD.Busca(string.Format("SELECT idObservador, nombre from observadores"), "observadores");

                comboObservador.DisplayMember = "nombre";
                comboObservador.ValueMember = "idObservador";
                comboObservador.DataSource = ds2.Tables["observadores"];

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Conexion.conn.Close();
            }

           

        }



        private void buscarObservacion(int idObservacion)
        {
            try
            {
                DataSet ds = new DataSet();
                ds = BD.Busca(string.Format("SELECT * from observaciones WHERE idObservacion = {0}", idObservacion), "observaciones");

                foreach (DataRow fila in ds.Tables["observaciones"].Rows)
                {
                    comboObservador.SelectedItem = fila["idObservador"].ToString();
                    comboEspecie.SelectedItem = fila["idEspecie"].ToString();
                    txtCantidad.Text = fila["cantidad"].ToString();
                    metroDateFecha.Text = fila["fecha"].ToString();
                    richTexBoxDetalle.Text = fila["detalle"].ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Conexion.conn.Close();
            }
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            try
            {
                observa.idObservador = Convert.ToInt32( comboObservador.SelectedValue.ToString() );
                observa.idEspecie = Convert.ToInt32( comboEspecie.SelectedValue.ToString());
                observa.cantidad = Convert.ToInt32( txtCantidad.Text);
                observa.fecha = metroDateFecha.Value.Date;
                observa.detalle = richTexBoxDetalle.Text;
                observa.registrarObservaciones();
                //cleanFields();


            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message);
            }

            this.Close();
        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
