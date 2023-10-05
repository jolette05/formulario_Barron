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
    public partial class registro : Form
    {
        public registro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void regresarahomedesderegistro_Click(object sender, EventArgs e)
        {
            Form1 home = new Form1 ();
            home.Show();
            Hide();
        }

        private void salirdesderegistro_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
