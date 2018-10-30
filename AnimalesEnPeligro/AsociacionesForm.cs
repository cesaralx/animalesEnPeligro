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


                if (txtIdAsociacion.Text == "")
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

        private void AsociacionesForm_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void txtIdAsociacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            if (e.KeyChar == 13)
            {
                txtNombre.Focus();
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }

            if (e.KeyChar == 13)
            {
                txtTelefono.Focus();
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            if (e.KeyChar == 13)
            {
                txtCalle.Focus();
            }
        }

        private void txtCalle_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            if (e.KeyChar == 13)
            {
                txtNoExterior.Focus();
            }
        }

        private void txtColonia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            if (e.KeyChar == 13)
            {
                txtCodigoPostal.Focus();
            }
        }

        private void txtNoExterior_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtNoInterior.Focus();
            }
        }

        private void txtNoInterior_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtColonia.Focus();
            }
        }

        private void txtCodigoPostal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            if (e.KeyChar == 13)
            {
                txtMunicipio.Focus();
            }
        }

        private void txtMunicipio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }

            if (e.KeyChar == 13)
            {
                txtEstado.Focus();
            }

        }

        private void txtEstado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }

            if (e.KeyChar == 13)
            {
                btnAlta.Focus();
            }
        }

        private void txtNombre_Validating(object sender, CancelEventArgs e)
        {
            if (txtNombre.Text.Length == 0)
            {
                this.errorProvider1.SetError(txtNombre, "Este campo no puede quedar en blanco");
            }
        }

        private void txtTelefono_Validating(object sender, CancelEventArgs e)
        {
            if (txtTelefono.Text.Length == 0)
            {
                this.errorProvider1.SetError(txtTelefono, "Este campo no puede quedar en blanco");
            }
        }

        private void txtCalle_Validating(object sender, CancelEventArgs e)
        {
            if (txtCalle.Text.Length == 0)
            {
                this.errorProvider1.SetError(txtCalle, "Este campo no puede quedar en blanco");
            }
        }

        private void txtNoExterior_Validating(object sender, CancelEventArgs e)
        {
            if (txtNoExterior.Text.Length == 0)
            {
                this.errorProvider1.SetError(txtNoExterior, "Este campo no puede quedar en blanco");
            }
        }

        private void txtColonia_Validating(object sender, CancelEventArgs e)
        {
            if (txtColonia.Text.Length == 0)
            {
                this.errorProvider1.SetError(txtColonia, "Este campo no puede quedar en blanco");
            }
        }

        private void txtCodigoPostal_Validating(object sender, CancelEventArgs e)
        {
            if (txtCodigoPostal.Text.Length == 0)
            {
                this.errorProvider1.SetError(txtCodigoPostal, "Este campo no puede quedar en blanco");
            }
        }

        private void txtMunicipio_Validating(object sender, CancelEventArgs e)
        {
            if (txtMunicipio.Text.Length == 0)
            {
                this.errorProvider1.SetError(txtMunicipio, "Este campo no puede quedar en blanco");
            }
        }

        private void txtEstado_Validating(object sender, CancelEventArgs e)
        {
            if (txtEstado.Text.Length == 0)
            {
                this.errorProvider1.SetError(txtEstado, "Este campo no puede quedar en blanco");
            }
        }
    }

}
