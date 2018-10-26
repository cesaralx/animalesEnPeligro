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
    class asociaciones
    {
        Conexion BD = new Conexion();
        int res = -1;

        public int idAsociacion { get; set; }
        public string nombre { get; set; }
        public int idDomicilio { get; set; }
        public string telefono { get; set; }


        public void deleteAsociacion(int idAsociacion)
        {
            try
            {
                string eliminar = string.Format("DELETE FROM asociaciones WHERE idAsociacion={0}", idAsociacion.ToString());

                res = BD.ABM(eliminar);

                if (res == 1)
                {
                    MessageBox.Show( "Se ha eliminado registro con codigo " + idAsociacion.ToString(), "Bajas", MessageBoxButtons.OK, MessageBoxIcon.Information);
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



        public DataGridView MuestraDataAsociacio(DataGridView dgv)
        {
            DataSet datos = new DataSet();
            datos = BD.ConsultaTab("asociaciones", "idAsociacion");
            dgv.DataSource = datos.Tables["asociaciones"];
            return dgv;

        }

        public void registrarAsociacio()
        {
            try
            {
                string insertar = string.Format("INSERT INTO asociaciones VALUES( '{0}', '{1}', '{2}')", this.nombre, this.idDomicilio,
                    this.telefono);

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


        public void modificarAsociacio()
        {
            try
            {
                string modificar = string.Format("UPDATE asociaciones SET nombre='{0}', idDomicilio='{1}', telefono='{2}' WHERE idAsociacion = {3}", this.nombre, 
                    this.idDomicilio, this.telefono, this.idAsociacion);

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
