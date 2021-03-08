
namespace Parcial2_apd1_20180906
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.RegistrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ConsultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RegistroProyectosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ConsultaProyectosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RegistrosToolStripMenuItem,
            this.ConsultasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1189, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // RegistrosToolStripMenuItem
            // 
            this.RegistrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RegistroProyectosToolStripMenuItem});
            this.RegistrosToolStripMenuItem.Name = "RegistrosToolStripMenuItem";
            this.RegistrosToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.RegistrosToolStripMenuItem.Text = "&Registros";
            // 
            // ConsultasToolStripMenuItem
            // 
            this.ConsultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ConsultaProyectosToolStripMenuItem});
            this.ConsultasToolStripMenuItem.Name = "ConsultasToolStripMenuItem";
            this.ConsultasToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.ConsultasToolStripMenuItem.Text = "&Consultas";
            // 
            // RegistroProyectosToolStripMenuItem
            // 
            this.RegistroProyectosToolStripMenuItem.Name = "RegistroProyectosToolStripMenuItem";
            this.RegistroProyectosToolStripMenuItem.Size = new System.Drawing.Size(215, 26);
            this.RegistroProyectosToolStripMenuItem.Text = "Registro Proyectos";
            // 
            // ConsultaProyectosToolStripMenuItem
            // 
            this.ConsultaProyectosToolStripMenuItem.Name = "ConsultaProyectosToolStripMenuItem";
            this.ConsultaProyectosToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.ConsultaProyectosToolStripMenuItem.Text = "Consulta Proyectos";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 677);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem RegistrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RegistroProyectosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ConsultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ConsultaProyectosToolStripMenuItem;
    }
}

