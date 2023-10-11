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
    public partial class conversiones_de_moneda : Form
    {
        public conversiones_de_moneda()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
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

        private void botoncalculardinero_Click(object sender, EventArgs e)
        {
            try { 
            double pesos, dolares, euros;
            pesos = Convert.ToDouble(txtboxingresarcantidad.Text);

                if (convertirpesos.SelectedIndex == 0)
                {
                    dolares = pesos / 17.52;
                    lblmsg.Visible = true;
                    lblmsg.Text = "dolares ";
                    txtboxequivale.Text = Convert.ToString(dolares);
                }
                else if (convertirpesos.SelectedIndex == 1)
                {
                    euros = pesos / 18.53;
                    lblmsg.Visible = true;
                    lblmsg.Text = "Euros ";
                    txtboxequivale.Text = Convert.ToString(euros);
                }
                
            }
            catch
            {
                MessageBox.Show("Datos invalidos, porfavor agregue cantidades correctas", "Error de datos");
            }
        }

        private void botonlimpiardinero_Click(object sender, EventArgs e)
        {
            txtboxingresarcantidad.Clear();
            txtboxequivale.Clear();
        }
    }
}
