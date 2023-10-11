using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formulario_Barron.Formas.Login
{
    public partial class Area_de_un_trianfulo : Form
    {
        public Area_de_un_trianfulo()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Calcular_area_Click(object sender, EventArgs e)
        {

            try
            {

                int Base;
                Base = Convert.ToInt32(txtboxbase.Text);

                int Altura;
                Altura = Convert.ToInt32(txtboxaltura.Text);

                double resultado;

                resultado = (Base * Altura) / 2;

                txtboxarea.Text = Convert.ToString(resultado);

            }

            catch
            {
                MessageBox.Show("Datos incorrectos,porfavor agregue una cantidad valida", "Error de datos ");
            }


        }





        private void regresar_a_Home_area_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            Hide();
        }

        private void regresasAHomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            Hide();
        }

        private void salirarea_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void botonlimpiartriangulo_Click(object sender, EventArgs e)
        {
            txtboxbase.Clear();
            txtboxaltura.Clear();
            txtboxarea.Clear(); 
        }
    }
}
