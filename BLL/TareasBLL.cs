using System;
using System.Collections.Generic;
using System.Text;
using Parcial2_apd1_20180906.Entidades;
using Parcial2_apd1_20180906.DAL;
using System.Linq;
using System.Linq.Expressions;

namespace Parcial2_apd1_20180906.BLL
{
    public class TareasBLL
    {
        public static Tareas Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Tareas tarea;

            try
            {
                tarea = contexto.Tareas.Find(id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return tarea;
        }
        
        public static List<Tareas> GetTareas()
        {
            Contexto contexto = new Contexto();
            List<Tareas> lista = new List<Tareas>();

            try
            {
                lista = contexto.Tareas.ToList();
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

        public static List<Tareas> GetList(Expression<Func<Tareas, bool>> criterio)
        {
            Contexto contexto = new Contexto();
            List<Tareas> lista = new List<Tareas>();

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
    }
}
