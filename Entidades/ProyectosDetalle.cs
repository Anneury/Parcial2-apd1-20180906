using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Parcial2_apd1_20180906.Entidades
{
    public class ProyectosDetalle
    {
        [Key]
        public int TipoId { get; set; }
        public string TipoTarea { get; set; }
        public string Requerimiento { get; set; }
        public int Tiempo { get; set; }
    }
}
