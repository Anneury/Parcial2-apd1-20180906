
namespace Parcial2_apd1_20180906.UI.Registros
{
    partial class rProyectos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rProyectos));
            this.TiempoTotalTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RemoverFilaButton = new System.Windows.Forms.Button();
            this.AgregarButton = new System.Windows.Forms.Button();
            this.DetalleDataGrid = new System.Windows.Forms.DataGridView();
            this.TiempoTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.RequerimientosTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TipoTareaComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.DescripcionTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.FechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ProyectoIdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.MyErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DetalleDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProyectoIdNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // TiempoTotalTextBox
            // 
            this.TiempoTotalTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TiempoTotalTextBox.Enabled = false;
            this.TiempoTotalTextBox.Location = new System.Drawing.Point(600, 548);
            this.TiempoTotalTextBox.Name = "TiempoTotalTextBox";
            this.TiempoTotalTextBox.Size = new System.Drawing.Size(171, 27);
            this.TiempoTotalTextBox.TabIndex = 25;
            this.TiempoTotalTextBox.Text = "0";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(494, 551);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 20);
            this.label7.TabIndex = 23;
            this.label7.Text = "Tiempo Total";
            // 
            // EliminarButton
            // 
            this.EliminarButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.EliminarButton.Image = ((System.Drawing.Image)(resources.GetObject("EliminarButton.Image")));
            this.EliminarButton.Location = new System.Drawing.Point(287, 538);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(106, 41);
            this.EliminarButton.TabIndex = 26;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.EliminarButton.UseVisualStyleBackColor = true;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // GuardarButton
            // 
            this.GuardarButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.GuardarButton.Image = ((System.Drawing.Image)(resources.GetObject("GuardarButton.Image")));
            this.GuardarButton.Location = new System.Drawing.Point(155, 538);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(106, 41);
            this.GuardarButton.TabIndex = 24;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // NuevoButton
            // 
            this.NuevoButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.NuevoButton.Image = ((System.Drawing.Image)(resources.GetObject("NuevoButton.Image")));
            this.NuevoButton.Location = new System.Drawing.Point(23, 538);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(106, 41);
            this.NuevoButton.TabIndex = 22;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.NuevoButton.UseVisualStyleBackColor = true;
            this.NuevoButton.Click += new System.EventHandler(this.NuevoButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.RemoverFilaButton);
            this.groupBox1.Controls.Add(this.AgregarButton);
            this.groupBox1.Controls.Add(this.DetalleDataGrid);
            this.groupBox1.Controls.Add(this.TiempoTextBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.RequerimientosTextBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.TipoTareaComboBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(23, 241);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(754, 272);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalle de Tareas a Realizar";
            // 
            // RemoverFilaButton
            // 
            this.RemoverFilaButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RemoverFilaButton.Image = ((System.Drawing.Image)(resources.GetObject("RemoverFilaButton.Image")));
            this.RemoverFilaButton.Location = new System.Drawing.Point(7, 220);
            this.RemoverFilaButton.Name = "RemoverFilaButton";
            this.RemoverFilaButton.Size = new System.Drawing.Size(123, 32);
            this.RemoverFilaButton.TabIndex = 11;
            this.RemoverFilaButton.Text = "Remover Fila ";
            this.RemoverFilaButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.RemoverFilaButton.UseVisualStyleBackColor = true;
            this.RemoverFilaButton.Click += new System.EventHandler(this.RemoverFilaButton_Click);
            // 
            // AgregarButton
            // 
            this.AgregarButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AgregarButton.Image = ((System.Drawing.Image)(resources.GetObject("AgregarButton.Image")));
            this.AgregarButton.Location = new System.Drawing.Point(645, 56);
            this.AgregarButton.Name = "AgregarButton";
            this.AgregarButton.Size = new System.Drawing.Size(102, 37);
            this.AgregarButton.TabIndex = 11;
            this.AgregarButton.Text = "Agregar";
            this.AgregarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AgregarButton.UseVisualStyleBackColor = true;
            this.AgregarButton.Click += new System.EventHandler(this.AgregarButton_Click);
            // 
            // DetalleDataGrid
            // 
            this.DetalleDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DetalleDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DetalleDataGrid.Location = new System.Drawing.Point(6, 99);
            this.DetalleDataGrid.Name = "DetalleDataGrid";
            this.DetalleDataGrid.RowHeadersWidth = 51;
            this.DetalleDataGrid.RowTemplate.Height = 29;
            this.DetalleDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DetalleDataGrid.Size = new System.Drawing.Size(741, 115);
            this.DetalleDataGrid.TabIndex = 9;
            // 
            // TiempoTextBox
            // 
            this.TiempoTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TiempoTextBox.Location = new System.Drawing.Point(465, 66);
            this.TiempoTextBox.Name = "TiempoTextBox";
            this.TiempoTextBox.Size = new System.Drawing.Size(125, 27);
            this.TiempoTextBox.TabIndex = 8;
            this.TiempoTextBox.Text = "0";
            this.TiempoTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TiempoTextBox_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(465, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Tiempo (Minutos)";
            // 
            // RequerimientosTextBox
            // 
            this.RequerimientosTextBox.Location = new System.Drawing.Point(200, 66);
            this.RequerimientosTextBox.Name = "RequerimientosTextBox";
            this.RequerimientosTextBox.Size = new System.Drawing.Size(223, 27);
            this.RequerimientosTextBox.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(200, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(189, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Requerimientos de la Tarea";
            // 
            // TipoTareaComboBox
            // 
            this.TipoTareaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TipoTareaComboBox.FormattingEnabled = true;
            this.TipoTareaComboBox.Location = new System.Drawing.Point(7, 65);
            this.TipoTareaComboBox.Name = "TipoTareaComboBox";
            this.TipoTareaComboBox.Size = new System.Drawing.Size(151, 28);
            this.TipoTareaComboBox.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tipo de Tarea";
            // 
            // BuscarButton
            // 
            this.BuscarButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BuscarButton.Image = ((System.Drawing.Image)(resources.GetObject("BuscarButton.Image")));
            this.BuscarButton.Location = new System.Drawing.Point(187, 31);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(94, 29);
            this.BuscarButton.TabIndex = 21;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // DescripcionTextBox
            // 
            this.DescripcionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DescripcionTextBox.Location = new System.Drawing.Point(23, 178);
            this.DescripcionTextBox.Multiline = true;
            this.DescripcionTextBox.Name = "DescripcionTextBox";
            this.DescripcionTextBox.Size = new System.Drawing.Size(748, 48);
            this.DescripcionTextBox.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Descripcion del Proyecto";
            // 
            // FechaDateTimePicker
            // 
            this.FechaDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FechaDateTimePicker.CustomFormat = "dd / MM / yyyy";
            this.FechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaDateTimePicker.Location = new System.Drawing.Point(23, 102);
            this.FechaDateTimePicker.Name = "FechaDateTimePicker";
            this.FechaDateTimePicker.Size = new System.Drawing.Size(206, 27);
            this.FechaDateTimePicker.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Fecha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Proyecto Id";
            // 
            // ProyectoIdNumericUpDown
            // 
            this.ProyectoIdNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProyectoIdNumericUpDown.Location = new System.Drawing.Point(22, 33);
            this.ProyectoIdNumericUpDown.Name = "ProyectoIdNumericUpDown";
            this.ProyectoIdNumericUpDown.Size = new System.Drawing.Size(150, 27);
            this.ProyectoIdNumericUpDown.TabIndex = 27;
            // 
            // MyErrorProvider
            // 
            this.MyErrorProvider.ContainerControl = this;
            // 
            // rProyectos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 591);
            this.Controls.Add(this.ProyectoIdNumericUpDown);
            this.Controls.Add(this.TiempoTotalTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.DescripcionTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FechaDateTimePicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(818, 638);
            this.Name = "rProyectos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Proyectos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DetalleDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProyectoIdNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TiempoTotalTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button RemoverFilaButton;
        private System.Windows.Forms.Button AgregarButton;
        private System.Windows.Forms.DataGridView DetalleDataGrid;
        private System.Windows.Forms.TextBox TiempoTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox RequerimientosTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox TipoTareaComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.TextBox DescripcionTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker FechaDateTimePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown ProyectoIdNumericUpDown;
        private System.Windows.Forms.ErrorProvider MyErrorProvider;
    }
}