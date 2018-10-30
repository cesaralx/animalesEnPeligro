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
    public partial class ObservadoresForm : Form
    {
        observadores observador = new observadores();
        Conexion BD = new Conexion();
        int idDomicilio_ = 0;
        int idObservador_ = 0;
        int idUsuario_ = 0;


        public ObservadoresForm()
        {
            InitializeComponent();
            cargaCombos();
            txtCodigo.Text = RandomString(8);
        }

        public ObservadoresForm(int idObservacion = 0)
        {
            InitializeComponent();

            if (idObservacion != 0)
            {
                cargaCombos();
                txtIdObservador.Text = idObservacion.ToString();
                buscarObservador(idObservacion);
            }

        }

        private void buscarObservador(int idObservador)
        {
            try
            {
                DataSet ds = new DataSet();
                ds = BD.Busca(string.Format("SELECT * from observadores WHERE idObservador = {0}", idObservador), "observadores");

                foreach (DataRow fila in ds.Tables["observadores"].Rows)
                {
                    txtCodigo.Text = fila["codigo"].ToString();
                    txtCurp.Text = fila["curp"].ToString();
                    txtNombre.Text = fila["nombre"].ToString();
                    txtApellidos.Text = fila["apellidos"].ToString();
                    comboAsociacion.SelectedValue = fila["idAsociacion"].ToString();
                    comboZonas.SelectedValue = fila["idZona"].ToString();
                    comboEstatus.SelectedValue = fila["idEstatus"].ToString();

                    idObservador_ = Convert.ToInt32(fila["idObservador"].ToString());
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

                    DataSet ds3 = new DataSet();
                    ds3 = BD.Busca(string.Format("SELECT * from usuarios WHERE idObservador = {0}", fila["idObservador"].ToString()), "usuarios");

                    foreach (DataRow fila3 in ds3.Tables["usuarios"].Rows)
                    {
                        txtUsuario.Text = fila3["usuario"].ToString();
                        txtPassword.Text = fila3["password"].ToString();
                        comboPrivilegios.SelectedValue = fila3["idPrivilegio"].ToString();

                        idUsuario_ = Convert.ToInt32(fila3["idUsuario"].ToString());
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

        private static Random random = new Random();
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            domicilios domi = new domicilios();
            usuarios user = new usuarios();

            try
            {


                if (txtIdObservador.Text.Equals(""))
                {
                    

                    domi.calle = txtCalle.Text;
                    domi.noInterior = txtNoInterior.Text;
                    domi.noExterior = txtNoExterior.Text;
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

                    observador.nombre = txtNombre.Text;
                    observador.codigo = txtCodigo.Text.ToString();
                    observador.apellidos = txtApellidos.Text;
                    observador.curp = txtCurp.Text;
                    observador.idDomicilio = idDomicilio_;
                    observador.idZona = Convert.ToInt32( comboZonas.SelectedValue.ToString());
                    observador.idEstatus = Convert.ToInt32( comboEstatus.SelectedValue.ToString());
                    observador.idAsociacion = Convert.ToInt32(comboAsociacion.SelectedValue.ToString());

                    observador.registrarObservadores();
                    //cleanFields();

                    DataSet ds2 = new DataSet();
                    ds2 = BD.Busca(string.Format("SELECT TOP 1 * FROM observadores ORDER BY idObservador DESC"), "observadores");
                    foreach (DataRow fila in ds2.Tables["observadores"].Rows)
                    {
                        idObservador_ = Convert.ToInt32(fila["idObservador"]);
                    }

                    user.usuario = txtUsuario.Text;
                    user.password = txtPassword.Text;
                    user.idEstatus = Convert.ToInt32(comboEstatus.SelectedValue.ToString());
                    user.idObservador = idObservador_;
                    user.idPrivilegios = Convert.ToInt32(comboPrivilegios.SelectedValue.ToString());

                    user.registrarUsuarios();


                }
                else //si es update
                {
                    domi.calle = txtCalle.Text;
                    domi.noInterior = txtNoInterior.Text;
                    domi.noExterior = txtNoExterior.Text;
                    domi.colonia = txtColonia.Text;
                    domi.codigoPostal = txtCodigoPostal.Text;
                    domi.municipio = txtMunicipio.Text;
                    domi.estado = txtEstado.Text;
                    domi.idDomicilio = idDomicilio_;
                    domi.modificarDomicilio();


                    observador.nombre = txtNombre.Text;
                    observador.codigo = txtCodigo.Text.ToString();
                    observador.apellidos = txtApellidos.Text;
                    observador.curp = txtCurp.Text;
                    observador.idDomicilio = idDomicilio_; //cambiar
                    observador.idZona = Convert.ToInt32(comboZonas.SelectedValue.ToString());
                    observador.idEstatus = Convert.ToInt32(comboEstatus.SelectedValue.ToString());
                    observador.idAsociacion = Convert.ToInt32(comboAsociacion.SelectedValue.ToString());
                    observador.idObservador = idObservador_;

                    observador.modificarObservadores();
                    //cleanFields();


                    user.usuario = txtUsuario.Text;
                    user.password = txtPassword.Text;
                    user.idEstatus = Convert.ToInt32(comboEstatus.SelectedValue.ToString());
                    user.idObservador = idObservador_; //cambiar
                    user.idPrivilegios = Convert.ToInt32(comboPrivilegios.SelectedValue.ToString());
                    user.idUsuario = idUsuario_;

                    user.modificarUsuarios();

                }



            }
            catch (Exception ex)
            {
                MessageBox.Show( ex.Message);
            }

            this.Close();
        }

        private void ObservadoresForm_Load(object sender, EventArgs e)
        {
            txtCodigo.Focus();


        }

        private void cargaCombos()
        {
            try
            {
                DataSet ds = new DataSet();
                DataSet ds2 = new DataSet();
                DataSet ds3 = new DataSet();
                DataSet ds4 = new DataSet();

                ds = BD.Busca(string.Format("SELECT idAsociacion, nombre from asociaciones"), "asociaciones");
                ds2 = BD.Busca(string.Format("SELECT idZona, nombre from zonas"), "zonas");
                ds3= BD.Busca(string.Format("SELECT idEstatus, descripcion from estatus"), "estatus");
                ds4 = BD.Busca(string.Format("SELECT idPrivilegio, descripcion from privilegios"), "privilegios");

                comboAsociacion.DisplayMember = "nombre";
                comboAsociacion.ValueMember = "idAsociacion";
                comboAsociacion.DataSource = ds.Tables["asociaciones"];

                comboZonas.DisplayMember = "nombre";
                comboZonas.ValueMember = "idZona";
                comboZonas.DataSource = ds2.Tables["zonas"];

                comboEstatus.DisplayMember = "descripcion";
                comboEstatus.ValueMember = "idEstatus";
                comboEstatus.DataSource = ds3.Tables["estatus"];

                comboPrivilegios.DisplayMember = "descripcion";
                comboPrivilegios.ValueMember = "idPrivilegio";
                comboPrivilegios.DataSource = ds4.Tables["privilegios"];

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

        private void txtIdObservador_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            if (e.KeyChar == 13)
            {
                comboAsociacion.Focus();
            }
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
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
                txtApellidos.Focus();
            }
        }

        private void txtApellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }

            if (e.KeyChar == 13)
            {
                txtCurp.Focus();
            }
        }

        private void txtCurp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) )
            {
                e.Handled = true;
            }

            if (e.KeyChar == 13)
            {
                comboZonas.Focus();
            }
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtPassword.Focus();
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                comboPrivilegios.Focus();
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

            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsDigit(e.KeyChar))
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
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            if (e.KeyChar == 13)
            {
                btnAlta.Focus();
            }
        }

        private void txtCodigo_Validating(object sender, CancelEventArgs e)
        {
            if (txtCodigo.Text.Length == 0)
            {
                this.errorProvider1.SetError(txtCodigo, "Este campo no puede quedar en blanco");
            }
        }

        private void txtNombre_Validating(object sender, CancelEventArgs e)
        {
            if (txtNombre.Text.Length == 0)
            {
                this.errorProvider1.SetError(txtNombre, "Este campo no puede quedar en blanco");
            }
        }

        private void txtApellidos_Validating(object sender, CancelEventArgs e)
        {
            if (txtApellidos.Text.Length == 0)
            {
                this.errorProvider1.SetError(txtApellidos, "Este campo no puede quedar en blanco");
            }
        }

        private void txtCurp_Validating(object sender, CancelEventArgs e)
        {
            if (txtCurp.Text.Length == 0)
            {
                this.errorProvider1.SetError(txtCurp, "Este campo no puede quedar en blanco");
            }
        }

        private void txtUsuario_Validating(object sender, CancelEventArgs e)
        {
            if(txtUsuario.Text.Length == 0)
            {
                this.errorProvider1.SetError(txtUsuario, "Este campo no puede quedar en blanco");
            }
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if(txtPassword.Text.Length == 0)
            {
                this.errorProvider1.SetError(txtPassword, "Este campo no puede quedar en blanco");
            }
        }

        private void txtCalle_Validating(object sender, CancelEventArgs e)
        {
            if(txtCalle.Text.Length == 0)
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

        private void txtPassword_OnValueChanged(object sender, EventArgs e)
        {
            txtPassword.isPassword = true;
        }

        private void txtApellidos_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
    }

