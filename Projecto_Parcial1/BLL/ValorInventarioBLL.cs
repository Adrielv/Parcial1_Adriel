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
    public class ValorInventarioBLL
    {
        public static bool Guardar(ValorInventario valorInventario)
        {
            bool paso = false;

            Contexto contexto = new Contexto();
            try
            {
                if (contexto.ValorInventario.Add(valorInventario) != null)
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

        public static ValorInventario Buscar(int id)
        {
            Contexto db = new Contexto();
            ValorInventario valor = new ValorInventario();

            try
            {
                valor = db.ValorInventario.Find(id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return valor;

        }

        public static bool Modificar(ValorInventario Valorinventario)
        {
            bool paso = false;

            Contexto db = new Contexto();
            try
            {
                db.Entry(Valorinventario).State = EntityState.Modified;
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