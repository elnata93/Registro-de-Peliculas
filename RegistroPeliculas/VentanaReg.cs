
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL;

namespace MoviesOrganizer
{
    public partial class VentanaReg : Form
    {
        public VentanaReg()
        {
            InitializeComponent();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            RegPeliculas rp = new RegPeliculas();
            rp.Titulo = textBoxTitulo.Text;
            rp.Ano = Convert.ToInt32(textBoxAno.Text);
            rp.Calificacion = Convert.ToInt32(textBoxCalificacion.Text);
            rp.IMDB = Convert.ToInt32(textBoxIMDB.Text);
            rp.CategoriaId = Convert.ToInt32(textBoxCategoriaID.Text);
            rp.Descripcion = richTextBoxDescripcion.Text;
            rp.Insertar();
            textBoxTitulo.Clear();
            textBoxAno.Clear();
            textBoxCalificacion.Clear();
            textBoxIMDB.Clear();
            textBoxCategoriaID.Clear();
            richTextBoxDescripcion.Clear();


        }

        private void ButtonCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
       
    
}
