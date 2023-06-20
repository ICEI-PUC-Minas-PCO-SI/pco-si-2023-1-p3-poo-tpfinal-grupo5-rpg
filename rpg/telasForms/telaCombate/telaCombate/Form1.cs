using Microsoft.VisualBasic.Devices;
using System.Text.RegularExpressions;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;
using System.Drawing;
using System;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace telaCombate
{
    public partial class Form1 : Form
    {
        private Animal javali;
        private Animal lobo;
        public Jogavel Personagem { get; set; }
        private Raca racaSelecionada;
        private Classe classeSelecionada;
        protected string nome;

        private Ataque ataqueEscolhido; 

        public Form1(Raca racaSelecionada, Classe classeSelecionada, string nome)
        {
            InitializeComponent();
            this.racaSelecionada = racaSelecionada;
            this.classeSelecionada = classeSelecionada;
            this.nome = nome;
        }

        private string RemoverAcentos(string texto)
        {
            string textoNormalizado = texto.Normalize(NormalizationForm.FormD);
            var regex = new Regex("\\p{IsCombiningDiacriticalMarks}+");
            string textoSemAcentos = regex.Replace(textoNormalizado, string.Empty);
            return textoSemAcentos;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void btnAtaqBase_Click(object sender, EventArgs e)
        {
            ataqueEscolhido = new Ataque("Básico", 5, 0, 90);
            lblInformacoes.Text = $"Dano: {ataqueEscolhido.Dano}, Gasto de Mana: {ataqueEscolhido.GastoDeMana}, Índice de Acerto: {ataqueEscolhido.ChanceDeAcerto}%";
        }

        private void btnAtaqMedio_Click(object sender, EventArgs e)
        {
            if (classeSelecionada.Nome == "Guerreiro")
            {
                ataqueEscolhido = new Ataque("Corajoso", 10, 10, 80);
            }
            else if (classeSelecionada.Nome == "Clerigo")
            {
                ataqueEscolhido = new Ataque("Chamado Divino", 10, 10, 80);
            }
            else if (classeSelecionada.Nome == "Ladino")
            {
                ataqueEscolhido = new Ataque("Dilacerar", 20, 10, 70);
            }
            else if (classeSelecionada.Nome == "Tanque")
            {
                ataqueEscolhido = new Ataque("Cabeçada", 15, 10, 75);
            }
            else if (classeSelecionada.Nome == "Arqueiro")
            {
                ataqueEscolhido = new Ataque("Engenhoso", 20, 20, 80);
            }
            else
            {
                ataqueEscolhido = new Ataque("Ataque Médio", 10, 10, 75);
            }

            lblInformacoes.Text = $"Ataque: {ataqueEscolhido.Nome} Dano: {ataqueEscolhido.Dano}, Gasto de Mana: {ataqueEscolhido.GastoDeMana}, Índice de Acerto: {ataqueEscolhido.ChanceDeAcerto}%";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Animal[] animais = AnimaisProntos.geraAnimais();
            javali = animais[0];
            lobo = animais[1];

            moedasPersonagem.Text = Personagem.Dinheiro.ToString();
            int vidaMaxima = Personagem.Vida;
            progressBarVida.Maximum = vidaMaxima;

            testeLabel.Text = "Vida: " + Personagem.Vida.ToString();

            string nomeImagem = $"{RemoverAcentos(racaSelecionada.Nome.ToLower())}_{RemoverAcentos(classeSelecionada.Nome.ToLower())}";

            if (Properties.Resources.ResourceManager.GetObject(nomeImagem) is Image imagem)
            {
                playerImg.Image = imagem;
            }

            progressBarVida.Maximum = Personagem.Vida;
        }

        private void vidaPersonagem_Click(object sender, EventArgs e)
        {

        }

        private void btnBatalhar_Click(object sender, EventArgs e)
        {
            Combate combate = new Combate(Personagem, AnimaisProntos.Javali());

            lblInformacoes.Text = "";

            while (Personagem.Vida > 0 && javali.vida > 0)
            {
                Ataque ataquePersonagem = ataqueEscolhido;
                int danoPersonagem = combate.Personagem.Atacar(ataquePersonagem);
                Personagem.Defender(danoPersonagem);

                if (combate.Inimigo.Vida <= 0)
                    break;

                Ataque ataqueInimigo = javali.atacar();
                int danoInimigo = combate.Inimigo.Atacar(ataqueInimigo);
                Personagem.defender (danoInimigo);

                lblInformacoes.Text = $"Você causou {danoPersonagem} de dano. O inimigo causou {danoInimigo} de dano.";
            }

            if (Personagem.Vida <= 0)
            {
                MessageBox.Show("Você foi derrotado pelo inimigo!");
            }
            else if (javali.vida <= 0)
            {
                int dinheiroDropado = javali.droparDinheiro();
                Personagem.ReceberDinheiro(dinheiroDropado);
                MessageBox.Show($"Você venceu a batalha contra o inimigo e recebeu {dinheiroDropado} moedas!");
            }
            else
            {
                MessageBox.Show("A batalha terminou em empate!");
            }
        }
    }
}
