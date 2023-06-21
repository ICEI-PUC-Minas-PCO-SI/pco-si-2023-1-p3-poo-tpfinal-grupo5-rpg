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
    public partial class telaNPCs02 : Form
    {
        public Jogavel Personagem { get; set; }
        private Raca racaSelecionada;
        private Classe classeSelecionada;
        protected string nome;
        private List<string> historiaRagnar;
        private List<string> historiaOrion;
        private int indiceAtual;
        public telaNPCs02(Raca racaSelecionada, Classe classeSelecionada, string nome)
        {
            this.racaSelecionada = racaSelecionada;
            this.classeSelecionada = classeSelecionada;
            this.nome = nome;

            InitializeComponent();
            InitializeHistoria();

        }
        private void InitializeHistoria()
        {
            historiaRagnar = new List<string>
            {
                $"RAGNAR: Meu deus, {nome}! Por isso não tive a mínima coragem de ir até aquela floresta.. Você falou que o javali estava estranho, certo?",
                "VOCÊ: Sim, meu amigo. Estava bem esquisito.. Os olhos dele estavam vermelhos e ele estava com uma força sobrenatural",
                "RAGNAR: Olhos vermelhor e força sobrenatural???? O velho Orion estava falando algo sobre isso",
                "VOCÊ: Como assim, Ragnar? Me conte isso direito!",
                "RAGNAR: Olha, eu só ouvi uma parte da conversa, mas ele estava falando sobre o retorno de alguém",
                "VOCÊ: Retorno de alguém? Alguma pessoa que ele conhece ou algo assim?",
                "RAGNAR: Olha, pelo teor da conversa não era alguém querido pelo velho. Não ouvi muita coisa, por que você não o procura para saber mais detalhes?",
                "VOCÊ: Ótima sugestão, Ragnar. Vou atrás dele agora mesmo."

            };
            historiaOrion = new List<string>
            {
                "VOCÊ: Olá, senhor Orion! Como vai?",
                "ORION: Garoto, não estou de bom humor para conversar fiado hoje.",
                "VOCÊ: Desculpe, senhor. Mas não vim bater papo. Tenho coisas importantes a tratar.",
                "ORION: Te garanto que não são mais importantes do que eu tenho que fazer. Não desperdice meu tempo.",
                "VOCÊ: Olha, senhor, creio que é exatamente sobre isso que venho falar. Estão acontecendo coisas estranhas na vila e..",
                "ORION: E o que, garoto? Acha que eu estou de brincadeira?",
                "VOCÊ: Senhor, me escute! Eu conversei com a Celeste e o Ragnar hoje mais cedo, eles me falaram sobre desaparecimentos e bichos estranhos. Eu fui até a floresta conferir e quase morri em um ataque de javali. O senhor sabe que moro aqui desde que nasci e nunca tive problemas com relação à caça. Hoje o animal estava muito forte. Isso não é normal.",
                "ORION: Meu deus... A Situação é muito pior do que eu imaginava... Temos que agir o mais rápido possível antes que...",
                "VOCÊ: Antes que o que, senhor?",
                "ORION: Garoto, preciso de você. Pegue suas coisas e vamos até mimha casa.",
                "VOCÊ: Certo, mas você vai ter que me contar o que realmente está acontecendo."
            };
        }
        private string RemoverAcentos(string texto)
        {
            string textoNormalizado = texto.Normalize(NormalizationForm.FormD);
            var regex = new Regex("\\p{IsCombiningDiacriticalMarks}+");
            string textoSemAcentos = regex.Replace(textoNormalizado, string.Empty);
            return textoSemAcentos;
        }
        private void telaNPCs02_Load(object sender, EventArgs e)
        {
            textoConversa.Text = "VOCÊ: Ragnar! Acabo de voltar da floresta. Quase fui morto por um javali totalmente estranho... Agora sim vejo por que está tão preocupado!";
            string nomeImagem = $"{RemoverAcentos(racaSelecionada.Nome.ToLower())}_{RemoverAcentos(classeSelecionada.Nome.ToLower())}";

            if (Properties.Resources.ResourceManager.GetObject(nomeImagem) is Image imagem)
            {
                imgPersonagem.Image = imagem;
            }
        }

        

        private void textoConversa_Click(object sender, EventArgs e)
        {

        }

        private void btnProsseguir_Click(object sender, EventArgs e)
        {
                if (indiceAtual < historiaRagnar.Count)
                {
                    textoConversa.Text = historiaRagnar[indiceAtual];
                    indiceAtual++;
                }
            else if (indiceAtual < historiaRagnar.Count + historiaOrion.Count)
            {
                textoConversa.Text = historiaOrion[indiceAtual - historiaRagnar.Count];
                indiceAtual++;
                string imgOrion = "anciao";
                if (Properties.Resources.ResourceManager.GetObject(imgOrion) is Image imagemNovoNPC)
                {
                    imgNpc.Image = imagemNovoNPC;
                }
            }
            else
            {
                btnProsseguir.Visible = false;
                btnIrPraCasa.Visible = true;


            }
        }

        private void btnIrPraCasa_Click(object sender, EventArgs e)
        {
            imgPersonagem.Image = null;
            imgNpc.Image = null;
            Jogavel personagem = new Jogavel(nome, classeSelecionada, racaSelecionada);
            casaPersonagem formCasa = new casaPersonagem(racaSelecionada, classeSelecionada, nome);
            formCasa.Personagem= personagem;
            formCasa.Show();
            this.Hide();
        }
    }
}
