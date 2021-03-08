using Parcial2_apd1_20180906.UI.Registros;
using Parcial2_apd1_20180906.UI.Consultas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial2_apd1_20180906
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.RegistroProyectosToolStripMenuItem.Click += new EventHandler(this.RegistroProyectosToolStripMenuItem_ItemClicked);
            this.ConsultaProyectosToolStripMenuItem.Click += new EventHandler(this.ConsultaProyectosToolStripMenuItem_ItemClicked);
        }

        private void RegistroProyectosToolStripMenuItem_ItemClicked(object sender, EventArgs e)
        {
            var registro = new rProyectos();
            registro.MdiParent = this;
            registro.Show();
        }
        private void ConsultaProyectosToolStripMenuItem_ItemClicked(object sender, EventArgs e)
        {
            var consulta = new cProyectos();
            consulta.MdiParent = this;
            consulta.Show();
        }
    }
}
