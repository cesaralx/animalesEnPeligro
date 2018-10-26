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
    public partial class EspecieCmp : UserControl
    {
        especies espe = new especies();
        Conexion BD = new Conexion();

        byte[] dataImage;

        private void cleanFields()
        {
            txtDescripcion.Text = "";
            txtIdEspecie.Text = "";
            txtNombreCientifico.Text = "";
            txtNombreVulgar.Text = "";
            comboEstatus.ResetText();
            comboGenero.ResetText();
            lblFoto.Text = "";
            
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
            cargaCombos();


        }

        private void cargaCombos()
        {
            try
            {
                DataSet ds = new DataSet();
                DataSet ds2 = new DataSet();
                ds = BD.Busca(string.Format("SELECT idEstatus, descripcion from estatus"), "estatus");

                comboEstatus.DisplayMember = "descripcion";
                comboEstatus.ValueMember = "idEstatus";
                comboEstatus.DataSource = ds.Tables["estatus"];

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


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = new DataSet();
                ds = BD.Busca(string.Format("SELECT * from especies WHERE idEspecie = {0}", Convert.ToInt32(txtIdEspecie.Text)), "especies");

                foreach (DataRow fila in ds.Tables["especies"].Rows)
                {
                    txtDescripcion.Text = fila["descripcion"].ToString();
                    txtIdEspecie.Text = fila["idEspecie"].ToString();
                    txtNombreCientifico.Text = fila["nombreCientifico"].ToString();
                    txtNombreVulgar.Text = fila["nombreVulgar"].ToString();

                    comboEstatus.SelectedItem = fila["estatus"].ToString();
                    comboGenero.SelectedItem = fila["genero"].ToString();

                    dataImage = (byte[])fila["img"];
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
                if (dataImage != null)
                {
                    espe.descripcion = txtDescripcion.Text;
                espe.estatus = comboEstatus.SelectedValue.ToString();
                espe.genero = comboGenero.SelectedItem.ToString();
                espe.img = dataImage;
                espe.nombreCientifico = txtNombreCientifico.Text;
                espe.nombreVulgar = txtNombreVulgar.Text;
                espe.registrarEspecie();
                espe.MuestraDataEspecie(dataGridEspecies);
                cleanFields();

                }
                else
                {
                    MetroMessageBox.Show(this, "Captura una imagen", "Imagen", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
  
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
             
            lblFoto.Text = imagePath.Split('\\').Last(); 
        }

        private void dataGridEspecies_Click(object sender, EventArgs e)
        {
            txtIdEspecie.Text = dataGridEspecies.CurrentRow.Cells[0].Value.ToString();
            btnBuscar_Click(sender, e);
        }

        private void dataGridEspecies_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenu m = new ContextMenu();
                //m.MenuItems.Add(new MenuItem("Cut"));
                //m.MenuItems.Add(new MenuItem("Copy"));
                //m.MenuItems.Add(new MenuItem("Paste"));

                int currentMouseOverRow = dataGridEspecies.CurrentRow.Index;

                if (currentMouseOverRow >= 0)
                {
                    m.MenuItems.Add(new MenuItem(string.Format("Borrar id {0}", dataGridEspecies.CurrentRow.Cells[0].Value.ToString()), MenuItemNew_Click));
                }

                m.Show(dataGridEspecies, new Point(e.X, e.Y));

            }
        }

        private void MenuItemNew_Click(Object sender, System.EventArgs e)
        {

            var idEspecie = ((MenuItem)sender).Text.Split(' ').Last();

            espe.deleteEspecie(Convert.ToInt32(idEspecie));
            espe.MuestraDataEspecie(dataGridEspecies);
            cleanFields();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            espe.descripcion = txtDescripcion.Text;
            espe.estatus = txtIdEspecie.Text;
            espe.genero = comboGenero.SelectedItem.ToString();
            espe.img = dataImage;
            espe.nombreCientifico = txtNombreCientifico.Text;
            espe.nombreVulgar = txtNombreVulgar.Text;
            espe.idEspecie = Convert.ToInt32(txtIdEspecie.Text);

            espe.modificarEspecie();

            espe.MuestraDataEspecie(dataGridEspecies);
            cleanFields();
        }
    }
}
