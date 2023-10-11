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
    public partial class numerodelatidos : Form
    {
        public numerodelatidos()
        {
            InitializeComponent();
        }

        private void txtboxedad_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void numerodelatidos_Load(object sender, EventArgs e)
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

        private void botoncalcularlatidos_Click(object sender, EventArgs e)
        {
            try { 
            double edad, pulsaciones;
            edad = Convert.ToDouble(txtboxedad.Text);

                if (cmbxgenero.SelectedIndex == 0)
                {
                    pulsaciones = (220 - edad / 10) * 0.60;
                    lbllatidos.Text = "Latidos por minuto  ";
                    txtboxlatidos.Text = Convert.ToString(pulsaciones);
                }
                else if (cmbxgenero.SelectedIndex == 1)
                {
                    pulsaciones = (210 - edad / 10) * 0.60;
                    lbllatidos.Text = "Latidos por minuto ";
                    txtboxlatidos.Text = Convert.ToString(pulsaciones);
                }

            }
            catch
            {
                MessageBox.Show("Datos invalidos, porfavor agregue cantidades correctas", "Error de datos");
            }
        }

        private void botonlimpiarlatidos_Click(object sender, EventArgs e)
        {
            txtboxedad.Clear();
            txtboxlatidos.Clear();
        }
    }
}
