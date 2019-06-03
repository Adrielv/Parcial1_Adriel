using Projecto_Parcial1.BLL;
using Projecto_Parcial1.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projecto_Parcial1
{
    public partial class Valor_Inventario : Form
    {
        public Valor_Inventario()
        {
            InitializeComponent();
        }


        float r;
        private void RefreshButton_Click(object sender, EventArgs e)
        {
           ValorInventario valorInventario = new ValorInventario();
          /*  r = 0.0f;

           r =  BuscarValor();
            GuardarValor();
           // LlenarCampo2();*/
            ValorInventarioLabel.Text = Convert.ToString(valorInventario.Valor_Inventario);

          //  Mostrar();
        }
        private void LlenarCampo2(ValorInventario valorInventario)
        {
            ValorInventarioLabel.Text = Convert.ToString(valorInventario.Valor_Inventario);
        }
        private void GuardarValor()
        {
            ValorInventario valorInventario;

            valorInventario = LlenarClase2();
            ValorInventarioBLL.Guardar(valorInventario);

       
        }



        private ValorInventario LlenarClase2()
        {

            ValorInventario valorInventario = new ValorInventario();

            valorInventario.Id = 1;
            valorInventario.Valor_Inventario = r;

            return valorInventario;
        }

        private float BuscarValor()
        {
            float r;
            r = 0.0f;

            Producto producto = new Producto();

        

            for (int i = 1; i < 1000; i++)
            {
                producto = ProductoBLL.Buscar(i);

                if (producto != null)
                {
                    r += (producto.Existen * producto.Costo);
                }
                else
                {
                    break;
                }
            }


            return r;
        }


        private void Mostrar()
        {
           
            int r = 0; //do while


            for (int i = 1; i < 1000; i++)
            {
                Producto producto = new Producto();
                ValorInventario valor = new ValorInventario();
              

                producto = ProductoBLL.Buscar(i);
                valor = ValorInventarioBLL.Buscar(i);

            

                if (producto != null)
                {
                    r += (valor.Id);
                }
                else
                {
                    break;
                }

            }


            ValorInventarioLabel.Text = Convert.ToString(r);



        }


    }
}
