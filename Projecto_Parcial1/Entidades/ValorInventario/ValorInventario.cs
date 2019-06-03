using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projecto_Parcial1.Entidades
{
   public class ValorInventario
    {
        [Key]

        public int Id { get; set; }

        public float Valor_Inventario { get; set; }

        public ValorInventario()
        {
            Id = 0;
            Valor_Inventario = 0.0f;
        }



    }
}
