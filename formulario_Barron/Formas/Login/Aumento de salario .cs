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
    public partial class Salario : Form
    {
        public Salario()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btoncalcularsalario_Click(object sender, EventArgs e)
        {
            txtboxsalario.Clear();
            txtboxsalarion.Clear();


        }

        private void cmboxsalario_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void regresarahomesalario_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            Hide();
        }

        private void salirsalario_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void botoncalcularsalario_Click(object sender, EventArgs e)
        {

            try
            {
                double salario, nuevo_salario;
                salario = Convert.ToDouble(txtboxsalario.Text);

                if (cmboxsalario.SelectedIndex == 0)
                {
                    nuevo_salario = (salario * 0.05) + salario;
                    txtboxsalarion.Text = Convert.ToString(nuevo_salario);
                }
                else if (cmboxsalario.SelectedIndex == 1)
                {
                    nuevo_salario = (salario * 0.10) + salario;
                    txtboxsalarion.Text = Convert.ToString(nuevo_salario);
                }
                else if (cmboxsalario.SelectedIndex == 2)
                {
                    nuevo_salario = (salario * 0.15) + salario;
                    txtboxsalarion.Text = Convert.ToString(nuevo_salario);
                }
                else if (cmboxsalario.SelectedIndex == 3)
                {
                    nuevo_salario = (salario * 0.20) + salario;
                    txtboxsalarion.Text = Convert.ToString(nuevo_salario);
                }
                else if (cmboxsalario.SelectedIndex == 4)
                {
                    nuevo_salario = (salario * 0.25) + salario;
                    txtboxsalarion.Text = Convert.ToString(nuevo_salario);
                }
            }
            catch
            {
                MessageBox.Show("Datos invalidos, porfavor agregue cantidades correctas", "Error de datos");
            }

        }
    }
    }

