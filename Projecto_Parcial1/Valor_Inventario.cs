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

            double total;
            total = valorInventario.Valor_Inventario;
            ValorInventarioLabel.Text = total.ToString();

    


            /*  r = 0.0f;

             r =  BuscarValor();
              GuardarValor();
             // LlenarCampo2();*/
            // ValorInventarioLabel.Text = Convert.ToString(valorInventario.Valor_Inventario);

            //  Mostrar();
        }
        


    }
}
