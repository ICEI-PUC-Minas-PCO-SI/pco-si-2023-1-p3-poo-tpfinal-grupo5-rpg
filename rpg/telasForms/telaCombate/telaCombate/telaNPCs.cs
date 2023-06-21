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
    public partial class telaNPCs : Form
    {
        private Raca racaSelecionada;
        private Classe classeSelecionada;
        private List<string> historiaCeleste;
        private List<string> historiaRagnar;
        private int indiceAtual;
        protected string nome;
        public Jogavel Personagem { get; set; }
        public telaNPCs(Raca racaSelecionada, Classe classeSelecionada, string nome)
        {
            InitializeComponent();
            InitializeHistoria();
            this.racaSelecionada = racaSelecionada;
            this.classeSelecionada = classeSelecionada;
            indiceAtual = 0;
            this.nome = nome;
        }
        private void InitializeHistoria()
        {
            historiaCeleste = new List<string>
            {
                $"CELESTE: Olá! Eu estou apavorada! Primeiro foram os bichos daquele jeito estranho, agora tem moradores sumindo... Minha irmã Dulce foi buscar lenha hoje de manhã e não voltou mais. Estou ficando com medo do pior",
                "VOCÊ: Eu sinto muito, Celeste. Não se preocupe, vamos dar um jeito de encontra-lá. Vou conversar com mais algumas pessoas para colher informações. Obrigado"
            };
            historiaRagnar = new List<string>
            {
                "VOCÊ: Ragnar. Quanto tempo! Como estão as coisas por aqui?",
                "RAGNAR: Saudações, meu caro. Para ser sincero, não vão muito bem... As pessoas estão aterrorizadas com os acontecidos.",
                "VOCÊ: Com esses desparecimentos não tem como não temer. Estou tentando organizar os pensamentos pra entender tudo isso, você reparou em algo diferente?",
                "RAGNAR: Eu andei ouvindo sons bem estranhos na floresta. Não tive coragem de investigar.",
                "VOCÊ: Certo, obrigado por falar! Se souber de mais alguma coisa me procure por favor",

            };
        }
        private string RemoverAcentos(string texto)
        {
            string textoNormalizado = texto.Normalize(NormalizationForm.FormD);
            var regex = new Regex("\\p{IsCombiningDiacriticalMarks}+");
            string textoSemAcentos = regex.Replace(textoNormalizado, string.Empty);
            return textoSemAcentos;
        }
        private void telaNPCs_Load(object sender, EventArgs e)
        {
            textoConversa.Text = "VOCÊ: Olá, Celeste! Você sabe me dizer o que está ocorrendo?! Estou vendo coisas estranhas por aqui...";
            string nomeImagem = $"{RemoverAcentos(racaSelecionada.Nome.ToLower())}_{RemoverAcentos(classeSelecionada.Nome.ToLower())}";

            if (Properties.Resources.ResourceManager.GetObject(nomeImagem) is Image imagem)
            {
                imgPersonagem.Image = imagem;
            }

        }

        private void btnProsseguir_Click(object sender, EventArgs e)
        {
            if (indiceAtual < historiaCeleste.Count)
            {
                textoConversa.Text = historiaCeleste[indiceAtual];
                indiceAtual++;
            }
            else if (indiceAtual < historiaCeleste.Count + historiaRagnar.Count)
            {
                textoConversa.Text = historiaRagnar[indiceAtual - historiaCeleste.Count];
                indiceAtual++;
                string imgRagnar = "npc04";
                if (Properties.Resources.ResourceManager.GetObject(imgRagnar) is Image imagemNovoNPC)
                {
                    imgNpc.Image = imagemNovoNPC;
                }
            }
            else
            {
                btnProsseguir.Visible = false; 
                btnIrParaFloresta.Visible = true; 
                

            }


        }

        private void btnIrParaFloresta_Click(object sender, EventArgs e)
        {
            imgPersonagem.Image = null;
            imgNpc.Image = null;    
            Jogavel personagem = new Jogavel(nome, classeSelecionada, racaSelecionada);
            Form1 formsBatalha = new Form1(racaSelecionada, classeSelecionada, nome);
            formsBatalha.Personagem = personagem;
            formsBatalha.Show();
            this.Hide();
        }
    }
}
