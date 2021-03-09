using Microsoft.EntityFrameworkCore;
using Parcial2_apd1_20180906.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Parcial2_apd1_20180906.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Proyectos> Proyectos { get; set; }
        public DbSet<Tareas> Tareas { get; set; }

         protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
         {
             optionsBuilder.UseSqlite(@"Data Source = DATA\GestionDatos.Db");
         }
         protected override void OnModelCreating(ModelBuilder modelBuilder)
         {
             base.OnModelCreating(modelBuilder);

             modelBuilder.Entity<Tareas>().HasData(
                 new Tareas() { TareaId = 1, TipoTarea = "Análisis" },
                 new Tareas() { TareaId = 2, TipoTarea = "Diseño" },
                 new Tareas() { TareaId = 3, TipoTarea = "Programación" },
                 new Tareas() { TareaId = 4, TipoTarea = "Prueba" }
             );
         }
    }
}
