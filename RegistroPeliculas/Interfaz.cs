using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MoviesOrganizer
{
    public partial class Interfaz : Form
    {
        public Interfaz()
        {
            InitializeComponent();
        }

        private void Interfaz_Load(object sender, EventArgs e)
        {

        }

        private void regToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VentanaReg vr = new VentanaReg();
            vr.Show();
        }

        private class RegistroForm
        {
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VentanaConsultar vc = new VentanaConsultar();
            vc.Show();
        }
    }
}
