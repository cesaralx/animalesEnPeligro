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
    class zonas
    {
        Conexion BD = new Conexion();
        int res = -1;


        public int idZona { get; set; }
        public string  nombre { get; set; }
        public string estado { get; set; }
        public string municipio { get; set; }
        public string caracteristicas { get; set; }


        public void deleteZonas(int idZona)
        {
            try
            {
                string eliminar = string.Format("DELETE FROM zonas WHERE idZona={0}", idZona.ToString());

                res = BD.ABM(eliminar);

                if (res == 1)
                {
                    MessageBox.Show("Se ha eliminado registro con codigo " + idZona.ToString(), "Bajas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                MessageBox.Show( ex.Message, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            finally
            {
                Conexion.conn.Close();
            }
        }



        public void MuestraDataZonas(DataGridView dgv)
        {
            DataSet datos = new DataSet();
            datos = BD.ConsultaTab("zonas", "idZona");
            dgv.DataSource = datos.Tables["zonas"];

        }

        public void registrarZonas()
        {
            try
            {
                string insertar = string.Format("INSERT INTO zonas VALUES( '{0}', '{1}', '{2}', '{3}')", this.nombre, this.estado,
                    this.municipio, this.caracteristicas);

                res = BD.ABM(insertar);

                if (res == 1)
                {
                    MessageBox.Show("Se ha agregado un registro", "Alta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                MessageBox.Show( ex.Message, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            finally
            {
                Conexion.conn.Close();
            }

        }


        public void modificarZonas()
        {
            try
            {
                string modificar = string.Format("UPDATE zonas SET nombre='{0}', estado='{1}', municipio='{2}', " +
                     "caracteristicas='{3}' WHERE idZona = {4}", this.nombre, this.estado,
                     this.municipio, this.caracteristicas, this.idZona);

                res = BD.ABM(modificar);

                if (res == 1)
                {
                    MessageBox.Show("Se ha modificado el registro correctamente", "Modificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                MessageBox.Show( ex.Message, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            finally
            {
                Conexion.conn.Close();
            }
        }


    }
}
