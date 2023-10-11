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
using System.IO;

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
            try
            {
                TextReader InicioseSesion = new StreamReader(txtboxNombreSesion.Text + ".txt");
               
                if (InicioseSesion.ReadLine() == txtboxContraseña.Text)
                {
                    MessageBox.Show("El usuario es correcto ");
                    Home home = new Home();
                    home.Show();
                    Hide();
                    
                }
                
                else 
                {
                    MessageBox.Show("El usuario no se ha encontrado");

                    
                }
                


                if (InicioseSesion.ReadLine() == (""))
                {
                    MessageBox.Show("Algu,porfavor añada lod datos del usuario");

                }
            }
            catch
            {
                MessageBox.Show("Datos incorrectos, por favor añada datos validos","Error de datos");
            }
          }

        

        private void label3_Click(object sender, EventArgs e)
        {

        }

      

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void click_para_registrar_Click(object sender, EventArgs e)
        {
            registro login = new registro();
            login.Show();
            Hide();
        }
    }
}
