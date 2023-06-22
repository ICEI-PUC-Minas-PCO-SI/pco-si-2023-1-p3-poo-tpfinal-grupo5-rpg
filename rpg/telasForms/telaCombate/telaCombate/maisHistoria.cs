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
    public partial class maisHistoria : Form
    {
        public Jogavel Personagem { get; set; }
        private Raca racaSelecionada;
        private Classe classeSelecionada;
        protected string nome;
        private List<string> historiaOrigon;
        private int indiceAtual;
        public maisHistoria(Raca racaSelecionada, Classe classeSelecionada, string nome)
        {
            InitializeComponent();
            InitializeHistoria();
            this.racaSelecionada = racaSelecionada;
            this.classeSelecionada = classeSelecionada;
            this.nome = nome;
        }

        private void maisHistoria_Load(object sender, EventArgs e)
        {
            textoConversa.Text = "VOCÊ: Senhor! Eu fui até a caverna, como me pediu";
            string nomeImagem = $"{RemoverAcentos(racaSelecionada.Nome.ToLower())}_{RemoverAcentos(classeSelecionada.Nome.ToLower())}";

            if (Properties.Resources.ResourceManager.GetObject(nomeImagem) is Image imagem)
            {
                imgPersonagem.Image = imagem;
            }

            string imgOrion = "anciao";
            if (Properties.Resources.ResourceManager.GetObject(imgOrion) is Image imagemNovoNPC)
            {
                imgNpc.Image = imagemNovoNPC;
            }
        }
        private string RemoverAcentos(string texto)
        {
            string textoNormalizado = texto.Normalize(NormalizationForm.FormD);
            var regex = new Regex("\\p{IsCombiningDiacriticalMarks}+");
            string textoSemAcentos = regex.Replace(textoNormalizado, string.Empty);
            return textoSemAcentos;
        }
        private void InitializeHistoria()
        {
            historiaOrigon = new List<string>
            {
                
                "ORION: Me conte, o que aconteceu, garoto? Você está palido",
                "VOCÊ: Eu nunca tinha visto uma pessoa vestida daquela forma, senhor Orion.. Foi tudo muito estranho",
                "ORION: São eles...",
                "VOCÊ: Eles quem?",
                "ORION: Os Cultistas do Abismo, garoto, não faça perguntas tolas",
                "VOCÊ: Então ele estão com a minha irmã??",
                "ORION: Sim. Ou talvez...",
                "VOCÊ: Talvez o que?",
                "ORION: Talvez ela possa ter sido hipnotizada e agora faz parte deles.",
                "VOCÊ: Minha irmã jamais participaria de um culto para acabar com o mundo, não fale isso senhor",
                "ORION: Garoto, que parte de hipnotizada você não entendeu?",
                "VOCÊ: Eu entendi, senhor. ",
                "VOCÊ: Enfim, temos que continuar nossa jornada, garoto. Vá para a vila."

            };
        }

        private void btnProsseguir_Click(object sender, EventArgs e)
        {
            if (indiceAtual < historiaOrigon.Count)
            {
                textoConversa.Text = historiaOrigon[indiceAtual];
                indiceAtual++;
            }
            else
            {
                btnProsseguir.Visible = false;
                btnSeguirHist.Visible = true;
               
            }
        }

        private void btnSeguirHist_Click(object sender, EventArgs e)
        {
            imgPersonagem.Image = null;
            imgNpc.Image = null;
            Jogavel personagem = new Jogavel(nome, classeSelecionada, racaSelecionada);
            telaVila formsVila = new telaVila(racaSelecionada, classeSelecionada, nome);
            formsVila.Personagem = personagem;
            formsVila.Show();
            this.Hide();
        }
    }
}
