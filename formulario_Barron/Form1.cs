using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using formulario_Barron.Formas.Login;
using formulario_Barron.Formas;

namespace formulario_Barron
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //creado por jolette 

            Home home = new Home ();
            home.Show();
            Hide();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void click_para_registrar_Click(object sender, EventArgs e)
        {

            //CREADO POR JOLETTE 
            registro login = new registro();
            login.Show();
            Hide();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
