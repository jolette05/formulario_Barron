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
    public partial class Ecuaciones : Form
    {
        public Ecuaciones()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            double x1, x2;

            double a= Convert.ToDouble(txtboxvalorA.Text);
            double b = Convert.ToDouble(txtboxvalorB.Text);
            double c = Convert.ToDouble(txtboxvalorC.Text);

            x1 = (-b + Math.Sqrt(Math.Pow(b, 2) - 4* (a * c))) / 2 * a;
            x2 = (-b - Math.Sqrt(Math.Pow(b, 2) - 4 * (a * c))) / 2 * a;

            txtboxraiz1.Text = x1.ToString();
            txtboxraiz2.Text = x2.ToString();
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
