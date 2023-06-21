using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace telaCombate
{
    public partial class casaPersonagem : Form
    {
        public Jogavel Personagem { get; set; }
        private Raca racaSelecionada;
        private Classe classeSelecionada;
        
        protected string nome;
        private List<string> historiaLuna;
        private List<string> historiaOrigon;
        private int indiceAtual;
        public casaPersonagem(Raca racaSelecionada, Classe classeSelecionada, string nome)
        {
            InitializeComponent();
            InitializeHistoria();
            this.racaSelecionada = racaSelecionada;
            this.classeSelecionada = classeSelecionada;
            this.nome = nome;
        }

        private void casaPersonagem_Load(object sender, EventArgs e)
        {
            textoConversa.Text = "VOCÊ: Luna! Cheguei! Vou pegar uma mochila e ir até a casa do velho Orion.. Você vai pirar quando souber o que anda acontecendo por aqui";

            string nomeImagem = $"{RemoverAcentos(racaSelecionada.Nome.ToLower())}_{RemoverAcentos(classeSelecionada.Nome.ToLower())}";

            if (Properties.Resources.ResourceManager.GetObject(nomeImagem) is Image imagem)
            {
                imgPersonagem.Image = imagem;
            }
        }
        private void InitializeHistoria()
        {
            historiaLuna = new List<string>
            {
                "VOCÊ: Luna? Você tá no quarto?",
                "VOCÊ: Luna? Cadê você?",
                "VOCÊ: Oi? Luna? Tá me escutando?",
                "VOCÊ: Luna olha só hein, se isso for uma brincadeira é melhor parar agora. Tô falando sério",
                "VOCÊ: Luna???!!!!!! Onde você tá???????",
                "VOCÊ: Não é possível que isso tá acontecendo....",
                "VOCÊ: Cadê a minha irmã???? Eu preciso encontra-la."

            };
        }

        private string RemoverAcentos(string texto)
        {
            string textoNormalizado = texto.Normalize(NormalizationForm.FormD);
            var regex = new Regex("\\p{IsCombiningDiacriticalMarks}+");
            string textoSemAcentos = regex.Replace(textoNormalizado, string.Empty);
            return textoSemAcentos;
        }

        private void btnProsseguir_Click(object sender, EventArgs e)
        {
            if (indiceAtual < historiaLuna.Count)
            {
                textoConversa.Text = historiaLuna[indiceAtual];
                indiceAtual++;
            }
            else
            {
                btnProsseguir.Visible = false;
                btnIrPraCasa.Visible = true;
            }

        }

        private void btnIrPraCasa_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.casaVelho;
            textoConversa.Text = "ORION: Ah, finalmente você chegou! Eu estava esperando por você. Sente - se, vamos conversar.";
            btnIrPraCasa.Visible = false;
            btnProsseguir2.Visible = true;
            indiceAtual = 0;
            string imgOrion = "anciao";
            if (Properties.Resources.ResourceManager.GetObject(imgOrion) is Image imagemNovoNPC)
            {
                imgNpc.Image = imagemNovoNPC;
            }
            InitializeHistoriaVelho();
            
        }
        private void InitializeHistoriaVelho()
        {
            historiaOrigon = new List<string>
            {
                "VOCÊ: Senhor, minha irmã desapareceu. Eu temo que algo de ruim possa ter acontecido. A irmã da Celeste também sumiu.. Por favor me diga o que está havendo",
                "ORION: Veja garoto, eu sou um guardião dos antigos segredos deste lugar.",
                "ORION: Agora eu vejo que é você quem aparecia em minhas visões proféticas. ",
                "ORION: Uma dessas visões revelou o confronto entre você, Oibaf, e o Cultista secreto...",
                "VOCÊ: Oibaf? Cultista secreto? Senhor Orion, o senhor está bem? Anda tendo alucinações? Isso pode ser alguma doença",
                "ORION: Escute-me, garoto. Oibaf era o ser supremo mais poderoso do submundo em que habitava. Ele era considerado o rei pelos seus servos. ",
                "ORION: Porém, seu mundo foi devastado por guerras e ele veio para a terra em busca de formar um novo exercíto para retomar o que era seu.",
                "ORION: Ele queria mais poder e recursos para reconstruir seu império e criar uma nova seita para servi-lo, visando se tornar o ser mais supremo de toda a realidade.",
                "ORION: Porém seu plano foi por água abaixo. Ele foi derrotado por um humano ao qual subestimou.",
                "VOCÊ: E quem conseguiu derrotar Oibaf?",
                "ORION: Um protetor que agora está fraco demais para conseguir fazer isso novamente.",
                "VOCÊ: Pera aí, é o que eu tô pensando?? O senhor??",
                "ORION: ...",
                "VOCÊ: E o que aconteceu com Oibaf???",
                "ORION: Depois de uma batalha incessante, Oibaf foi enfraquecido pelo protetor da terra. Ele foi enviado para um grande e obscuro abismo encantado, onde poderosos encantamentos o aprisionam. ",
                "ORION: Além disso, sua condição fraca o impedia de escapar. Oibaf estava com poucos poderes e sua habilidade hipnose quase não funcionava. Porém alguém o ajudou...",
                "VOCÊ: Mas o que isso tem a ver com os desaparecimentos e o comportamento dos bichos?",
                "ORION: Primeiro Oibaf começou a usar seus poderes para hipnotizar os animais. Através disso ele conseguiu força o suficiente para começar a capturar humanos. Nota que os desaparecimentos são de pessoas mais novas? Isso por que é mais fácil para ele se alocar no cerébro que alguém mais jovem.",
                "VOCÊ: Então minha irmã está com ele????",
                "ORION: Não necessariamente com ele, mas sim, está sendo controlada.",
                "VOCÊ: E o que devemos fazer para impedir o plano de Oibaf??",
                "ORION: As últimas visões proféticas que tive apontavam para a caverna. Você deve começar por lá.",
                "VOCÊ: Vamos começar então. Não permitiremos que Z traga sua destruição para este mundo."
            };

            indiceAtual = 0;
        }

        private void btnProsseguir2_Click(object sender, EventArgs e)
        {
            if (indiceAtual < historiaOrigon.Count)
            {
                textoConversa.Text = historiaOrigon[indiceAtual];
                indiceAtual++;
            }
            else
            {
                btnProsseguir2.Visible = false;

                btnIrPraCasa.Visible = false;

                btnIrPraCaverna.Visible = true;
            }
        }

        private void btnIrPraCaverna_Click(object sender, EventArgs e)
        {
            imgPersonagem.Image = null;
            imgNpc.Image = null;
            Jogavel personagem = new Jogavel(nome, classeSelecionada, racaSelecionada);
            telaCaverna formsCaverna = new telaCaverna(racaSelecionada, classeSelecionada, nome);
            formsCaverna.Personagem=personagem;
            formsCaverna.Show();
            this.Hide();
        }
    }
}
