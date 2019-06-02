using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projecto_Parcial1.DAL
{
    class ContextoV
    {
        public DbSet<Valor_Inventario> ValorI { get; set; }


        public Contexto() : base("ConStr")
        { }
    }
}
