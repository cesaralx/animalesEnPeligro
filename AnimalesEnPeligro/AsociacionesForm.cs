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
    public partial class AsociacionesForm : Form
    {
        asociaciones asocia = new asociaciones();
        Conexion BD = new Conexion();
        int idDomicilio_ = 0;

        public AsociacionesForm()
        {
            InitializeComponent();
        }

        public AsociacionesForm(int idAsociacion = 0)
        {
            InitializeComponent();

            if (idAsociacion != 0)
            {
                txtIdAsociacion.Text = idAsociacion.ToString();
                buscarAsociacion(idAsociacion);
                
            }
        }

        private void buscarAsociacion(int idObservacion)
        {
            try
            {
                DataSet ds = new DataSet();
                ds = BD.Busca(string.Format("SELECT * from asociaciones WHERE idAsociacion = {0}", idObservacion), "asociaciones");

                foreach (DataRow fila in ds.Tables["asociaciones"].Rows)
                {
                    txtNombre.Text = fila["nombre"].ToString();
                    txtTelefono.Text = fila["telefono"].ToString();
                    idDomicilio_ = Convert.ToInt32(fila["idDomicilio"].ToString());

                    DataSet ds2 = new DataSet();
                    ds2 = BD.Busca(string.Format("SELECT * from domicilios WHERE idDomicilio = {0}", fila["idDomicilio"].ToString()), "domicilios");

                    foreach (DataRow fila2 in ds2.Tables["domicilios"].Rows)
                    {
                        txtCalle.Text = fila2["calle"].ToString();
                        txtNoExterior.Text = fila2["noExterior"].ToString();
                        txtNoInterior.Text = fila2["noInterior"].ToString();
                        txtColonia.Text = fila2["colonia"].ToString();
                        txtCodigoPostal.Text = fila2["codigoPostal"].ToString();
                        txtMunicipio.Text = fila2["municipio"].ToString();
                        txtEstado.Text = fila2["estado"].ToString();
                    }

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

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AsociacionesForm_Load(object sender, EventArgs e)
        {

        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            domicilios domi = new domicilios();

            try
            {


                if (txtIdAsociacion.Text != null)
                {
                    

                    domi.calle = txtCalle.Text;
                    domi.noInterior = txtNoInterior.Text;
                    domi.noExterior = txtNoInterior.Text;
                    domi.colonia = txtColonia.Text;
                    domi.codigoPostal = txtCodigoPostal.Text;
                    domi.municipio = txtMunicipio.Text;
                    domi.estado = txtEstado.Text;
                    domi.registrarDomicilio();

                    DataSet ds = new DataSet();
                    ds = BD.Busca(string.Format("SELECT TOP 1 * FROM domicilios ORDER BY idDomicilio DESC"), "domicilios");
                    foreach (DataRow fila in ds.Tables["domicilios"].Rows)
                    {
                        idDomicilio_ = Convert.ToInt32(fila["idDomicilio"]);

                    }
                    asocia.nombre = txtNombre.Text;
                    asocia.telefono = txtTelefono.Text.ToString();
                    asocia.idDomicilio = idDomicilio_;
                     asocia.registrarAsociacio();
                    //cleanFields();
                }
                else
                {
                    domi.idDomicilio = idDomicilio_;
                    domi.calle = txtCalle.Text;
                    domi.noInterior = txtNoInterior.Text;
                    domi.noExterior = txtNoInterior.Text;
                    domi.colonia = txtColonia.Text;
                    domi.codigoPostal = txtCodigoPostal.Text;
                    domi.municipio = txtMunicipio.Text;
                    domi.estado = txtEstado.Text;
                    domi.modificarDomicilio();


                    asocia.idDomicilio = idDomicilio_;
                    asocia.nombre = txtNombre.Text;
                    asocia.telefono = txtTelefono.Text.ToString();
                    //asocia.idDomicilio = Convert.ToInt32( comboGenero.SelectedItem.ToString() );
                    asocia.idAsociacion = Convert.ToInt32(txtIdAsociacion.Text);


                    asocia.modificarAsociacio();

                }



            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message);
            }

            this.Close();
        }
    }

}
