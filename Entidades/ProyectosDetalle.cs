using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Parcial2_apd1_20180906.Entidades
{
    public class ProyectosDetalle
    {
        [Key]
        public int DetalleId { get; set; }
        public int ProyectoId { get; set; }
        public int TipoId { get; set; }
        public string TipoTarea { get; set; }
        public string Requerimiento { get; set; }
        public int Tiempo { get; set; }

        public ProyectosDetalle()
        {
            DetalleId = 0;
            ProyectoId = 0;
            TipoId = 0;
            TipoTarea = string.Empty;
            Requerimiento = string.Empty;
            Tiempo = 0;
        }
        public ProyectosDetalle(int DetalleId, int ProyectoId, int TipoId, string TipoTarea, string Requerimiento, int Tiempo)
        {
            this.DetalleId = DetalleId;
            this.ProyectoId = ProyectoId;
            this.TipoId = TipoId;
            this.TipoTarea = TipoTarea;
            this.Requerimiento = Requerimiento;
            this.Tiempo = Tiempo;
        }
    }
}
