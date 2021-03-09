using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Text;
using Parcial2_apd1_20180906.Entidades;
using Parcial2_apd1_20180906.DAL;
using System.Linq;
using System.Linq.Expressions;

namespace Parcial2_apd1_20180906.BLL
{
    public class ProyectosBLL
    {
         public static bool Existe(int id)
        {
            Contexto contexto = new Contexto();
            bool paso = false;

            try
            {
                paso = contexto.Proyectos.Any(e => e.TipoId == id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return paso;
        }

        public static bool Insertar(Proyectos proyecto)
        {
            Contexto contexto = new Contexto();
            bool paso = false;

            try
            {
                contexto.Add(proyecto);
                paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return paso;
        }
        public static bool Modificar(Proyectos proyecto)
        {
            Contexto contexto = new Contexto();
            bool paso = false;

            try
            {
                /*contexto.Database.ExecuteSqlRaw($"Delete FROM ProyectosDetalle Where TipoId = {proyecto.TipoId}");
                foreach (var anterior in proyecto.Detalle)
                {
                    contexto.Entry(anterior).State = EntityState.Added;
                }*/
                contexto.Entry(proyecto).State = EntityState.Modified;
                paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return paso;
        }
        public static bool Guardar(Proyectos proyecto)
        {
            if (!Existe(proyecto.TipoId))
               return Insertar(proyecto);
            else
               return Modificar(proyecto);
        }

        public static bool Eliminar(int id)
        {
            Contexto contexto = new Contexto();
            bool paso = false;

            try
            {
                var proyecto = contexto.Proyectos.Find(id);
                if (proyecto != null)
                {
                    contexto.Entry(proyecto).State = EntityState.Deleted;
                    paso = contexto.SaveChanges() > 0;
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return paso;
        }
        public static Proyectos Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Proyectos proyecto;

            try
            {
                proyecto = contexto.Proyectos.Include(e => e.Detalle).Where(p => p.TipoId == id).SingleOrDefault();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return proyecto;
        }
        public static List<Proyectos> GetProyectos()
        {
            Contexto contexto = new Contexto();
            List<Proyectos> lista = new List<Proyectos>();

            try
            {

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return lista;
        }

        public static List<Proyectos> GetList(Expression<Func<Proyectos, bool>> criterio)
        {
            Contexto contexto = new Contexto();
            List<Proyectos> lista = new List<Proyectos>();

            try
            {
                lista = contexto.Proyectos.Where(criterio).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return lista;
        }
    }
}
