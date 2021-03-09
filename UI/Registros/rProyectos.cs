using Parcial2_apd1_20180906.BLL;
using Parcial2_apd1_20180906.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
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
            TipoTareaComboBox.ValueMember = "TareaId";
            TipoTareaComboBox.DisplayMember = "TipoTarea";
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

            this.Detalle = new List<ProyectosDetalle>();
            CargarGrid();
        }
        private void LlenaCampo(Proyectos proyecto)
        {
            this.Detalle = new List<ProyectosDetalle>();
            ProyectoIdTextBox.Text = Convert.ToString(proyecto.ProyectoId);
            FechaDateTimePicker.Value = proyecto.Fecha;
            DescripcionTextBox.Text = proyecto.DescripcionProyecto;
            TiempoTotalTextBox.Text = proyecto.TiempoTotal.ToString();

            this.Detalle = proyecto.Detalle;
            CargarGrid();
        }
        private Proyectos LlenaClase()
        {
            Proyectos proyecto = new Proyectos();
            proyecto.ProyectoId = (int)ProyectoIdNumericUpDown.Value;
            proyecto.Fecha = FechaDateTimePicker.Value;
            proyecto.DescripcionProyecto = DescripcionTextBox.Text;
            proyecto.TiempoTotal = Convert.ToInt32(TiempoTotalTextBox.Text);
            proyecto.Detalle = this.Detalle;

            return proyecto;
        }
        private bool Validar()
        {
            bool paso = true;

            if (DescripcionTextBox.Text == string.Empty)
            {
                MyErrorProvider.SetError(DescripcionTextBox, "Debes agregar un dato a este campo");
                DescripcionTextBox.Focus();

                paso = false;
            }
            if (DetalleDataGrid.CurrentRow == null)
            {
                MyErrorProvider.SetError(DetalleDataGrid, "Debes agregar Tareas a este Data grid");
                DetalleDataGrid.Focus();

                paso = false;
            }

            return paso;
        }
        public bool ValidarAgregar()
        {
            bool paso = true;

            if (RequerimientosTextBox.Text == string.Empty)
            {
                MyErrorProvider.SetError(RequerimientosTextBox, "Debes agregar datos a este campo");
                RequerimientosTextBox.Focus();

                paso = false;
            }

            if (TiempoTextBox.Text != string.Empty || TiempoTextBox.Text == string.Empty)
            {
                if (!Regex.IsMatch(TiempoTextBox.Text, @"^[0-9]+$"))
                {
                    MessageBox.Show("Debes ingresar solo numeros para este campo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return paso = false;
                }

                MyErrorProvider.SetError(TiempoTextBox, "Debes agregar datos a este campo");
                TiempoTextBox.Focus();

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
                MessageBox.Show("Proyecto no encontrado","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
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

            this.Detalle.Add(new ProyectosDetalle(
                DetalleId: 0,
                ProyectoId: (int)ProyectoIdNumericUpDown.Value,
                TipoId: tarea.TareaId,
                TipoTarea: tarea.TipoTarea,
                Requerimiento: RequerimientosTextBox.Text,
                Tiempo: Convert.ToInt32(TiempoTextBox.Text)
                )                     
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
            bool paso = ProyectosBLL.Guardar(proyecto);

            if (paso)
            {
                MessageBox.Show("Transaccion Exitosa!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void TiempoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
              if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan
                e.Handled = true;
            }
        }

    }
}
