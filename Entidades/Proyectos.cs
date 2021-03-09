using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Parcial2_apd1_20180906.Entidades
{
    public class Proyectos
    {
        [Key]
        public int ProyectoId { get; set; }
        public DateTime Fecha { get; set; }
        public string DescripcionProyecto { get; set; }
        public int TiempoTotal { get; set; }
        [ForeignKey("ProyectoId")]
        public List<ProyectosDetalle> Detalle { get; set; }
    }
}
