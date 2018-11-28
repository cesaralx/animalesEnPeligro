using MetroFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimalesEnPeligro
{
    public partial class Login : Form
    {
        private splash spl = new splash();
        usuarios usu = new usuarios();
        Conexion BD = new Conexion();
        Menu menu = new Menu();

        ToolTip ToolTip1 = new ToolTip();


        public Login(Boolean h = true)
        {
            InitializeComponent();
            this.TransparencyKey = (BackColor);

                if (h)
                {
                    try
                    {
                        Thread hilo = new Thread(new ThreadStart(iniciarSplash));
                        hilo.Start();
                        Thread.Sleep(3500);
                        hilo.Abort();
                        this.TopMost = true;
                        this.BringToFront();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al iniciar componentes " + ex);
                    }
            }


        }

        public void iniciarSplash()
        {
            Application.Run(spl);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnIniciarSecion_Click(object sender, EventArgs e)
        {

            try
            {
                DataSet ds = new DataSet();
                ds = BD.Busca(string.Format("SELECT TOP 1 * FROM usuarios where usuario='"+txtUsuario.Text+"'"), "usuarios");

                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {

                    foreach (DataRow fila in ds.Tables["usuarios"].Rows)
                    {

                        usu.usuario = fila["usuario"].ToString();
                        usu.password = fila["password"].ToString();
                        usu.idPrivilegios = Convert.ToInt32(fila["idPrivilegio"]);

                    }

                    if (usu.password.Equals(txtPassword.Text))
                    {
                        Program.cargo = usu.idPrivilegios;
                        this.Hide();
                        menu.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        if (usu.usuario.Equals(txtUsuario.Text))
                        {
                            MetroMessageBox.Show(this, "Contraseña incorrecta");
                            Shake(txtPassword);
                        }
                        else
                        {
                            MetroMessageBox.Show(this, "Usuario incorrecto");
                            Shake(txtUsuario);
                        }

                    }
                }
                else
                {
                    MetroMessageBox.Show(this, "Usuario no encontrado");

                }



            }
            catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
            finally
            {
                Conexion.conn.Close();
            }
            
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtPassword.Focus();
                txtPassword.Text = "";
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnIniciarSecion.Focus();
                btnIniciarSecion_Click(sender,e);
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtUsuario.Focus();
        }

        private static void Shake(Bunifu.Framework.UI.BunifuMaterialTextbox form)
        {
            var original = form.Location;
            var rnd = new Random(1337);
            const int shake_amplitude = 10;
            for (int i = 0; i < 10; i++)
            {
                form.Location = new Point(original.X + rnd.Next(-shake_amplitude, shake_amplitude), original.Y + rnd.Next(-shake_amplitude, shake_amplitude));
                System.Threading.Thread.Sleep(20);
            }
            form.Location = original;
        }

        private void btnConfiguration_MouseHover(object sender, EventArgs e)
        {
            ToolTip1.SetToolTip(btnConfiguration, "Configuración");
        }

        private void btnConfiguration_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_OnValueChanged(object sender, EventArgs e)
        {
            txtPassword.isPassword = true;
        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
