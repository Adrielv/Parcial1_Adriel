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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rProducto rp = new rProducto();
            rp.Show();
        }

        private void ValorInventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rValor_Inventario vi = new rValor_Inventario();
            vi.Show();
        }

        private void RegistroProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
