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
    class observaciones
    {
        Conexion BD = new Conexion();
        int res = -1;

        public int idObservacion { get; set; }
        public int idObservador { get; set; } 
        public int idEspecie { get; set; }
        public int cantidad { get; set; }
        public DateTime fecha { get; set; }
        public string detalle { get; set; }


        public void deleteObservaciones(int idObservacion)
        {
            try
            {
                string eliminar = string.Format("DELETE FROM observaciones WHERE idObservacion={0}", idObservacion.ToString());

                res = BD.ABM(eliminar);

                if (res == 1)
                {
                   MessageBox.Show( "Se ha eliminado registro con codigo " + idObservacion.ToString(), "Bajas", MessageBoxButtons.OK, MessageBoxIcon.Information);
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



        public void MuestraDataObservaciones(DataGridView dgv)
        {
            DataSet datos = new DataSet();
            datos = BD.ConsultaTab("observaciones", "idObservacion");
            dgv.DataSource = datos.Tables["observaciones"];

        }

        public void registrarObservaciones()
        {
            try
            {
                string insertar = string.Format("INSERT INTO observaciones VALUES( '{0}', '{1}', '{2}', '{3}', '{4}')", this.idObservador, this.idEspecie,
                    this.cantidad, this.fecha, this.detalle);

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


        public void modificarObservaciones()
        {
            try
            {
                string modificar = string.Format("UPDATE observaciones SET idObservador='{0}', idEspecie='{1}', cantidad='{2}', " +
                     "fecha='{3}', detalle='{4}' WHERE idObservacion = {5}", this.idObservador, this.idEspecie,
                     this.cantidad, this.fecha, this.detalle, this.idObservacion);

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

