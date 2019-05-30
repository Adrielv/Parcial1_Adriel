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
    public class ProductoBLL
    {
        public static bool Guardar(Producto producto)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                if (db.Producto.Add(producto) != null)
                    paso = db.SaveChanges() > 0;
            }
            catch(Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return paso;


        }

        public static bool Modificar(Producto producto)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                db.Entry(producto).State = EntityState.Modified;
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
        public static bool Eliminar(int id)
        {
            bool paso;
            Contexto db = new Contexto();

            try
            {
                var eliminar = db.Producto.Find(id);
                db.Entry(eliminar).State = EntityState.Deleted;

                paso = (db.SaveChanges() > 0);
            }
            catch(Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return paso;

        }
        public static Producto Buscar(int id)
        {
            Contexto db = new Contexto();
            Producto producto = new Producto();

            try
            {
                producto = db.Producto.Find(id);

            }
            catch(Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return producto;

        }

        public static List<Producto> GetList(Expression<Func<Producto, bool>> producto)
        {
            List<Producto> Lista = new List<Producto>();
            Contexto db = new Contexto();
            try
            {
                Lista = db.Producto.Where(producto).ToList();
            }
            catch(Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return Lista;
        }

    }
}
