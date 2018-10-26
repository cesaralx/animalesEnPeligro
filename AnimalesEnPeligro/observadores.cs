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
    class observadores
    {
        Conexion BD = new Conexion();
        int res = -1;

        public int idObservador  { get; set; }
        public int idAsociacion { get; set; }
        public string codigo { get; set; }
        public string curp { get; set; }
        public string nombre { get; set; }
        public string apellidos { get; set; }
        public int idDomicilio { get; set; }
        public int idZona { get; set; }
        public int idEstatus { get; set; }

        public void deleteObservadores(int idObservador)
        {
            try
            {
                string eliminar = string.Format("DELETE FROM observadores WHERE idObservador={0}", idObservador.ToString());

                res = BD.ABM(eliminar);

                if (res == 1)
                {
                    MessageBox.Show( "Se ha eliminado registro con codigo " + idObservador.ToString(), "Bajas", MessageBoxButtons.OK, MessageBoxIcon.Information);
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



        public void MuestraDataObservadores(DataGridView dgv)
        {
            DataSet datos = new DataSet();
            datos = BD.ConsultaTab("observadores", "idObservador");
            dgv.DataSource = datos.Tables["observadores"];

        }

        public void registrarObservadores()
        {
            try
            {
                string insertar = string.Format("INSERT INTO observadores VALUES( '{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}')", this.idAsociacion, this.codigo,
                    this.curp, this.nombre, this.apellidos, this.idDomicilio, this.idZona, this.idEstatus);

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


        public void modificarObservadores()
        {
            try
            {
                string modificar = string.Format("UPDATE observadores SET idAsociacion='{0}', codigo='{1}', curp='{2}', " +
                     "nombre='{3}', apellidos='{4}', idDomicilio='{5}', idZona='{6}', idEstatus='{7}' WHERE idObservador = {8}", this.idAsociacion, this.codigo,
                     this.curp, this.nombre, this.apellidos, this.idDomicilio, this.idZona, this.idEstatus, this.idObservador);

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
