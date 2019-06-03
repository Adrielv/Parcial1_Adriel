using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projecto_Parcial1.Entidades;

namespace Projecto_Parcial1.DAL
{
    public class Contexto : DbContext 
    {
        public DbSet<Producto> Producto { get; set; }
        public DbSet<ValorInventario> ValorInventario { get; set; }


        public Contexto() : base("ConStr")
        { }


    }
}
