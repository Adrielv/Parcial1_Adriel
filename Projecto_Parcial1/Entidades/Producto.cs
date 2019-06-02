using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projecto_Parcial1.Entidades
{
    public class Producto
    {
        [Key]
       public int ProductoId { get; set; }
        public string Descripcion { get; set; }
        public float Existen { get; set; }
        public float Costo { get; set; }

      //  public int Valor_Inventario { get; set; }

        public Producto()
        {
            ProductoId = 0;
            Descripcion = string.Empty;
            Existen = 0;
            Costo = 0;
          //  Valor_Inventario = 0;
        }

    }

}
