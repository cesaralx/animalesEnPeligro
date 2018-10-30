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
            cargraCombos();
        }

        public ObservacionesForm(int idObservacion = 0)
        {
            InitializeComponent();

            if (idObservacion != 0)
            {
                cargraCombos();
                txtIdObservador.Text = idObservacion.ToString();
                buscarObservacion(idObservacion);

            }


        }

        private void cargraCombos(){
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

        private void ObservacionesForm_Load(object sender, EventArgs e)
        {
        }



        private void buscarObservacion(int idObservacion)
        {
            try
            {
                DataSet ds = new DataSet();
                ds = BD.Busca(string.Format("SELECT * from observaciones WHERE idObservacion = {0}", idObservacion), "observaciones");

                foreach (DataRow fila in ds.Tables["observaciones"].Rows)
                {
                    comboObservador.SelectedValue = fila["idObservador"].ToString();
                    comboEspecie.SelectedValue = fila["idEspecie"].ToString();
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
                if (txtIdObservador.Text == "")
                {
                    observa.idObservador = Convert.ToInt32(comboObservador.SelectedValue.ToString());
                    observa.idEspecie = Convert.ToInt32(comboEspecie.SelectedValue.ToString());
                    observa.cantidad = Convert.ToInt32(txtCantidad.Text);
                    observa.fecha = metroDateFecha.Value.Date;
                    observa.detalle = richTexBoxDetalle.Text;
                    observa.registrarObservaciones();
                }
                else
                {
                    observa.idObservador = Convert.ToInt32(comboObservador.SelectedValue.ToString());
                    observa.idEspecie = Convert.ToInt32(comboEspecie.SelectedValue.ToString());
                    observa.cantidad = Convert.ToInt32(txtCantidad.Text);
                    observa.fecha = metroDateFecha.Value.Date;
                    observa.detalle = richTexBoxDetalle.Text;
                    observa.idObservacion = Convert.ToInt32(txtIdObservador.Text);
                    observa.modificarObservaciones();
                }


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

        private void txtIdObservador_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            if (e.KeyChar == 13)
            {
                comboObservador.Focus();
            }
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            if (e.KeyChar == 13)
            {
                metroDateFecha.Focus();
            }
        }

    

        private void txtCantidad_Validating(object sender, CancelEventArgs e)
        {
            if (txtCantidad.Text.Length == 0)
            {
                this.errorProvider1.SetError(txtCantidad, "Este campo no puede quedar en blanco");
            }
        }

        private void richTexBoxDetalle_Validating(object sender, CancelEventArgs e)
        {
            if (richTexBoxDetalle.Text.Length == 0)
            {
                this.errorProvider1.SetError(richTexBoxDetalle, "Este campo no puede quedar en blanco");
            }
        }

        private void richTexBoxDetalle_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnAlta.Focus();
            }
        }
    }
}
