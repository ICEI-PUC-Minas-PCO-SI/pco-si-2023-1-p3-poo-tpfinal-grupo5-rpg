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
    public partial class telaCaverna : Form
    {
        public Jogavel Personagem { get; set; }
        private Raca racaSelecionada;
        private Classe classeSelecionada;
        private Ataque ataqueEscolhido;
        private Arma armaPlayer;
        private Pessoa cultista;
        protected string nome;

        public int ManaAtual
        {
            get => Personagem.Mana;
        }
        public telaCaverna(Raca racaSelecionada, Classe classeSelecionada, string nome)
        {
            InitializeComponent();
            this.racaSelecionada = racaSelecionada;
            this.classeSelecionada = classeSelecionada;
            this.nome = nome;
        }

        private void telaCaverna_Load(object sender, EventArgs e)
        {
            cultista = PessoasProntas.CultistaTanque();
            //Infos personagem
            //nivelPersonagem.Text = Personagem.Nivel.ToString();
            moedasPersonagem.Text = Personagem.Dinheiro.ToString();
            vidaPersonagem.Text = Personagem.Vida.ToString();
            manaPersonagem.Text = Personagem.Mana.ToString();
            //Img personagem
            string nomeImagem = $"{RemoverAcentos(racaSelecionada.Nome.ToLower())}_{RemoverAcentos(classeSelecionada.Nome.ToLower())}";

            if (Properties.Resources.ResourceManager.GetObject(nomeImagem) is Image imagem)
            {
                playerImg.Image = imagem;
            }

            //Arma personagem
            armaPlayer = SelecionarArma();
            ListViewItem itemArma = new ListViewItem(armaPlayer.Nome);
            itemArma.SubItems.Add("1");
            listInventario.Items.Add(itemArma);
        }
        private string RemoverAcentos(string texto)
        {
            string textoNormalizado = texto.Normalize(NormalizationForm.FormD);
            var regex = new Regex("\\p{IsCombiningDiacriticalMarks}+");
            string textoSemAcentos = regex.Replace(textoNormalizado, string.Empty);
            return textoSemAcentos;
        }
        private Arma SelecionarArma()
        {
            if (classeSelecionada.Nome == "Guerreiro")
            {
                return armaPlayer = ArmasProntas.EspadaLonga();

            }
            else if (classeSelecionada.Nome == "Clerigo")
            {
                return armaPlayer = ArmasProntas.Cajado();
            }
            else if (classeSelecionada.Nome == "Ladino")
            {
                return armaPlayer = ArmasProntas.Adaga();
            }
            else if (classeSelecionada.Nome == "Tanque")
            {
                return armaPlayer = ArmasProntas.MarteloDeGuerra();
            }
            else if (classeSelecionada.Nome == "Arqueiro")
            {
                return armaPlayer = ArmasProntas.ArcoCurto();
            }
            else
            {
                return null;
            }
        }

        private void btnBatalhar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Vamos batalhar! Selecione um ataque.");
            lblInformacoes.Text = "";
            CombateCultista combate = new CombateCultista(Personagem, cultista);
           //Resto do código da batalha...
        }

    }
}
