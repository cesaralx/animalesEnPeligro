using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Components;

namespace AnimalesEnPeligro
{
    public partial class EspecieCmp : UserControl
    {
        especies espe = new especies();
        byte[] dataImage;

        private void cleanFields()
        {
            txtDescripcion.Text = "";
            txtIdEspecie.Text = "";
            txtNombreCientifico.Text = "";
            txtNombreVulgar.Text = "";
            comboEstatus.ResetText();
            comboGenero.ResetText();
        }

        public EspecieCmp()
        {
            InitializeComponent();

            btnImagen.AllowDrop = true;
            btnImagen.DragEnter += new DragEventHandler(Pnl1_DragEnter);
            btnImagen.DragDrop += new DragEventHandler(Pnl1_DragDrop);
        }

        private void EspecieCmp_Load(object sender, EventArgs e)
        {
            espe.MuestraDataEspecie(dataGridEspecies);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtIdEspecie_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            /*try
            {
                DataSet ds = new DataSet();
                ds = BD.BuscarCliente(string.Format("SELECT * from cliente WHERE nombre_cli like '{0}'", cmbNombre.Text), "cliente");

                foreach (DataRow fila in ds.Tables["cliente"].Rows)
                {
                    txtCodigo.Text = fila["codigo_cli"].ToString();
                    txtNombre.Text = fila["nombre_cli"].ToString();
                    txtRfc.Text = fila["rfc_cli"].ToString();
                    txtDir.Text = fila["direccion_cli"].ToString();
                    txtCiudad.Text = fila["ciudad_cli"].ToString();
                    txtTel.Text = fila["telefono_cli"].ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                ClassBD.conn.Close();
            }*/

        }

        private void txtNombreCientifico_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void txtNombreVulgar_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void txtDescripcion_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void comboGenero_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboEstatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            try
            {
                espe.descripcion = txtDescripcion.Text;
                espe.estatus = txtIdEspecie.Text;
                espe.genero = comboGenero.SelectedItem.ToString();
                espe.img = dataImage;
                espe.nombreCientifico = txtNombreCientifico.Text;
                espe.nombreVulgar = txtNombreVulgar.Text;
                espe.registrarEspecie();
                espe.MuestraDataEspecie(dataGridEspecies);
                cleanFields();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
  
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }

        private void btnImagen_MouseHover(object sender, EventArgs e)
        {
            //MessageBox.Show("hola");
        }

        void Pnl1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        void Pnl1_DragDrop(object sender, DragEventArgs e)
        {
            //pictureBox1.Image = Properties.Resources.icons8_Checkmark_104px;
            //pictureBox1.Refresh();
            var imagePath = "";

            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string file in files)
            {
                imagePath = file.ToString();
            }

            dataImage = System.IO.File.ReadAllBytes(imagePath);
            ToolTip tp = new ToolTip();
             tp.SetToolTip(btnImagen, imagePath);
        }


    }
}
