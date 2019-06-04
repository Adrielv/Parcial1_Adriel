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
    public partial class rValor_Inventario : Form
    {
        public rValor_Inventario()
        {
            InitializeComponent();
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            ValorInventario inventario = ValorInventariosBLL.Buscar(1);
            double total;
            total = inventario.Valor_Inventario;
            ValorInventarioLabel.Text = total.ToString();
        }
    }
}