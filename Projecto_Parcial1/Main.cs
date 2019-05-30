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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void ProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registro_Producto rp = new Registro_Producto();
            rp.Show();
        }

        private void ValorInventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Valor_Inventario vi = new Valor_Inventario();
            vi.Show();
        }
    }
}
