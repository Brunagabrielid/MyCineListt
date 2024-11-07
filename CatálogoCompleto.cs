using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static AplicativoMyCineList.TeladeAbertura;

namespace AplicativoMyCineList
{

    public partial class CatálogoCompleto : Form
    {
        private List<PictureBox> filmesSelecionadosPeloUsuario = new List<PictureBox>();


        public CatálogoCompleto()
        {
            InitializeComponent();
        }

        private void btnAvancarParaListaCriada_Click(object sender, EventArgs e)
        {
            ListaDeFilmes listaDeFilmes = new ListaDeFilmes(filmesSelecionadosPeloUsuario);
            listaDeFilmes.Show();
            this.Hide();
        }

        private void btnAddABailarina_Click(object sender, EventArgs e)
        {
            // Enquanto o app roda, os nomes dos filmes são salvos na listbox quando o usuário clica no botão de adicionar o filme //

            string Bailarina = "Bailarina - (2023)";

            if (DadosGlobais.filmesSalvos.Contains(Bailarina))
            {
                MessageBox.Show("O filme já está na lista!");
            }
            else
            {
                DadosGlobais.filmesSalvos.Add(Bailarina);
            }
 
            // Código para o botão indicar a seleção e mostrar o poster | tela temporária //

            filmesSelecionadosPeloUsuario.Add(posterABailarina);
            btnAddABailarina.Text = "ADICIONADO";
            btnAddABailarina.ForeColor = Color.White;
            btnAddABailarina.BackColor = Color.LightCoral;
        }
        private void btnAdicionarBelaEAFera_Click(object sender, EventArgs e)
        {
            string aBelaeaFera = "A Bela e a Fera - Live Action (2017)";

            if (DadosGlobais.filmesSalvos.Contains(aBelaeaFera))
            {
                MessageBox.Show("O filme já está na lista!");
            }
            else
            {
                DadosGlobais.filmesSalvos.Add(aBelaeaFera);
            }
             
            filmesSelecionadosPeloUsuario.Add(posterABelaEAfera);
            btnAdicionarBelaEAFera.Text = "ADICIONADO";
            btnAdicionarBelaEAFera.ForeColor = Color.White;
            btnAdicionarBelaEAFera.BackColor = Color.LightCoral;
        }

        private void btnAdicionarFrozen2_Click(object sender, EventArgs e)
        {
            string frozen2 = "Frozen 2 - (2019)";

            if (DadosGlobais.filmesSalvos.Contains(frozen2))
            {
                MessageBox.Show("O filme já está na lista!");
            }
            else
            {
                DadosGlobais.filmesSalvos.Add(frozen2);
            }

            filmesSelecionadosPeloUsuario.Add(posterFrozen2);
            btnAdicionarFrozen2.Text = "ADICIONADO";
            btnAdicionarFrozen2.ForeColor = Color.White;
            btnAdicionarFrozen2.BackColor = Color.LightCoral;
        }

        private void btnAdicionarBacurau_Click(object sender, EventArgs e)
        {
            string bacurau = "Bacurau - (2019)";

            if (DadosGlobais.filmesSalvos.Contains(bacurau))
            {
                MessageBox.Show("O filme já está na lista!");
            }
            else
            {
                DadosGlobais.filmesSalvos.Add(bacurau);
            }

            filmesSelecionadosPeloUsuario.Add(posterBacurau);
            btnAdicionarBacurau.Text = "ADICIONADO";
            btnAdicionarBacurau.ForeColor = Color.White;
            btnAdicionarBacurau.BackColor = Color.LightCoral;
        }

        private void btnAdicionarFrozen_Click(object sender, EventArgs e)
        {
            string frozen = "Frozen - (2013)";

            if (DadosGlobais.filmesSalvos.Contains(frozen))
            {
                MessageBox.Show("O filme já está na lista!");
            }
            else
            {
                DadosGlobais.filmesSalvos.Add(frozen);
            }
                
            filmesSelecionadosPeloUsuario.Add(posterFrozen);
            btnAdicionarFrozen.Text = "ADICIONADO";
            btnAdicionarFrozen.ForeColor = Color.White;
            btnAdicionarFrozen.BackColor = Color.LightCoral;
        }

        private void btnAdicionarMulan_Click(object sender, EventArgs e)
        {
            string mulan = "Mulan - Live Action (2019)";

            if (DadosGlobais.filmesSalvos.Contains(mulan))
            {
                MessageBox.Show("O filme já está na lista!");
            }
            else
            {
                DadosGlobais.filmesSalvos.Add(mulan);
            }
           

            filmesSelecionadosPeloUsuario.Add(posterMulan);
            btnAdicionarMulan.Text = "ADICIONADO";
            btnAdicionarMulan.ForeColor = Color.White;
            btnAdicionarMulan.BackColor = Color.LightCoral;
        }

        private void btnAdicionarBarbie_Click(object sender, EventArgs e)
        {
            string barbie = "Barbie - (2023)";

            if (DadosGlobais.filmesSalvos.Contains(barbie))
            {
                MessageBox.Show("O filme já está na lista!");
            }
            else
            {
                DadosGlobais.filmesSalvos.Add(barbie);

            }

            filmesSelecionadosPeloUsuario.Add(posterBarbie);
            btnAdicionarBarbie.Text = "ADICIONADO";
            btnAdicionarBarbie.ForeColor = Color.White;
            btnAdicionarBarbie.BackColor = Color.LightCoral;
        }

        private void btnAdicionarFabrica_Click(object sender, EventArgs e)
        {
            string fabrica = "A Fantástica Fábrica de Chocolates - (1971)";

            if (DadosGlobais.filmesSalvos.Contains(fabrica))
            {
                MessageBox.Show("O filme já está na lista!");
            }
            else
            {
                DadosGlobais.filmesSalvos.Add(fabrica);

            }

            filmesSelecionadosPeloUsuario.Add(posterFabrica);
            btnAdicionarFabrica.Text = "ADICIONADO";
            btnAdicionarFabrica.ForeColor = Color.White;
            btnAdicionarFabrica.BackColor = Color.LightCoral;
        }

        private void btnAdicionarRapunzel_Click(object sender, EventArgs e)
        {
            string rapunzel = "Rapunzel - (2010)";

            if (DadosGlobais.filmesSalvos.Contains(rapunzel))
            {
                MessageBox.Show("O filme já está na lista!");
            }
            else
            {
                DadosGlobais.filmesSalvos.Add(rapunzel);

            }
            filmesSelecionadosPeloUsuario.Add(posterRapunzel);
            btnAdicionarRapunzel.Text = "ADICIONADO";
            btnAdicionarRapunzel.ForeColor = Color.White;
            btnAdicionarRapunzel.BackColor = Color.LightCoral;
        }

        private void btnAdicionarBrilho_Click(object sender, EventArgs e)
        {
            string brilho = "Brilho Eterno de uma Mente Sem Lembranças - (2004)";

            if (DadosGlobais.filmesSalvos.Contains(brilho))
            {
                MessageBox.Show("O filme já está na lista!");
            }
            else
            {
                DadosGlobais.filmesSalvos.Add(brilho);
            }
            filmesSelecionadosPeloUsuario.Add(posterBrilhoEternoDeUmaMenteSemLembrancas);
            btnAdicionarBrilho.Text = "ADICIONADO";
            btnAdicionarBrilho.ForeColor = Color.White;
            btnAdicionarBrilho.BackColor = Color.LightCoral;
        }

        private void btnAdicionarCasa_Click(object sender, EventArgs e)
        {
            string casa = "A Casa Montro - (2006)";

            if (DadosGlobais.filmesSalvos.Contains(casa))
            {
                MessageBox.Show("O filme já está na lista!");
            }
            else
            {
                DadosGlobais.filmesSalvos.Add(casa);
            }

            filmesSelecionadosPeloUsuario.Add(posterCasa);
            btnAdicionarCasa.Text = "ADICIONADO";
            btnAdicionarCasa.ForeColor = Color.White;
            btnAdicionarCasa.BackColor = Color.LightCoral;
        }

        private void btnAdicionarFarofeiros_Click(object sender, EventArgs e)
        {
            string farofeiros = "Os Farofeiros - (2018)";

            if (DadosGlobais.filmesSalvos.Contains(farofeiros))
            {
                MessageBox.Show("O filme já está na lista!");
            }
            else
            {
                DadosGlobais.filmesSalvos.Add(farofeiros);
            }

            filmesSelecionadosPeloUsuario.Add(posterFarofeiros);
            btnAdicionarFarofeiros.Text = "ADICIONADO";
            btnAdicionarFarofeiros.ForeColor = Color.White;
            btnAdicionarFarofeiros.BackColor = Color.LightCoral;

        }

        private void btnAdicionarYourName_Click(object sender, EventArgs e)
        {
            string yourname = "Your Name - (2016)";

            if (DadosGlobais.filmesSalvos.Contains(yourname))
            {
                MessageBox.Show("O filme já está na lista!");
            }
            else
            {
                DadosGlobais.filmesSalvos.Add(yourname);
            }
            filmesSelecionadosPeloUsuario.Add(posterYourName);
            btnAdicionarYourName.Text = "ADICIONADO";
            btnAdicionarYourName.ForeColor = Color.White;
            btnAdicionarYourName.BackColor = Color.LightCoral;

        }

        private void btnAdicionarCentralDoBrasil_Click(object sender, EventArgs e)
        {
            string central = "Central do Brasil - (1998)";

            if (DadosGlobais.filmesSalvos.Contains(central))
            {
                MessageBox.Show("O filme já está na lista!");
            }
            else
            {
                DadosGlobais.filmesSalvos.Add(central);
            }

            filmesSelecionadosPeloUsuario.Add(posterCentralDoBrasil);
            btnAdicionarCentralDoBrasil.Text = "ADICIONADO";
            btnAdicionarCentralDoBrasil.ForeColor = Color.White;
            btnAdicionarCentralDoBrasil.BackColor = Color.LightCoral;

        }

        private void btnAdicionarSoulmate_Click(object sender, EventArgs e)
        {
            string soulmate = "Soulmate - (2023)";

            if (DadosGlobais.filmesSalvos.Contains(soulmate))
            {
                MessageBox.Show("O filme já está na lista!");
            }
            else
            {
                DadosGlobais.filmesSalvos.Add(soulmate);
            }
            filmesSelecionadosPeloUsuario.Add(posterSoulmate);
            btnAdicionarSoulmate.Text = "ADICIONADO";
            btnAdicionarSoulmate.ForeColor = Color.White;
            btnAdicionarSoulmate.BackColor = Color.LightCoral;

        }

        private void btnAdicionarOAmorMoraAoLado_Click(object sender, EventArgs e)
        {
            string oamormoraaolado = "O Amor Mora ao Lado - (2024 - Serie)";

            if (DadosGlobais.filmesSalvos.Contains(oamormoraaolado))
            {
                MessageBox.Show("O filme já está na lista!");
            }
            else
            {
                DadosGlobais.filmesSalvos.Add(oamormoraaolado);
            }

            filmesSelecionadosPeloUsuario.Add(posterOAmorMoraAoLado);
            btnAdicionarOAmorMoraAoLado.Text = "ADICIONADO";
            btnAdicionarOAmorMoraAoLado.ForeColor = Color.White;
            btnAdicionarOAmorMoraAoLado.BackColor = Color.LightCoral;

        }

        private void btnAdicionarAteQueASorteNosSepare_Click(object sender, EventArgs e)
        {
            string sorte = "Até Que a Sorte Nos Separe - (2012)";

            if (DadosGlobais.filmesSalvos.Contains(sorte))
            {
                MessageBox.Show("O filme já está na lista!");
            }
            else
            {
                DadosGlobais.filmesSalvos.Add(sorte);
            }
            filmesSelecionadosPeloUsuario.Add(posterAteQueASorteNosSepare);
            btnAdicionarAteQueASorteNosSepare.Text = "ADICIONADO";
            btnAdicionarAteQueASorteNosSepare.ForeColor = Color.White;
            btnAdicionarAteQueASorteNosSepare.BackColor = Color.LightCoral;

        }

        private void btnAdicionarJohnWick_Click(object sender, EventArgs e)
        {
            string john = "John Wick - (2014)";

            if (DadosGlobais.filmesSalvos.Contains(john))
            {
                MessageBox.Show("O filme já está na lista!");
            }
            else
            {
                DadosGlobais.filmesSalvos.Add(john);
            }
            filmesSelecionadosPeloUsuario.Add(posterJohnWick);
            btnAdicionarJohnWick.Text = "ADICIONADO";
            btnAdicionarJohnWick.ForeColor = Color.White;
            btnAdicionarJohnWick.BackColor = Color.LightCoral;

        }

        private void btnAdicionarMyName_Click(object sender, EventArgs e)
        {
            string myname = "My Name - (2021 - Serie)";

            if (DadosGlobais.filmesSalvos.Contains(myname))
            {
                MessageBox.Show("O filme já está na lista!");
            }
            else
            {
                DadosGlobais.filmesSalvos.Add(myname);
            }

            filmesSelecionadosPeloUsuario.Add(posterMyName);
            btnAdicionarMyName.Text = "ADICIONADO";
            btnAdicionarMyName.ForeColor = Color.White;
            btnAdicionarMyName.BackColor = Color.LightCoral;

        }

        private void btnAdicionarPulpFiction_Click(object sender, EventArgs e)
        {
            string fiction = "Pulp Fiction - (1994)";

            if (DadosGlobais.filmesSalvos.Contains(fiction))
            {
                MessageBox.Show("O filme já está na lista!");
            }
            else
            {
                DadosGlobais.filmesSalvos.Add(fiction);
            }

            filmesSelecionadosPeloUsuario.Add(posterPulpFiction);
            btnAdicionarPulpFiction.Text = "ADICIONADO";
            btnAdicionarPulpFiction.ForeColor = Color.White;
            btnAdicionarPulpFiction.BackColor = Color.LightCoral;

        }

        private void btnAPequenaSereia_Click(object sender, EventArgs e)
        {
            string pequena = "A Pequena Sereia - Live Action (2023)";

            if (DadosGlobais.filmesSalvos.Contains(pequena))
            {
                MessageBox.Show("O filme já está na lista!");
            }
            else
            {
                DadosGlobais.filmesSalvos.Add(pequena);
            }
            filmesSelecionadosPeloUsuario.Add(posterAPequenaSereia);
            btnAPequenaSereia.Text = "ADICIONADO";
            btnAPequenaSereia.ForeColor = Color.White;
            btnAPequenaSereia.BackColor = Color.LightCoral;

        }

        private void btnAdicionarRainha_Click(object sender, EventArgs e)
        {
            string rainha = "Rainha das Lágrimas - (2024 - Serie)";

            if (DadosGlobais.filmesSalvos.Contains(rainha))
            {
                MessageBox.Show("O filme já está na lista!");
            }
            else
            {
                DadosGlobais.filmesSalvos.Add(rainha);
            }

            filmesSelecionadosPeloUsuario.Add(posterRainha);
            btnAdicionarRainha.Text = "ADICIONADO";
            btnAdicionarRainha.ForeColor = Color.White;
            btnAdicionarRainha.BackColor = Color.LightCoral;

        }

        private void btnAdicionarNana_Click(object sender, EventArgs e)
        {
            string nana = "Nana - (2006 - Serie)";

            if (DadosGlobais.filmesSalvos.Contains(nana))
            {
                MessageBox.Show("O filme já está na lista!");
            }
            else
            {
                DadosGlobais.filmesSalvos.Add(nana);
            }
            filmesSelecionadosPeloUsuario.Add(posterNana);
            btnAdicionarNana.Text = "ADICIONADO";
            btnAdicionarNana.ForeColor = Color.White;
            btnAdicionarNana.BackColor = Color.LightCoral;

        }

        private void btnAdicionarOperacao_Click(object sender, EventArgs e)
        {
            string operacao = "Operação Cupido - (1998)";
            if (DadosGlobais.filmesSalvos.Contains(operacao))
            {
                MessageBox.Show("O filme já está na lista!");
            }
            else
            {
                DadosGlobais.filmesSalvos.Add(operacao);
            }

            filmesSelecionadosPeloUsuario.Add(posterOperacao);
            btnAdicionarOperacao.Text = "ADICIONADO";
            btnAdicionarOperacao.ForeColor = Color.White;
            btnAdicionarOperacao.BackColor = Color.LightCoral;

        }

        private void btnAdicionarKillBill1_Click(object sender, EventArgs e)
        {
            string killbill = "Kill Bill Vol.1 - (2003)";
            if (DadosGlobais.filmesSalvos.Contains(killbill))
            {
                MessageBox.Show("O filme já está na lista!");
            }
            else
            {
                DadosGlobais.filmesSalvos.Add(killbill);
            }

            filmesSelecionadosPeloUsuario.Add(posterKillBill1);
            btnAdicionarKillBill1.Text = "ADICIONADO";
            btnAdicionarKillBill1.ForeColor = Color.White;
            btnAdicionarKillBill1.BackColor = Color.LightCoral;

        }

        private void btnAdicionarKillBill2_Click(object sender, EventArgs e)
        {
            string killbill2 = "Kill Bill Vol.2 - (2004)";

            if (DadosGlobais.filmesSalvos.Contains(killbill2))
            {
                MessageBox.Show("O filme já está na lista!");
            }
            else
            {
                DadosGlobais.filmesSalvos.Add(killbill2);
            }
            filmesSelecionadosPeloUsuario.Add(posterKillBill2);
            btnAdicionarKillBill2.Text = "ADICIONADO";
            btnAdicionarKillBill2.ForeColor = Color.White;
            btnAdicionarKillBill2.BackColor = Color.LightCoral;

        }

        private void btnAdicionarJogo_Click(object sender, EventArgs e)
        {
            string jogo = "Jogo da Morte - (2024 - Serie)";

            if (DadosGlobais.filmesSalvos.Contains(jogo))
            {
                MessageBox.Show("O filme já está na lista!");
            }
            else
            {
                DadosGlobais.filmesSalvos.Add(jogo);
            }
            filmesSelecionadosPeloUsuario.Add(posterJogo);
            btnAdicionarJogo.Text = "ADICIONADO";
            btnAdicionarJogo.ForeColor = Color.White;
            btnAdicionarJogo.BackColor = Color.LightCoral;

        }

        private void btnAdicionarRei_Click(object sender, EventArgs e)
        {
            string rei = "O Rei do Show - (2017)";

            if (DadosGlobais.filmesSalvos.Contains(rei))
            {
                MessageBox.Show("O filme já está na lista!");
            }
            else
            {
                DadosGlobais.filmesSalvos.Add(rei);
            }

            filmesSelecionadosPeloUsuario.Add(posterRei);
            btnAdicionarRei.Text = "ADICIONADO";
            btnAdicionarRei.ForeColor = Color.White;
            btnAdicionarRei.BackColor = Color.LightCoral;

        }

        private void btnAdicionarQuestao_Click(object sender, EventArgs e)
        {
            string questao = "Questão de Tempo - (2013)";

            if (DadosGlobais.filmesSalvos.Contains(questao))
            {
                MessageBox.Show("O filme já está na lista!");
            }
            else
            {
                DadosGlobais.filmesSalvos.Add(questao);
            }

            filmesSelecionadosPeloUsuario.Add(posterQuestao);
            btnAdicionarQuestao.Text = "ADICIONADO";
            btnAdicionarQuestao.ForeColor = Color.White;
            btnAdicionarQuestao.BackColor = Color.LightCoral;

        }

        private void btnAdicionarUrsos_Click(object sender, EventArgs e)
        {
            string ursosemcurso = "Ursos Sem Curso - (2015-2019 - Serie)";

            if (DadosGlobais.filmesSalvos.Contains(ursosemcurso))
            {
                MessageBox.Show("O filme já está na lista!");
            }
            else
            {
                DadosGlobais.filmesSalvos.Add(ursosemcurso);
            }

            filmesSelecionadosPeloUsuario.Add(posterUrsos);
            btnAdicionarUrsos.Text = "ADICIONADO";
            btnAdicionarUrsos.ForeColor = Color.White;
            btnAdicionarUrsos.BackColor = Color.LightCoral;

        }

        private void btnVoltarTelaInicial_Click(object sender, EventArgs e)
        {
            TelaDeInicio telaDeInicio = new TelaDeInicio();
            telaDeInicio.Show();
            this.Hide();
        }
    }
}
