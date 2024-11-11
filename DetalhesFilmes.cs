using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AplicativoMyCineList
{
    public partial class DetalhesFilmes : Form
    {
        public DetalhesFilmes()
        {
            InitializeComponent();
        }



        private void cmb_nomesFilmes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void SelecioneOFilmeShow()
        {
            cmb_nomesFilmes.Items.Add("A Bailarina");
            cmb_nomesFilmes.Items.Add("A Bela e a Fera");
            cmb_nomesFilmes.Items.Add("A Casa Monstro");
            cmb_nomesFilmes.Items.Add("A Fantástica Fábrica de Chocolates");
            cmb_nomesFilmes.Items.Add("A Pequena Sereia");
            cmb_nomesFilmes.Items.Add("Até que a Sorte nos Separe");
            cmb_nomesFilmes.Items.Add("Bacurau");
            cmb_nomesFilmes.Items.Add("Barbie");
            cmb_nomesFilmes.Items.Add("Brilho Eterno de uma Mente Sem Lembranças");
            cmb_nomesFilmes.Items.Add("Central do Brasil");
            cmb_nomesFilmes.Items.Add("Farofeiros");
            cmb_nomesFilmes.Items.Add("Frozen");
            cmb_nomesFilmes.Items.Add("Frozen II");
            cmb_nomesFilmes.Items.Add("John Wick");
            cmb_nomesFilmes.Items.Add("Kill Bill Vol. 1");
            cmb_nomesFilmes.Items.Add("Kill Bill Vol. 2");
            cmb_nomesFilmes.Items.Add("Mulan");
            cmb_nomesFilmes.Items.Add("My Name");
            cmb_nomesFilmes.Items.Add("Nana");
            cmb_nomesFilmes.Items.Add("O Amor Mora ao Lado");
            cmb_nomesFilmes.Items.Add("O Jogo da Morte");
            cmb_nomesFilmes.Items.Add("O Rei do Show");
            cmb_nomesFilmes.Items.Add("Operação Cupido");
            cmb_nomesFilmes.Items.Add("Pulp Fiction");
            cmb_nomesFilmes.Items.Add("Questão de Tempo");
            cmb_nomesFilmes.Items.Add("Rainha das Lágrimas");
            cmb_nomesFilmes.Items.Add("Rapunzel");
            cmb_nomesFilmes.Items.Add("Soulmate");
            cmb_nomesFilmes.Items.Add("Urso Sem Curso");
            cmb_nomesFilmes.Items.Add("Your Name");
        }

        private void DetalhesFilmes_Load(object sender, EventArgs e)
        {
            SelecioneOFilmeShow();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string FilmeEscolhido = cmb_nomesFilmes.SelectedItem.ToString();
            string sinopsedofilme = "";
            string duracao = "";
            string pais = "";
            string atores = "";
            string titulo = "";
            string diretor = "";
            string nomeoriginal = "";
            


            if (FilmeEscolhido == "A Bela e a Fera")
            {
                pictureBox1.Image = Properties.Resources.BelaAdd;
                nomeoriginal = "A Bela e a Fera";
                titulo = "Nome Original: La Belle et la Bête";
                sinopsedofilme = "Bela é uma jovem sensível e compreensiva, que sempre põe os outros em primeiro lugar. Quando seu pai se vê em uma situação complicada após contrair uma dívida e perder sua liberdade, ela não hesita em viver em um castelo ao lado de um ser horrível para que possa salvá-lo. Também prisioneira, mas tratada como convidada na opulenta mansão, Bela começa a enxergar a beleza do caráter da misteriosa criatura e passa a sentir afeto por ele.";
                duracao = "Duração: 1 hora e 52 minutos";
                pais = "Pais de origem: França, 2014";
                atores = "Elenco Principal: Vincent Cassel, Léa Seydoux";
                diretor = "Dirigido por: Christophe Gans";
            }

            else if (FilmeEscolhido == "A Casa Monstro")
            {
                pictureBox1.Image = Properties.Resources.CasaAdd;
                nomeoriginal = "A Casa Monstro";
                titulo = "Nome Original: Monster House";
                sinopsedofilme = "Nenhum adulto acredita quando três adolescentes falam que existe uma casa no bairro que é uma criatura perigosa. Com o Dia das Bruxas se aproximando, eles têm que descobrir uma forma de destruir a casa antes que ela faça mal a crianças inocentes.";
                duracao = "Duração: 1 hora e 31 minutos";
                pais = "Pais de origem: Estados Unidos, 2006";
                atores = "Elenco Principal: Mitchel Musso, Sam Lerner, Spencer Locke";
                diretor = "Dirigido por: Gil Kenan";
            }

            else if (FilmeEscolhido == "A Fantástica Fábrica de Chocolates")
            {
                pictureBox1.Image = Properties.Resources.FabricaAdd;
                nomeoriginal = "A Fantástica Fábrica de Chocolates";
                titulo = "Nome Original: Charlie and the Chocolate Factory";
                sinopsedofilme = "Willy Wonka (Johnny Depp) é o excêntrico dono da maior fábrica de doces do planeta, que decide realizar um concurso mundial para escolher um herdeiro para seu império. Cinco crianças de sorte, entre elas Charlie Bucket (Freddie Highmore), encontram um convite dourado em barras de chocolate Wonka e com isso ganham uma visita guiada pela lendária fábrica de chocolate, que não era visitada por ninguém há 15 anos. Encantado com as maravilhas da fábrica, Charlie fica cada vez mais fascinado com a visita.";
                duracao = "Duração: 1 hora e 55 minutos";
                pais = "Pais de origem: Estados Unidos, 2005";
                atores = "Elenco Principal: Brigitte Millar, Johnny Depp, Freddie Highmore";
                diretor = "Dirigido por: Tim Burton";
            }

            else if (FilmeEscolhido == "A Pequena Sereia")
            {
                // pictureBox1.Image = Properties.Resources.APequenaSereiaAdd; 
                nomeoriginal = "A Pequena Sereia";
                titulo = "Nome Original: The Little Mermaid";
                sinopsedofilme = "Remake live action do clássico desenho animado A Pequena Sereia, de 1989, da Disney. A caçula das filhas do Rei Tritão (Javier Bardem), Ariel (Halle Bailey) é uma bela e espirituosa jovem sereia com sede de aventura. Desejando descobrir mais sobre o mundo além do mar, Ariel visita a superfície e se apaixona intensamente pelo arrojado Príncipe Eric (Jonah Hauer-King), ao salvá-lo de um naufrágio. Mas para procurá-lo em terra firme e se aproximar do príncipe humano, a sereia pede ajuda à bruxa do mar, Úrsula (Melissa McCarthy), e aceita ceder sua voz para que a feiticeira lhe dê pernas. Agora, ela terá o desafio de se comunicar com o rapaz ao experimentar a vida em terra firme, além de entrar em conflito com os valores de sua família. \"A Pequena Sereia\" é um conto de fadas literário escrito pelo autor dinamarquês Hans Christian Andersen, publicado pela primeira vez em 1837.";
                duracao = "Duração: 2 horas e 16 minutos";
                pais = "Pais de origem: Estados Unidos, 2023";
                atores = "Elenco Principal: Halle Bailey, Jonah Hauer-King, Melissa McCarthy";
                diretor = "Dirigido por: Rob Marshall";
            }

            else if (FilmeEscolhido == "Até que a Sorte nos Separe")
            {
                pictureBox1.Image = Properties.Resources.AQAMNSadd;
                nomeoriginal = "Até que a Sorte nos Separe";
                titulo = "Nome Original: Até que a Sorte nos Separe";
                sinopsedofilme = "Tino (Leandro Hassum) é um pai de família comum que vê sua vida virar de ponta a cabeça após ganhar na loteria. Levando uma vida de ostentação ao lado da mulher, Jane (Danielle Winits), ele gasta todo o dinheiro em 15 anos. Ao se ver quebrado, Tino aceita a ajuda do vizinho Amauri (Kiko Mascarenhas), um consultor de finanças super burocrático e que por sinal vive seu próprio drama ao enfrentar uma crise no casamento com Laura (Rita Elmôr). Tentando evitar que Jane descubra a nova situação financeira, afinal ela está grávida do terceiro filho não pode passar por fortes emoções, Tino se envolve em várias confusões para fingir que tudo continua bem. Para isso, conta com ajuda do melhor amigo, Adelson (Aílton Graça), e dos filhos.";
                duracao = "Duração: 1 hora e 30 minutos";
                pais = "Pais de origem: Brasil, 2012";
                atores = "Elenco Principal: Leandro Hassum, Danielle Winits, Kiko Mascarenhas";
                diretor = "Dirigido por: Roberto Santucci";
            }

            else if (FilmeEscolhido == "Bacurau")

            {
                pictureBox1.Image = Properties.Resources.BacurauAdd;
                nomeoriginal = "Bacurau";
                titulo = "Nome Original: Bacurau";
                sinopsedofilme = "Pouco após a morte de dona Carmelita, aos 94 anos, os moradores de um pequeno povoado localizado no sertão brasileiro, chamado Bacurau, descobrem que a comunidade não consta mais em qualquer mapa. Aos poucos, percebem algo estranho na região: enquanto drones passeiam pelos céus, estrangeiros chegam à cidade pela primeira vez. Quando carros se tornam vítimas de tiros e cadáveres começam a aparecer, Teresa (Bárbara Colen), Domingas (Sônia Braga), Acácio (Thomas Aquino), Plínio (Wilson Rabelo), Lunga (Silvero Pereira) e outros habitantes chegam à conclusão de que estão sendo atacados. Falta identificar o inimigo e criar coletivamente um meio de defesa.";
                duracao = "Duração: 2 horas e 10 minutos";
                pais = "Pais de origem: Brasil, 2019";
                atores = "Elenco Principal: Sônia Braga, Udo Kier, Barbara Colen";
                diretor = "Dirigido por: Kleber Mendonça Filho, Juliano Dornelles";
            }
            else if (FilmeEscolhido == "A Bailarina")
            {
                pictureBox1.Image = Properties.Resources.BallerinaAdd;
                titulo = "Nome Original: Ballerina";
                sinopsedofilme = "Em A Bailarina, neste suspense de ação e vingança, a impiedosa ex-guarda-costas Ok-ju (Jun Jong-seo) persegue Choi (Kim Ji-hun), o homem responsável pela morte de sua melhor amiga Min-hee (Park Yu-rim), a quem jurou vingar.";
                duracao = "Duração: 1 hora e 32 minutos";
                pais = "Pais de origem: Coreia do Sul, 2023";
                atores = "Elenco Principal: Jeon Jong-seo, Park Yu-rim, Kim Ji-hoon";
                diretor = "Dirigido por: Chung-Hyun Lee";
            }

            else if (FilmeEscolhido == "Barbie")
            {
                pictureBox1.Image = Properties.Resources.BarbieAdd;
                nomeoriginal = "Barbie";
                titulo = "Nome Original: Barbie";
                sinopsedofilme = "Depois de ser expulsa da Barbieland por ser uma boneca de aparência menos do que perfeita, Barbie parte para o mundo humano em busca da verdadeira felicidade.";
                duracao = "Duração: 1 hora e 54 minutos";
                pais = "Pais de origem: Estados Unidos, 2023";
                atores = "Elenco Principal: Margot Robbie, Ryan Gosling, America Ferreira";
                diretor = "Dirigido por: Greta Gerwig";
            }

            else if (FilmeEscolhido == "Brilho Eterno de uma Mente Sem Lembranças")
            {
                pictureBox1.Image = Properties.Resources.BrilhoAdd;
                nomeoriginal = "Brilho Eterno de uma Mente Sem Lembranças";
                titulo = "Nome Original: Eternal Sunshine of the Spotless Mind";
                sinopsedofilme = "Joel se surpreende ao saber que seu amor verdadeiro, Clementine, o apagou completamente de sua memória. Ele decide fazer o mesmo, mas muda de ideia. Preso dentro da própria mente enquanto os especialistas se mantêm ocupados em seu apartamento, Joel precisa avisá-los para parar.";
                duracao = "Duração: 1 hora e 48 minutos";
                pais = "Pais de origem: Estados Unidos, 2004";
                atores = "Elenco Principal: Jim Carrey, Kate Winslet, Kirsten Dunst";
                diretor = "Dirigido por: Michel Gondry";
            }

            else if (FilmeEscolhido == "Central do Brasil")
            {
                pictureBox1.Image = Properties.Resources.CentraldoBrasilAdd;
                nomeoriginal = "Central do Brasil";
                titulo = "Nome Original: Central do Brasil";
                sinopsedofilme = "Em Central do Brasil, Dora (Fernanda Montenegro) trabalha escrevendo cartas para analfabetos na estação Central do Brasil, no centro da cidade do Rio de Janeiro. Ainda que a escrivã não envie todas as cartas que escreve - as cartas que considera inúteis ou fantasiosas demais -, ela decide ajudar um menino (Vinícius de Oliveira), após sua mãe ser atropelada, a tentar encontrar o pai que nunca conheceu, no interior do Nordeste.";
                duracao = "Duração: 1 hora e 53 minutos";
                pais = "Pais de origem: Brasil, 1998";
                atores = "Elenco Principal: Fernanda Montenegro, Vinicius de Oliveira, Marília Pêra";
                diretor = "Dirigido por: Walter Salles";
            }

            else if (FilmeEscolhido == "Farofeiros")
            {
                pictureBox1.Image = Properties.Resources.FarofeirosAdd;
                nomeoriginal = "Os Farofeiros";
                titulo = "Nome Original: Os Farofeiros";
                sinopsedofilme = "Quatro colegas de trabalho se programam para curtir o feriado prolongado em uma casa de praia e, chegando lá, descobrem que se meteram em uma tremenda roubada. Para começar o destino não é Búzios, mas Maringuaba; a residência alugada é encontrada caindo aos pedaços, bem diferente do prometido; a praia está sempre cheia; e as confusões são inúmeras.";
                duracao = "Duração: 1 hora e 39 minutos";
                pais = "Pais de origem: Brasil, 2018";
                atores = "Elenco Principal: Antônio Fragoso, Maurício Manfrini, Cacau Protási";
                diretor = "Dirigido por: Roberto Santucci";
            }

            else if (FilmeEscolhido == "Frozen")
            {
                pictureBox1.Image = Properties.Resources.FrozenAdd;
                nomeoriginal = "Frozen I";
                titulo = "Nome Original: Frozen";
                sinopsedofilme = "Acompanhada por um vendedor de gelo, a jovem e destemida princesa Anna parte em uma jornada por perigosas montanhas de gelo na esperança de encontrar sua irmã, a rainha Elsa, e acabar com a terrível maldição de inverno eterno, que está provocando o congelamento do reino.";
                duracao = "Duração: 1 hora e 42 minutos";
                pais = "Pais de origem: Estados Unidos, 2013";
                atores = "Elenco Principal: Kristen Bell, Idina Menzel, Jonathan Groff";
                diretor = "Dirigido por: Chris Buck, Jennifer Lee";
            }

            else if (FilmeEscolhido == "Frozen II")
            {
                pictureBox1.Image = Properties.Resources.Frozen2Add;
                nomeoriginal = "Frozen II";
                titulo = "Nome Original: Frozen II";
                sinopsedofilme = "Na trama de Frozen 2, de volta à infância de Elsa e Anna, as duas irmãs descobrem uma história do pai, quando ainda era príncipe de Arendelle. Ele conta às meninas a história de uma visita à floresta dos elementos, onde um acontecimento inesperado teria provocado a separação dos habitantes da cidade com os quatro elementos fundamentais: ar, fogo, terra e água. Esta revelação ajudará Elsa a compreender a origem de seus poderes.";
                duracao = "Duração: 1 hora e 44 minutos";
                pais = "Pais de origem: Estados Unidos, 2019";
                atores = "Elenco Principal: Kristen Bell, Idina Menzel, Jonathan Groff";
                diretor = "Dirigido por: Chris Buck, Jennifer Lee";

            }

            else if (FilmeEscolhido == "John Wick")
            {
                pictureBox1.Image = Properties.Resources.JohnWickAdd;
                nomeoriginal = "John Wick";
                titulo = "Nome Original: John Wick";
                sinopsedofilme = "John Wick (Keanu Reeves) já foi um dos assassinos mais temidos da cidade de Nova York, trabalhando em parceria com a máfia russa. Um dia, ele decide se aposentar, e neste período tem que lidar com a triste morte de sua esposa. Vítima de uma doença grave, ela já previa a sua própria morte, e deu de presente ao marido um cachorro para cuidar em seu período de luto. No entanto, poucos dias após o funeral, o cachorro é morto por ladrões que roubam o seu carro. John Wick parte em busca de vingança contra estes homens que ele já conhecia muito bem, e que roubaram o último símbolo da mulher que ele amava.";
                duracao = "Duração: 1 hora e 41 minutos";
                pais = "Pais de origem: Estados Unidos, 2014";
                atores = "Elenco Principal: Keanu Reeves, Michael Nyqvist, Alfie Allen";
                diretor = "Dirigido por: David Leitch, Chad Stahelski";

            }

            else if (FilmeEscolhido == "Kill Bill Vol. 1")
            {
                pictureBox1.Image = Properties.Resources.KillBillAdd;
                nomeoriginal = "Kill Bill Vol. 1";
                titulo = "Nome Original: Kill Bill Vol. 1";
                sinopsedofilme = "A Noiva (Uma Thurman) é uma perigosa assassina que trabalhava em um grupo, liderado por Bill (David Carradine), composto principalmente por mulheres. Grávida, ela decide escapar dessa vida de violência e decide se casar, mas no dia da cerimônia seus companheiros de trabalho se voltam contra ela, quase a matando. Após cinco anos em coma, ela desperta sem um bebê e com um único desejo: vingança. A Noiva decide procurar, e matar, as cinco pessoas que destruiram o seu futuro, começando pelas perigosas assassinas Vernita Green (Vivica A. Fox) e O-Ren Ishii (Lucy Liu).";
                duracao = "Duração: 1 hora e 52 minutos";
                pais = "Pais de origem: Estados Unidos, 2003";
                atores = "Elenco Principal: Uma Thurman, Sonny Chiba, Lucy Liu";
                diretor = "Dirigido por: Quentin Tarantino";

            }

            else if (FilmeEscolhido == "Kill Bill Vol. 2")
            {
                pictureBox1.Image = Properties.Resources.KB1add;
                nomeoriginal = "Kill Bill Vol. 2";
                titulo = "Nome Original: Kill Bill Vol. 2";
                sinopsedofilme = "Noiva assassina é traída por antigo grupo e fica em coma por quatro anos. Quando acorda, procura vingança e mata seus companheiros um por um. Ao confrontar seu antigo mestre e amante, uma surpresa a espera.";
                duracao = "Duração: 2 horas e 15 minutos";
                pais = "Pais de origem: Estados Unidos, 2004";
                atores = "Elenco Principal: Uma Thurman, David Carradine, Michael Madsen";
                diretor = "Dirigido por: Quentin Tarantino";

            }


            else if (FilmeEscolhido == "Mulan")
            {
                pictureBox1.Image = Properties.Resources.MulanAdd;
                nomeoriginal = "Mulan";
                titulo = "Nome Original: Mulan";
                sinopsedofilme = "Em Mulan, Hua Mulan (Liu Yifei) é a espirituosa e determinada filha mais velha de um honrado guerreiro. Quando o Imperador da China emite um decreto que um homem de cada família deve servir no exército imperial, Mulan decide tomar o lugar de seu pai, que está doente. Assumindo a identidade de Hua Jun, ela se disfarça de homem para combater os invasores que estão atacando sua nação, provando-se uma grande guerreira.";
                duracao = "Duração: 1 hora e 55 minutos";
                pais = "Pais de origem: Estados Unidos, 2020";
                atores = "Elenco Principal: Yifei Liu, Donnie Yen, Gong Li";
                diretor = "Dirigido por: Niki Caro";

            }

            else if (FilmeEscolhido == "My Name")
            {
                pictureBox1.Image = Properties.Resources.MyNameAdd;
                nomeoriginal = "My Name";
                titulo = "Nome Internacional: My Name";
                sinopsedofilme = "My Name, série sul-coreana original da Netflix, acompanha Yoon ji-woo (Han So-hee), uma mulher que, após presenciar o assassinato do pai, busca vingança a todo custo. Ela deposita sua confiança em um chefão do crime organizado da Córeia do Sul que promete justiça a ela. Sob seu comando, Yoon ji-woo entra para polícia coreana na intenção de se tornar informante para ele.";
                duracao = "Duração: 50 Minutos por Episódio | 8 Episódios";
                pais = "Pais de origem: Coreia do Sul, 2021";
                atores = "Elenco Principal: So-Hee Han, Ahn Bo Hyun, Sang-ho Kim";
                diretor = "Dirigido por: Kim Jin-min";

            }

            else if (FilmeEscolhido == "Nana")
            {
                // pictureBox1.Image = Properties.Resources.NanaAdd;
                nomeoriginal = "Nana";
                titulo = "Nome Internacional: Nana";
                sinopsedofilme = "Duas mulheres com o mesmo nome e personalidades completamente diferentes chegam a Tóquio para um novo começo.";
                duracao = "Duração: 22 minutos por Episódio | 47 Episódios";
                pais = "Pais de origem: Japão, 2006";
                atores = "Elenco Principal: Romi Park, Kaori e Hidenobu Kiuchi";
                diretor = "Dirigido por: Morio Asaka";

            }

            else if (FilmeEscolhido == "O Amor Mora ao Lado")
            {
                pictureBox1.Image = Properties.Resources.LoveNextDoorAdd;
                nomeoriginal = "O Amor Mora ao Lado";
                titulo = "Nome Internacional: Love Next Door";
                sinopsedofilme = "Na tentativa de recomeçar a vida, uma mulher retorna à Coreia e se envolve com alguém do passado. O problema é que existe uma história complicada entre os dois.";
                duracao = "Duração: 1 hora por Episódio | 16 Episódios";
                pais = "Pais de origem: Coreia do Sul, 2024";
                atores = "Elenco Principal: Jung Hae-in, Jung So-min e Kim Ji-eun";
                diretor = "Dirigido por: Yoo Je-won";

            }

            else if (FilmeEscolhido == "O Jogo da Morte")
            {
                pictureBox1.Image = Properties.Resources.JogoDaMAdd;
                nomeoriginal = "O Jogo da Morte";
                titulo = "Nome Internacional: Death's Game";
                sinopsedofilme = "Em O Jogo da Morte, um homem precisa viver 12 vidas e passar por 12 mortes para não ir para o inferno. Yee-jay (Seo In-guk) é deixado pela namorada e perde o dinheiro que lhe restava em um golpe de bitcoin. Completamente desesperado, ele comete suicídio, mas a morte se recusa a aceitar o desrespeito aos seus planos e o obriga a passar por um jogo. Yee-jay precisará viver 12 vidas diferentes e morrer 12 vezes e, caso ele sobreviva a alguma delas, viverá naquela encarnação. Caso contrário, está fadado a passar a eternidade no inferno.";
                duracao = "Duração: 45 minutos por Episódio | 6 Episódios";
                pais = "Pais de origem: Coreia do Sul, 2023";
                atores = "Elenco Principal: Seo In-guk, Park So-Dam, Go Yoon Jung";
                diretor = "Dirigido por: Ha Byung-hoon";

            }

            else if (FilmeEscolhido == "O Rei do Show")
            {
                pictureBox1.Image = Properties.Resources.ReiAdd;
                nomeoriginal = "O Rei do Show";
                titulo = "Nome Original: The Greatest Showman";
                sinopsedofilme = "De origem humilde e desde a infância sonhando com um mundo mágico, P.T. Barnum (Hugh Jackman) desafia as barreiras sociais se casando com a filha do patrão do pai e dá o pontapé inicial na realização de seu maior desejo abrindo uma espécie de museu de curiosidades. O empreendimento fracassa, mas ele logo vislumbra uma ousada saída: produzir um grande show estrelado por freaks, fraudes, bizarrices e rejeitados de todos os tipos.";
                duracao = "Duração: 1 hora e 44 minutos";
                pais = "Pais de origem: Estados Unidos, 2017";
                atores = "Elenco Principal: Hugh Jackman, Zac Efron, Michelle Williams";
                diretor = "Dirigido por: Michael Gracey";

            }

            else if (FilmeEscolhido == "Operação Cupido")
            {
                pictureBox1.Image = Properties.Resources.OperacaoAdd;
                nomeoriginal = "Operação Cupido";
                titulo = "Nome Original: The Parent Trap";
                sinopsedofilme = "As gêmeas Hallie e Annie (Lindsay Lohan) foram separadas ainda pequenas. Uma ficou com a mãe, Elizabeth (Natasha Richardson), e outra com o pai, Nicholas (Dennis Quaid). Um dia as duas se encontram num acampamento de verão e se dão conta do parentesco até então desconhecido. Elas trocam de lugar na volta para a casa e elaboram um plano para que o casal volte às boas e a família enfim possa se reunir.";
                duracao = "Duração: 2 horas e 8 minutos";
                pais = "Pais de origem: Estados Unidos, 1999";
                atores = "Elenco Principal: Natasha Richardson, Lindsay Lohan, Dennis Quaid";
                diretor = "Dirigido por: Nancy Meyers";

            }

            else if (FilmeEscolhido == "Pulp Fiction")
               
            {
                pictureBox1.Image = Properties.Resources.PulpAdd;
                nomeoriginal = "Pulp Fiction";
                titulo = "Nome Original: Pulp Fiction";
                sinopsedofilme = "Vincent Vega (John Travolta) e Jules Winnfield (Samuel L. Jackson) são dois assassinos profissionais trabalham fazendo cobranças para Marsellus Wallace (Ving Rhames), um poderosos gângster. Vega é forçado a sair com a garota do chefe, temendo passar dos limites; enquanto isso, o pugilista Butch Coolidge (Bruce Willis) se mete em apuros por ganhar luta que deveria perder.";
                duracao = "Duração: 2 horas e 29 minutos";
                pais = "Pais de origem: Estados Unidos, 1994";
                atores = "Elenco Principal: John Travolta, Samuel L. Jackson, Uma Thurman";
                diretor = "Dirigido por: Quentin Tarantino";

            }

            else if (FilmeEscolhido == "Questão de Tempo")
            {
                pictureBox1.Image = Properties.Resources.QuestaoAdd;
                nomeoriginal = "Questão de Tempo";
                titulo = "Nome Original: About Time";
                sinopsedofilme = "Ao completar 21 anos, Tim (Domhnall Gleeson) é surpreendido com a notícia dada por seu pai (Bill Nighy) de que pertence a uma linhagem de viajantes no tempo. Ou seja, todos os homens da família conseguem viajar para o passado, bastando apenas ir para um local escuro e pensar na época e no local para onde deseja ir. Cético a princípio, Tim logo se empolga com o dom ao ver que seu pai não está mentindo. Sua primeira decisão é usar esta capacidade para conseguir uma namorada, mas logo ele percebe que viajar no tempo e alterar o que já aconteceu pode provocar consequências inesperadas.";
                duracao = "Duração: 2 horas e 3 minutos";
                pais = "Pais de origem: Estados Unidos, 2013";
                atores = "Elenco Principal: Domhnall Gleeson, Bill Nighy, Rachel McAdams";
                diretor = "Dirigido por: Richard Curtis";

            }

            else if (FilmeEscolhido == "Rainha das Lágrimas")
            {
                pictureBox1.Image = Properties.Resources.RainhaAdd;
                nomeoriginal = "Rainha das Lágrimas";
                titulo = "Nome Internacional: Queen Of Tears";
                sinopsedofilme = "Em Rainha das Lágrimas, um casal de magnatas supera uma crise matrimonial ainda que tudo esteja contra eles. No drama coreano, Hyun-woo (Kim Soo-hyun), o diretor de uma rede de supermercados e Hae-in (Kim Ji-won), uma herdeira chaebol de um império de lojas de departamento, se apaixonam intensamente na juventude e logo se casam. O tempo passa e eles entram em uma profunda crise no casamento, mas quando tudo aponta para o pior, o amor volta a florescer e eles vão superando as dificuldades juntos.";
                duracao = "Duração: 1 hora e meia por Episódio | 16 Episódios ";
                pais = "Pais de origem: Coreia do Sul, 2024";
                atores = "Elenco Principal: Soo-hyun Kim, Ji-won Kim, Sung-Hoon Park";
                diretor = "Dirigido por: Jang Young-woo e Kim Hee-won";



            }

        

            else if (FilmeEscolhido == "Rapunzel")
            {
                pictureBox1.Image = Properties.Resources.RapunzelAdd;
                nomeoriginal = "Rapunzel";
                titulo = "Nome Original: Tangled";
                sinopsedofilme = "Flynn Ryder (Zachary Levi/Luciano Huck) é o bandido mais procurado e sedutor do reino. Um dia, em plena fuga, ele se esconde em uma torre. Lá conhece Rapunzel (Mandy Moore), uma jovem prestes a completar 18 anos que tem um enorme cabelo dourado, de 21 metros de comprimento. Rapunzel deseja deixar seu confinamento na torre para ver as luzes que sempre surgem no dia de seu aniversário. Para tanto, faz um acordo com Flynn. Ele a ajuda a fugir e ela lhe devolve a valiosa tiara que tinha roubado. Só que a mamãe Gothel (Donna Murphy), que manteve Rapunzel na torre durante toda a sua vida, não quer que ela deixe o local de jeito nenhum.";
                duracao = "Duração: 1 hora e 41 minutos";
                pais = "Pais de origem: Estados Unidos, 2011";
                atores = "Elenco Principal: Mandy Moore, Luciano Huck, Zachary Levi";
                diretor = "Dirigido por: Byron Howard, Nathan Greno";

            }

            else if (FilmeEscolhido == "Soulmate")
            {
                pictureBox1.Image = Properties.Resources.SoulmateAdd;
                nomeoriginal = "Soulmate";
                titulo = "Nome Internacional: Soulmate";
                sinopsedofilme = "Duas meninas se conheceram aos 13 anos e se tornaram amigas. Pelos próximos 14 anos, as duas meninas experimentam amor, ciúme e crescimento pessoal.";
                duracao = "Duração: 2 horas e 4 minutos";
                pais = "Pais de origem: Coreia do Sul, 2023";
                atores = "Elenco Principal: Jeon So-Nee, Kim Da-Mi";
                diretor = "Dirigido por: Yong-geun Min";

            }

            else if (FilmeEscolhido == "Urso Sem Curso")
            {
                pictureBox1.Image = Properties.Resources.UrsoAdd;
                nomeoriginal = "Urso Sem Curso";
                titulo = "Nome Original: We Bare Bears";
                sinopsedofilme = "Pardo, Panda e Polar são apenas três forasteiros tentando encontrar uma maneira de se adaptar. Se, pelo caminho, eles conseguirem algum sorvete, melhor ainda. Ser um urso no mundo moderno e civilizado não é nada fácil.";
                duracao = "Duração: 11 minutos por Episódio | 140 Episódios";
                pais = "Pais de origem: Estados Unidos, 2015-2019";
                atores = "Elenco Principal: Eric Edelstein, Bobby Moynihan, Max Mitchell";
                diretor = "Dirigido por: Manny Hernandez";

            }

            else if (FilmeEscolhido == "Your Name")
            {
                pictureBox1.Image = Properties.Resources.YourNameAdd;
                // nome original na verdade se refere ao BR-PT //
                nomeoriginal = "Seu Nome";
                titulo = "Nome Internaci;onal: Your Name";
                sinopsedofilme = "Dois estranhos estão ligados de uma maneira bizarra, mais quando uma conexão é formada, a distância será a única coisa que os manterá separados?";
                duracao = "Duração: 1 hora e 50 minutos";
                pais = "Pais de origem: Japão, 2016";
                atores = "Elenco Principal: Ryûnosuke Kamiki, Mone Kamishiraishi, Masami Nagasawa";
                diretor = "Dirigido por:  Makoto Shinkai";

            }

            SinopseDoFilme.Text = sinopsedofilme;
            NomeDoFilme.Text = titulo;
            NomeDoDiretor.Text = diretor;
            PaisDeOrigem.Text = pais;
            DuracaoDoFilme.Text = duracao;
            AtoresPrincipais.Text = atores;
            label1.Text = nomeoriginal;
           


        }

    }
}
