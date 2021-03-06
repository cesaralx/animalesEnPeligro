﻿using System;
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
    public partial class AsociacionesCmp : UserControl
    {
        asociaciones asocia = new asociaciones();
        Conexion BD = new Conexion();

        public AsociacionesCmp()
        {
            InitializeComponent();
            asocia.MuestraDataAsociacio(dataAsociaciones);

        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            AsociacionesForm alta = new AsociacionesForm();
            alta.Show(this);
            alta.FormClosed += new FormClosedEventHandler(refreshGrid);
        }

        private void refreshGrid(object sender, FormClosedEventArgs e)
        {
            asocia.MuestraDataAsociacio(dataAsociaciones);
        }


        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                var idAsociacion = dataAsociaciones.CurrentRow.Cells[0].Value.ToString();
                AsociacionesForm modi = new AsociacionesForm(Convert.ToInt32(idAsociacion));
                modi.Show(this);
                modi.FormClosed += new FormClosedEventHandler(refreshGrid);
            }
            catch (Exception ex)
            {
                MessageBox.Show( ex.Message);
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var idAsociacion = dataAsociaciones.CurrentRow.Cells[0].Value.ToString();

            asocia.deleteAsociacion(Convert.ToInt32(idAsociacion));
            asocia.MuestraDataAsociacio(dataAsociaciones);
            //cleanFields();
        }

        private void AsociacionesCmp_Load(object sender, EventArgs e)
        {
            dataAsociaciones =  asocia.MuestraDataAsociacio(dataAsociaciones);

        }
    }
}
