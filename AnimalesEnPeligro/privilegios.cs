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
    class privilegios
    {
        Conexion BD = new Conexion();
        int res = -1;

        public int idPrivilegio { get; set; }
        public string descripcion { get; set; }


        public void deletePrivilegios(int idPrivilegio)
        {
            try
            {
                string eliminar = string.Format("DELETE FROM privilegios WHERE idPrivilegio={0}", idPrivilegio.ToString());

                res = BD.ABM(eliminar);

                if (res == 1)
                {
                    MetroMessageBox.Show(null, "Se ha eliminado registro con codigo " + idPrivilegio.ToString(), "Bajas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                MetroMessageBox.Show(null, ex.Message, "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                Conexion.conn.Close();
            }
        }



        public void MuestraPrivilegios(DataGridView dgv)
        {
            DataSet datos = new DataSet();
            datos = BD.ConsultaTab("privilegios", "idPrivilegio");
            dgv.DataSource = datos.Tables["privilegios"];

        }

        public void registrarPrivilegios()
        {
            try
            {
                string insertar = string.Format("INSERT INTO privilegios VALUES( '{0}')", this.descripcion);

                res = BD.ABM(insertar);

                if (res == 1)
                {
                    MetroMessageBox.Show(null, "Se ha agregado un registro", "Alta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                MetroMessageBox.Show(null, ex.Message, "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                Conexion.conn.Close();
            }

        }


        public void modificarPrivilegios()
        {
            try
            {
                string modificar = string.Format("UPDATE privilegios SET descripcion='{0}' WHERE idPrivilegio = {1}", this.descripcion, this.idPrivilegio);

                res = BD.ABM(modificar);

                if (res == 1)
                {
                    MetroMessageBox.Show(null, "Se ha modificado el registro correctamente", "Modificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                MetroMessageBox.Show(null, ex.Message, "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                Conexion.conn.Close();
            }
        }


    }
}
