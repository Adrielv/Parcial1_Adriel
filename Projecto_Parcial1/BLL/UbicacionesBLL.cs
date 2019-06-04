using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projecto_Parcial1.Entidades;
using Projecto_Parcial1.DAL;
using System.Data.Entity;
using System.Linq.Expressions;

namespace Projecto_Parcial1.BLL
{
   public  class UbicacionesBLL
    {
        public static bool Guardar(Ubicaciones  ubicaciones)
        {
            bool paso = false;

            Contexto contexto = new Contexto();
            try
            {
                if (contexto.Ubicaciones.Add(ubicaciones) != null)
                {
                    paso = contexto.SaveChanges() > 0;

                }
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }

        public static bool Eliminar(int id)
        {
            bool paso;
            Contexto db = new Contexto();

            try
            {
                var eliminar = db.Ubicaciones.Find(id);

                db.Entry(eliminar).State = EntityState.Deleted;

                paso = (db.SaveChanges() > 0);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return paso;

        }

        public static Ubicaciones Buscar(int id)
        {
            Contexto db = new Contexto();
            Ubicaciones ubicaciones = new Ubicaciones();

            try
            {
                ubicaciones = db.Ubicaciones.Find(id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return ubicaciones;

        }

        public static List<Ubicaciones> GetList(Expression<Func<Ubicaciones, bool>> ubicaciones)
        {
            List<Ubicaciones> Lista = new List<Ubicaciones>();
            Contexto db = new Contexto();
            try
            {
                Lista = db.Ubicaciones.Where(ubicaciones).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return Lista;
        }

        public static bool Modificar(Ubicaciones ubicaciones)
        {
            bool paso = false;

            Contexto db = new Contexto();
            try
            {
                db.Entry(ubicaciones).State = EntityState.Modified;
                paso = (db.SaveChanges() > 0);

                db.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }
    }
}
