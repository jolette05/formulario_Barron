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

namespace formulario_Barron.Formas
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void formasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void registroDeUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //creado por jolette 

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void videoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formavideo video = new Formavideo();
            video.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ejercicio1 login = new ejercicio1();
            login.Show();
            Hide();
        }

        private void encontrarElAreaDeUnTrianguloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Area_de_un_trianfulo login = new Area_de_un_trianfulo();
            login.Show();
            Hide();
        }

        private void regresarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 home = new Form1();
            home.Show();
            Hide();
        }

        private void cambiarDineroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            conversiones_de_moneda login = new conversiones_de_moneda();
            login.Show();
            Hide();
        }

        private void numeroDeLatidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            numerodelatidos login = new numerodelatidos();
            login.Show();
            Hide();
        }

        private void calcularSalarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Salario login = new Salario();
            login.Show();
            Hide();
        }

        private void encontrarRaicesRealesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ecuaciones login = new Ecuaciones();
            login.Show();
            Hide();
        }

        private void visorDeImagenesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Visor_de_imagenes login = new Visor_de_imagenes();
            login.Show();
            Hide();
        }
    }
}

