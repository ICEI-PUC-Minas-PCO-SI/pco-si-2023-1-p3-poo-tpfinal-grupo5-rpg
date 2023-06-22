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
    public partial class falarComOrion : Form
    {
        public Jogavel Personagem { get; set; }
        private Raca racaSelecionada;
        private Classe classeSelecionada;
        protected string nome;
        private List<string> historiaOrigon;
        private int indiceAtual;
        public falarComOrion(Raca racaSelecionada, Classe classeSelecionada, string nome)
        {
            InitializeComponent();
            InitializeHistoria();
            this.racaSelecionada = racaSelecionada;
            this.classeSelecionada = classeSelecionada;
            this.nome = nome;
        }

        private void falarComOrion_Load(object sender, EventArgs e)
        {
            textoConversa.Text = "VOCÊ: Senhor! Eu consegui! Libertei Luna. Estamos prontos para acabar com isso.";

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
            string imgIrma = "irma";
            if (Properties.Resources.ResourceManager.GetObject(imgIrma) is Image imagemLunaIrma)
            {
                imgLuna.Image = imagemLunaIrma;
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

                "ORION: Bem-vindo de volta, garoto! Vamos continuar a nossa luta",
                "ORION: Enquanto você esteve fora, tive mais algumas visões..",
                "VOCÊ: E o que as visões mostraram, senhor?",
                "ORION: Era uma garota. Ela foi manipulada por eles. Está hipnotizada",
                "VOCÊ: Conte mais"
                

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
        }
    }
}
