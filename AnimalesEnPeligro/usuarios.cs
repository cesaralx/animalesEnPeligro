using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroFramework;
using System.Windows.Forms;
using System.Data;

namespace AnimalesEnPeligro
{
    class usuarios
    {
        Conexion BD = new Conexion();
        int res = -1;

        public int idUsuario { get; set; }
        public string usuario { get; set; }
        public string password { get; set; }
        public int idEstatus { get; set; }
        public int idObservador { get; set; }
        public int idPrivilegios { get; set; }


        public void deleteUsuarios(int idUsuario)
        {
            try
            {
                string eliminar = string.Format("DELETE FROM usuarios WHERE idUsuario={0}", idUsuario.ToString());

                res = BD.ABM(eliminar);

                if (res == 1)
                {
                    MessageBox.Show("Se ha eliminado registro con codigo " + idUsuario.ToString(), "Bajas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                MessageBox.Show( ex.Message, "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                Conexion.conn.Close();
            }
        }



        public void MuestraUsuarios(DataGridView dgv)
        {
            DataSet datos = new DataSet();
            datos = BD.ConsultaTab("usuarios", "idUsuario");
            dgv.DataSource = datos.Tables["usuarios"];

        }

        public void registrarUsuarios()
        {
            try
            {
                string insertar = string.Format("INSERT INTO usuarios VALUES( '{0}', '{1}', '{2}', '{3}', '{4}')", this.usuario, this.password,
                    this.idEstatus, this.idObservador, this.idPrivilegios);

                res = BD.ABM(insertar);

                if (res == 1)
                {
                    MessageBox.Show( "Se ha agregado un registro", "Alta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                MessageBox.Show( ex.Message, "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                Conexion.conn.Close();
            }

        }


        public void modificarUsuarios()
        {
            try
            {
                string modificar = string.Format("UPDATE usuarios SET usuario='{0}', password='{1}', idEstatus='{2}', " +
                     "idObservador='{3}', idPrivilegios='{4}' WHERE idUsuario = {5}", this.usuario, this.password,
                     this.idEstatus, this.idObservador, this.idPrivilegios, this.idUsuario);

                res = BD.ABM(modificar);

                if (res == 1)
                {
                    MessageBox.Show( "Se ha modificado el registro correctamente", "Modificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                MessageBox.Show( ex.Message, "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                Conexion.conn.Close();
            }
        }



    }
}
