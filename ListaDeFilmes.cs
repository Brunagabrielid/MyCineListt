using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicativoMyCineList
{
    public partial class ListaDeFilmes : Form
    {
        private List<PictureBox> filmesSelecionadosPeloUsuario;
        public ListaDeFilmes(List<PictureBox> filmesSelecionadosPeloUsuario)
        {
            InitializeComponent();
            this.filmesSelecionadosPeloUsuario = filmesSelecionadosPeloUsuario;
            mostrarFilmesAdicionados(filmesSelecionadosPeloUsuario);

        }
        private void mostrarFilmesAdicionados(List<PictureBox> filmesSelecionadosPeloUsuario)
        {
            int x = 40;
            int y = 100;

            foreach (var filmeadicionado in filmesSelecionadosPeloUsuario)
            {
                PictureBox novoFilme = new PictureBox
                {
                    Image = filmeadicionado.Image,
                    Location = new System.Drawing.Point(x, y),
                    Size = new System.Drawing.Size(100, 140),
                    SizeMode = PictureBoxSizeMode.StretchImage
                };

                this.Controls.Add(novoFilme);

                x += 110;
                if (x + 100 > this.Width)
                {
                    x = 40;
                    y += 160;
                }
            }
        }
        private void btnVoltarCatalogo_Click(object sender, EventArgs e)
        {
            CatálogoCompleto catálogoCompleto = new CatálogoCompleto();
            catálogoCompleto.Show();
            this.Hide();
        }

        private void ListaDeFilmes_Load(object sender, EventArgs e)
        {

        }
    }
}
