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
    public class ProductosBLL
    {
      
        public static ValorInventario LlenaClase()
        {
            ValorInventario inventario = new ValorInventario();
            inventario.Valor_Inventario = 0;
            inventario.Id = 1;

            return inventario;
        }
        public static bool Guardar(Producto productos)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            ValorInventario inventario = new ValorInventario();
            try
            {
                inventario = ValorInventariosBLL.Buscar(1);
                if (inventario == null)
                {

                    inventario = LlenaClase();
                    paso = ValorInventariosBLL.Guardar(inventario);

                }



                if (contexto.Producto.Add(productos) != null)
                    paso = contexto.SaveChanges() > 0;

                inventario.Valor_Inventario += productos.Valor_Inventario;
                ValorInventariosBLL.Modificar(inventario);
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

        public static bool Modificar(Producto producto)
        {
            bool paso = false;
            Contexto db = new Contexto();
            Producto producto1 = ProductosBLL.Buscar(producto.ProductoId);
            try
            {
                float res = producto.Valor_Inventario - producto1.Valor_Inventario;

                ValorInventario Valorinventario = ValorInventariosBLL.Buscar(1);
                Valorinventario.Valor_Inventario += res;
                ValorInventariosBLL.Modificar(Valorinventario);


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

                var ValorInventario = ValorInventariosBLL.Buscar(1);
                ValorInventario.Valor_Inventario -= eliminar.Valor_Inventario;
                ValorInventariosBLL.Modificar(ValorInventario);


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
        public static Producto Buscar(int id)
        {
            Contexto db = new Contexto();
            Producto producto = new Producto();

            try
            {
                producto = db.Producto.Find(id);

            }
            catch (Exception)
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

    }

}

