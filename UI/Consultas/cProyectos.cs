using Parcial2_apd1_20180906.Entidades;
using Parcial2_apd1_20180906.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Parcial2_apd1_20180906.UI.Consultas
{
    public partial class cProyectos : Form
    {
        public cProyectos()
        {
            InitializeComponent();
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            var listado = new List<Proyectos>();

            if(!string.IsNullOrEmpty(CriterioTextBox.Text) && FiltroComboBox.Text == "Proyecto Id" || FiltroComboBox.Text == "Tiempo")
            {
                if(!Regex.IsMatch(CriterioTextBox.Text, @"^[0-9]+$"))
                {
                    MessageBox.Show("Debes ingresar solo numeros","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;
                }
            }

            if (!string.IsNullOrEmpty(CriterioTextBox.Text))
            {
                switch (FiltroComboBox.SelectedIndex)
                {
                    //Proyecto id
                    case 0:
                        listado = ProyectosBLL.GetList(e => e.ProyectoId == Convert.ToInt32(CriterioTextBox.Text));
                        break;
                    //Descripcion
                    case 2:
                        listado = ProyectosBLL.GetList(e => e.DescripcionProyecto.Contains(CriterioTextBox.Text));
                        break;
                    //Tiempo
                    case 3:
                        listado = ProyectosBLL.GetList(e => e.TiempoTotal == Convert.ToInt32(CriterioTextBox.Text));
                        break;
                }
            }
            else
            {
                listado = ProyectosBLL.GetList(e => true);
            }

            DatosDataGrid.DataSource = null;
            DatosDataGrid.DataSource = listado;
        }
    }
}
