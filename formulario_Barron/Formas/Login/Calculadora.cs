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
            int num1;
            num1 = Convert.ToInt32(textBox1.Text);

            int num2;
            num2 = Convert.ToInt32(textBox2.Text);

            double resultado;

            resultado = (num1 + num2);

            textBox3.Text = Convert.ToString(resultado);
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
    }
}
