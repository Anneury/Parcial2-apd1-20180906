using Parcial2_apd1_20180906.BLL;
using Parcial2_apd1_20180906.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Parcial2_apd1_20180906.UI.Registros
{
    public partial class rProyectos : Form
    {
        public List<ProyectosDetalle> Detalle { get; set; }
        public rProyectos()
        {
            InitializeComponent();
            this.Detalle = new List<ProyectosDetalle>();

            TipoTareaComboBox.DataSource = TareasBLL.GetTareas();
            TipoTareaComboBox.DisplayMember = "TareaId";
            TipoTareaComboBox.ValueMember = "TipoTarea";
        }
        private void CargarGrid()
        {
            DetalleDataGrid.DataSource = null;
            DetalleDataGrid.DataSource = this.Detalle;
        }
        private void Limpiar()
        {
            MyErrorProvider.Clear();
            ProyectoIdNumericUpDown.Value = 0;
            FechaDateTimePicker.Value = DateTime.Now.Date;
            DescripcionTextBox.Clear();
            RequerimientosTextBox.Clear();
            TiempoTextBox.Text = "0";
            TiempoTotalTextBox.Text = "0";
            this.Detalle = null;
            CargarGrid();
        }
        private void LlenaCampo(Proyectos proyecto)
        {
            this.Detalle = new List<ProyectosDetalle>();
            ProyectoIdNumericUpDown.Value = proyecto.TipoId;
            FechaDateTimePicker.Value = proyecto.Fecha;
            DescripcionTextBox.Text = proyecto.DescripcionProyecto;
            TiempoTotalTextBox.Text = Convert.ToString(proyecto.TiempoTotal);

            this.Detalle = proyecto.Detalle;
            CargarGrid();
        }
        private Proyectos LlenaClase()
        {
            Proyectos proyecto = new Proyectos();
            proyecto.TipoId = (int)ProyectoIdNumericUpDown.Value;
            proyecto.Fecha = FechaDateTimePicker.Value;
            proyecto.DescripcionProyecto = DescripcionTextBox.Text;
            proyecto.TiempoTotal = Convert.ToInt32(TiempoTotalTextBox.Text);

            return proyecto;
        }
        private bool Validar()
        {
            bool paso = true;

            if (string.IsNullOrEmpty(DescripcionTextBox.Text))
            {
                MyErrorProvider.SetError(DescripcionTextBox, "Debes agregar un descripcion.");
                DescripcionTextBox.Focus();

                paso = false;
            }

            return paso;
        }
        private bool ExisteEnLaBaseDeDatos(int id)
        {
            Proyectos proyecto;
            proyecto = ProyectosBLL.Buscar(id);

            return (proyecto != null);
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            Proyectos proyecto;
            int id;
            int.TryParse(ProyectoIdNumericUpDown.Text, out id);

            Limpiar();

            proyecto = ProyectosBLL.Buscar(id);

            if (proyecto != null)
                LlenaCampo(proyecto);
            else
                MessageBox.Show("Transaccion Fallida","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }

        private void AgregarButton_Click(object sender, EventArgs e)
        {
            if (DetalleDataGrid.DataSource != null)
                this.Detalle = (List<ProyectosDetalle>)DetalleDataGrid.DataSource;

            if(TipoTareaComboBox.Text == null)
            {
                MessageBox.Show("Selecciona un Tipo de tarea en el combobox.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int total, tiempo;
            Tareas tarea = TareasBLL.Buscar(Convert.ToInt32(TipoTareaComboBox.Text));

            this.Detalle.Add(new ProyectosDetalle()
            {
                TipoId = Convert.ToInt32(TipoTareaComboBox.Text),
                TipoTarea = tarea.TipoTarea,
                Requerimiento = RequerimientosTextBox.Text,
                Tiempo = Convert.ToInt32(TiempoTextBox.Text)
            }
            );
            CargarGrid();
            TipoTareaComboBox.Focus();

            total = Convert.ToInt32(TiempoTotalTextBox.Text);
            tiempo = Convert.ToInt32(TiempoTextBox.Text);

            total += tiempo;

            TiempoTotalTextBox.Text = total.ToString();
        }

        private void RemoverFilaButton_Click(object sender, EventArgs e)
        {
            string tiempo;
            int total = Convert.ToInt32(TiempoTotalTextBox.Text);

            if(DetalleDataGrid.Rows.Count > 0 && DetalleDataGrid.CurrentRow != null)
            {
                tiempo = DetalleDataGrid.CurrentRow.Cells[3].Value.ToString();

                if(total > Convert.ToInt32(tiempo))
                {
                    total -= Convert.ToInt32(tiempo);
                }
                else
                {
                    total = Convert.ToInt32(tiempo) - total;
                }

                TiempoTotalTextBox.Text = Convert.ToString(total);

                Detalle.RemoveAt(DetalleDataGrid.CurrentRow.Index);
            }
            else
            {
                MyErrorProvider.SetError(DetalleDataGrid, "Debes agregar Datos.");
                DetalleDataGrid.Focus();
            }
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            Proyectos proyecto;

            if (!Validar())
                return;

            proyecto = LlenaClase();

            MessageBox.Show("Aqui pase!", "Exito");
            var paso = ProyectosBLL.Guardar(proyecto);

            if (paso)
            {
                MessageBox.Show("Transaccion Exitosa!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Transaccion Fallida!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            MyErrorProvider.Clear();
            int id;
            int.TryParse(ProyectoIdNumericUpDown.Text, out id);
            
            if(ProyectoIdNumericUpDown.Value == 0)
            {
                MessageBox.Show("Debes agregar un id valido para poder eliminarlo.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            if (!ExisteEnLaBaseDeDatos(id))
                MessageBox.Show("Transaccion Fallida","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if(MessageBox.Show("Desea uste eliminar este proyecto?","Validar",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (ProyectosBLL.Eliminar(id))
                    {
                        MessageBox.Show("Transaccion Exitosa", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpiar();
                    }
                    else
                        MyErrorProvider.SetError(ProyectoIdNumericUpDown, "Agrega un id Valido. Este no Existe");
                }
            }
        }
    }
}
