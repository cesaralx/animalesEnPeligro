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


        public ObservadoresForm()
        {
            InitializeComponent();
        }

        public ObservadoresForm(int idObservacion = 0)
        {
            InitializeComponent();

            if (idObservacion != 0)
            {
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

        private void btnAlta_Click(object sender, EventArgs e)
        {
            domicilios domi = new domicilios();
            usuarios user = new usuarios();

            try
            {


                if (txtIdObservador.Text == "")
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
                else
                {
                    domi.calle = txtCalle.Text;
                    domi.noInterior = txtNoInterior.Text;
                    domi.noExterior = txtNoExterior.Text;
                    domi.colonia = txtColonia.Text;
                    domi.codigoPostal = txtCodigoPostal.Text;
                    domi.municipio = txtMunicipio.Text;
                    domi.estado = txtEstado.Text;
                    domi.modificarDomicilio();


                    observador.nombre = txtNombre.Text;
                    observador.codigo = txtCodigo.Text.ToString();
                    observador.apellidos = txtApellidos.Text;
                    observador.curp = txtCurp.Text;
                    observador.idDomicilio = idDomicilio_; //cambiar
                    observador.idZona = Convert.ToInt32(comboZonas.SelectedValue.ToString());
                    observador.idEstatus = Convert.ToInt32(comboEstatus.SelectedValue.ToString());
                    observador.idAsociacion = Convert.ToInt32(comboAsociacion.SelectedValue.ToString());

                    observador.modificarObservadores();
                    //cleanFields();


                    user.usuario = txtUsuario.Text;
                    user.password = txtPassword.Text;
                    user.idEstatus = Convert.ToInt32(comboEstatus.SelectedValue.ToString());
                    user.idObservador = idObservador_; //cambiar
                    user.idPrivilegios = Convert.ToInt32(comboPrivilegios.SelectedValue.ToString());

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
            cargaCombos();

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

    }
}
