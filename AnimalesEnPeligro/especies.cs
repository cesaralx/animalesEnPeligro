using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimalesEnPeligro
{
    class especies
    {
        Conexion BD = new Conexion();
        int res = -1;

        public int idEspecie { get; set; }
        public string nombreCientifico { get; set; }
        public string nombreVulgar { get; set; }
        public string descripcion { get; set; }
        public string genero { get; set; }
        public byte[] img { get; set; }
        public string estatus { get; set; }


        public void deleteEspecie(int idEspecie)
        {
            try
            {
                string eliminar = string.Format("DELETE FROM especies WHERE idEspecie={0}", idEspecie.ToString() );

                res = BD.ABM(eliminar);

                if (res == 1)
                {
                    MessageBox.Show("Se ha eliminado registro con codigo " + idEspecie.ToString(), "Bajas", MessageBoxButtons.OK, MessageBoxIcon.Information);
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


        public void MuestraDataEspecie(DataGridView dgv)
        {
            DataSet datos = new DataSet();
            datos = BD.ConsultaTab("especies", "idEspecie");
            dgv.DataSource = datos.Tables["especies"];
           
        }

        public void registrarEspecie()
        {
            try
            {
                string insertar = string.Format("INSERT INTO especies VALUES( '{0}', '{1}', '{2}', '{3}', {4}, '{5}')", this.nombreCientifico, this.nombreVulgar,
                    this.descripcion, this.genero, "@File", this.estatus);

                res = BD.ABM(insertar, this.img);

                if (res == 1)
                {
                    MessageBox.Show("Se ha agregado un registro", "Alta", MessageBoxButtons.OK, MessageBoxIcon.Information);
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


        public void modificarEspecie()
        {
            try
            {
                string modificar = string.Format("UPDATE especies SET nombreCientifico='{0}', nombreVulgar='{1}', descripcion='{2}', " +
                     "genero='{3}', img='{4}', estatus='{5}', WHERE idEspecie = {6}", this.nombreCientifico, this.nombreVulgar, 
                     this.descripcion, this.genero, this.img, this.estatus, this.idEspecie);

                res = BD.ABM(modificar);

                if (res == 1)
                {
                    MessageBox.Show("Se ha modificado el registro correctamente", "Modificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
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




    }


}
