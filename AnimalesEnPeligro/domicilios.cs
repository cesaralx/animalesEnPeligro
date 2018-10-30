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
    class domicilios
    {
        Conexion BD = new Conexion();
        int res = -1;

        public int idDomicilio { get; set; }
       public string calle { get; set; }
       public string noExterior { get; set; }
       public string noInterior { get; set; }
       public string colonia { get; set; }
       public string codigoPostal { get; set; }
       public string municipio { get; set; }
       public string estado { get; set; }


        public void deleteDomicilio(int idDomicilio)
        {
            try
            {
                string eliminar = string.Format("DELETE FROM domicilios WHERE idDomicilio={0}", idDomicilio.ToString());

                res = BD.ABM(eliminar);

                if (res == 1)
                {
                    MessageBox.Show( "Se ha eliminado registro con codigo " + idDomicilio.ToString(), "Bajas", MessageBoxButtons.OK, MessageBoxIcon.Information);
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



        public void MuestraDataDomicilio(DataGridView dgv)
        {
            DataSet datos = new DataSet();
            datos = BD.ConsultaTab("domicilios", "idDomicilio");
            dgv.DataSource = datos.Tables["domicilios"];

        }

        public void registrarDomicilio()
        {
            try
            {
                string insertar = string.Format("INSERT INTO domicilios VALUES( '{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}')", this.calle, this.noExterior,
                    this.noInterior, this.colonia, this.codigoPostal, this.municipio, this.estado);

                res = BD.ABM(insertar);

                if (res == 1)
                {
                    //MessageBox.Show( "Se ha agregado un registro", "Alta", MessageBoxButtons.OK, MessageBoxIcon.Information);
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


        public void modificarDomicilio()
        {
            try
            {
                string modificar = string.Format("UPDATE domicilios SET calle='{0}', noExterior='{1}', noInterior='{2}', colonia='{3}', " +
                     "codigoPostal='{4}', municipio='{5}', estado='{6}' WHERE idDomicilio = {7}", this.calle, this.noExterior,
                     this.noInterior, this.colonia, this.codigoPostal, this.municipio, this.estado,  this.idDomicilio);

                res = BD.ABM(modificar);

                if (res == 1)
                {
                    //MessageBox.Show( "Se ha modificado el registro correctamente", "Modificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
