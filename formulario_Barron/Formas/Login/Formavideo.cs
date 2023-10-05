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
    public partial class Formavideo : Form
    {
        public Formavideo()
        {
            InitializeComponent();
        }

        private void Formavideo_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = @"C:\Users\ameri\Downloads\Fandub español My little Goat _Mi pequeña cabrita (1).mp4";
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }
    }
}
