using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static AplicativoMyCineList.ListasSalvasPeloUsuario;
using static AplicativoMyCineList.TeladeAbertura;

namespace AplicativoMyCineList
{

    public partial class ListasSalvasPeloUsuario : Form
    {
        public ListasSalvasPeloUsuario()
        {
            InitializeComponent();

        }

        private void ListasSalvasPeloUsuario_Load(object sender, EventArgs e)


        {
            listaDeFilmesSalvos.Items.Clear();
            foreach (var filme in DadosGlobais.filmesSalvos)
            {
                listaDeFilmesSalvos.Items.Add(filme);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TelaDeInicio telaDeInicio = new TelaDeInicio();
            telaDeInicio.Show();
            this.Hide();
        }

    }
}
