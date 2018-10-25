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
    class estatus
    {
        Conexion BD = new Conexion();
        int res = -1;

        public int idEstatus { get; set; }
        public string descripcion { get; set; }


        public void deleteEstatus(int idEstatus)
        {
            try
            {
                string eliminar = string.Format("DELETE FROM estatus WHERE idEstatus={0}", idEstatus.ToString());

                res = BD.ABM(eliminar);

                if (res == 1)
                {
                    MetroMessageBox.Show(null, "Se ha eliminado registro con codigo " + idEstatus.ToString(), "Bajas", MessageBoxButtons.OK, MessageBoxIcon.Information);
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



        public void MuestraDataEstatus(DataGridView dgv)
        {
            DataSet datos = new DataSet();
            datos = BD.ConsultaTab("estatus", "idEstatus");
            dgv.DataSource = datos.Tables["estatus"];

        }

        public void registrarEstatus()
        {
            try
            {
                string insertar = string.Format("INSERT INTO estatus VALUES( '{0}')", this.descripcion);

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


        public void modificarEstatus()
        {
            try
            {
                string modificar = string.Format("UPDATE estatus SET descripcion='{0}' WHERE idEstatus = {1}", this.descripcion, this.idEstatus);

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
