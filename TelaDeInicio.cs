using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicativoMyCineList
{
    public partial class TelaDeInicio : Form
    {
        public TelaDeInicio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CatálogoCompleto catálogoCompleto = new CatálogoCompleto();
            catálogoCompleto.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ListasSalvasPeloUsuario listasSalvasPeloUsuario = new ListasSalvasPeloUsuario();
            listasSalvasPeloUsuario.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DetalhesFilmes detalhesFilmes = new DetalhesFilmes();
            detalhesFilmes.Show();
            this.Hide();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
