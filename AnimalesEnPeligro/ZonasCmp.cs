using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;

namespace AnimalesEnPeligro
{
    public partial class ZonasCmp : UserControl
    {
        zonas Zonas = new zonas();
        Conexion BD = new Conexion();

        public ZonasCmp()
        {
            InitializeComponent();
        }

        private void cleanFields()
        {
            txtIdZona.Text = "";
            txtNombre.Text = "";
            txtEstado.Text = "";
            txtMunicipio.Text = "";
            txtCaracteristicas.Text = "";

        }

        private void ZonasCmp_Load(object sender, EventArgs e)
        {
            Zonas.MuestraDataZonas(dataGriedZonas);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = new DataSet();
                ds = BD.Busca(string.Format("SELECT * from zonas WHERE idZona = {0}", Convert.ToInt32(txtIdZona.Text)), "zonas");

                foreach (DataRow fila in ds.Tables["zonas"].Rows)
                {
                    txtIdZona.Text = fila["idZona"].ToString();
                    txtNombre.Text = fila["nombre"].ToString();
                    txtEstado.Text = fila["estado"].ToString();
                    txtMunicipio.Text = fila["municipio"].ToString();
                    txtCaracteristicas.Text = fila["caracteristicas"].ToString();
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

        private void btnAlta_Click(object sender, EventArgs e)
        {
            try
            {
                Zonas.nombre = txtNombre.Text;
                Zonas.estado = txtEstado.Text;
                Zonas.municipio = txtMunicipio.Text;
                Zonas.caracteristicas = txtCaracteristicas.Text;
                Zonas.registrarZonas();
                Zonas.MuestraDataZonas(dataGriedZonas);
                cleanFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGriedZonas_Click(object sender, EventArgs e)
        {
            txtIdZona.Text = dataGriedZonas.CurrentRow.Cells[0].Value.ToString();
            btnBuscar_Click(sender, e);
        }

        private void dataGriedZonas_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenu m = new ContextMenu();
                //m.MenuItems.Add(new MenuItem("Cut"));
                //m.MenuItems.Add(new MenuItem("Copy"));
                //m.MenuItems.Add(new MenuItem("Paste"));

                int currentMouseOverRow = dataGriedZonas.CurrentRow.Index;

                if (currentMouseOverRow >= 0)
                {
                    m.MenuItems.Add(new MenuItem(string.Format("Borrar id {0}", dataGriedZonas.CurrentRow.Cells[0].Value.ToString()), MenuItemNew_Click));
                }

                m.Show(dataGriedZonas, new Point(e.X, e.Y));

            }
        }

        private void MenuItemNew_Click(Object sender, System.EventArgs e)
        {

            var idZona = ((MenuItem)sender).Text.Split(' ').Last();

            Zonas.deleteZonas(Convert.ToInt32(idZona));
            Zonas.MuestraDataZonas(dataGriedZonas);
            cleanFields();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Zonas.nombre = txtNombre.Text;
            Zonas.estado = txtEstado.Text;
            Zonas.municipio = txtMunicipio.Text;
            Zonas.caracteristicas = txtCaracteristicas.Text;
            Zonas.idZona = Convert.ToInt32(txtIdZona.Text);

            Zonas.modificarZonas();

            Zonas.MuestraDataZonas(dataGriedZonas);
            cleanFields();
        }


    }
}
