using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO ; 

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
            try
            {
                TextWriter RegistrarUsuario = new StreamWriter(@"C:\Users\ameri\source\repos\formulario_Barron\formulario_Barron\bin\Debug\" + txtboxNombre.Text + ".txt", true);
                RegistrarUsuario.WriteLine(txtboxNombre.Text);
                RegistrarUsuario.WriteLine(txtboxApellidos.Text);
                RegistrarUsuario.WriteLine(txtboxUsuario.Text);
                RegistrarUsuario.WriteLine(txtboxContraseña.Text);
                RegistrarUsuario.Close();

                MessageBox.Show("Se ha registrado correctamente", "Registro de usuario");
                txtboxNombre.Clear();
                txtboxApellidos.Clear();
                txtboxUsuario.Clear();
                txtboxContraseña.Clear();

            }
            catch
            {
                MessageBox.Show("Datos incorrectos,porfavor añada datos correctos ","Error");
            }
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
