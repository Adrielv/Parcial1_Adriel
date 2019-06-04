using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projecto_Parcial1.BLL;
using Projecto_Parcial1.DAL;
using Projecto_Parcial1.Entidades;

namespace Projecto_Parcial1
{
    public partial class rUbicaciones : Form
    {
        public rUbicaciones()
        {
            InitializeComponent();
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {
            IdNumericUpDown.Value = 0;
            DescripcionesTextBox.Text = string.Empty;
          
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {

            Ubicaciones ubicaciones;
            bool paso;



            if (!Validar())
                return;
            ubicaciones = LlenarClase();


            if (IdNumericUpDown.Value == 0)
            {
                paso = UbicacionesBLL.Guardar(ubicaciones);

            }
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificar una persona que no existe", "fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                paso = UbicacionesBLL.Modificar(ubicaciones);
            }

            if (paso)
                MessageBox.Show("Guardado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No fue Posible guardar!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private bool Validar()
        {
            bool paso = true;
            MyErrorProvider.Clear();

            if (string.IsNullOrWhiteSpace(DescripcionesTextBox.Text))
            {
                MyErrorProvider.SetError(DescripcionesTextBox, "El campo Descripcion no puede estar vacio");
                DescripcionesTextBox.Focus();
                paso = false;
            }
           
            return paso;

        }

        private bool ExisteEnLaBaseDeDatos()
        {
            Ubicaciones ubicaciones= UbicacionesBLL.Buscar((int)IdNumericUpDown.Value);
            return (ubicaciones != null);
        }

        private Ubicaciones LlenarClase()
        {
            Ubicaciones ubicaciones = new Ubicaciones();


            ubicaciones.UbicacionId = Convert.ToInt32(IdNumericUpDown.Value);
            ubicaciones.Descripcion = DescripcionesTextBox.Text;
          
            return ubicaciones;
        }

     

        private void Button3_Click(object sender, EventArgs e)
        {
            MyErrorProvider.Clear();
            int id;
            int.TryParse(IdNumericUpDown.Text, out id);

        

            Limpiar();
            if (UbicacionesBLL.Eliminar(id))
                MessageBox.Show("Eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MyErrorProvider.SetError(IdNumericUpDown, "No se puede eliminar una persona que no existe");

            Limpiar();
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            int id;
            Ubicaciones ubicaciones = new Ubicaciones();
            int.TryParse(IdNumericUpDown.Text, out id);

            Limpiar();

            ubicaciones = UbicacionesBLL.Buscar(id);

            if (ubicaciones != null)
            {
                MessageBox.Show("Persona Encontrada");
                LlenarCampo(ubicaciones);
            }
            else
            {
                MessageBox.Show("Persona no Encontrada");
            }
        }

        private void LlenarCampo(Ubicaciones ubicaciones)
        {
          

            IdNumericUpDown.Value = ubicaciones.UbicacionId;
            DescripcionesTextBox.Text = ubicaciones.Descripcion;
     

        }

       public static bool Existe(string descripcion)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {

            }catch(Exception)
            {
                throw;
            }
            return paso;
          
        }

        private void DescripcionesTextBox_Leave(object sender, EventArgs e)
        {
           
        }
    }
}
