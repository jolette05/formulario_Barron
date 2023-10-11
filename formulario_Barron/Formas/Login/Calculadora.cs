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
    public partial class ejercicio1 : Form
    {
        public ejercicio1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                int num1;
                num1 = Convert.ToInt32(txtboxvalor1.Text);

                int num2;
                num2 = Convert.ToInt32(txtboxvalor2.Text);

                double resultado;

                resultado = (num1 + num2);

                txtboxresultadosuma.Text = Convert.ToString(resultado);
            }

            catch
            {
                MessageBox.Show("Datos invalidos, porfavor agregue cantidades correctas", "Error de datos");
            }
        }
    

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void regresarAHomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            Hide();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btonlimpiarsuma_Click(object sender, EventArgs e)
        {
            txtboxvalor1.Clear();
            txtboxvalor2.Clear();
            txtboxresultadosuma.Clear();
        }
    }
}
