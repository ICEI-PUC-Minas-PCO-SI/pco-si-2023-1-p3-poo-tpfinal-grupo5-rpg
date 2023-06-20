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
            ataqueEscolhido = new Ataque("B�sico", 5, 0, 90);
            lblInformacoes.Text = $"Dano: {ataqueEscolhido.Dano}, Gasto de Mana: {ataqueEscolhido.GastoDeMana}, �ndice de Acerto: {ataqueEscolhido.ChanceDeAcerto}%";
        }

        private void btnAtaqMedio_Click(object sender, EventArgs e)
        {
            if (classeSelecionada.Nome == "Guerreiro")
            {
                ataqueEscolhido = AtaquesProntos.Corajoso();
            }
            else if (classeSelecionada.Nome == "Clerigo")
            {
                ataqueEscolhido = AtaquesProntos.ChamadoDivino();
            }
            else if (classeSelecionada.Nome == "Ladino")
            {
                ataqueEscolhido = AtaquesProntos.Dilacerar();
            }
            else if (classeSelecionada.Nome == "Tanque")
            {
                ataqueEscolhido = AtaquesProntos.Cabecada();
            }
            else if (classeSelecionada.Nome == "Arqueiro")
            {
                ataqueEscolhido = AtaquesProntos.Engenhoso();
            }
            else
            {
                ataqueEscolhido = new Ataque("Ataque M�dio", 10, 10, 75);
            }

            lblInformacoes.Text = $"Ataque: {ataqueEscolhido.Nome} Dano: {ataqueEscolhido.Dano}, Gasto de Mana: {ataqueEscolhido.GastoDeMana}, �ndice de Acerto: {ataqueEscolhido.ChanceDeAcerto}%";
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
                int danoPersonagem = combate.Personagem.atacar(ataquePersonagem);
                Personagem.defender(danoPersonagem);

                if (combate.Inimigo.Vida <= 0)
                    break;
                int danoInimigo = javali.atacar();
                Personagem.defender (danoInimigo);

                lblInformacoes.Text = $"Voc� causou {danoPersonagem} de dano. O inimigo causou {danoInimigo} de dano.";
            }

            if (Personagem.Vida <= 0)
            {
                MessageBox.Show("Voc� foi derrotado pelo inimigo!");
            }
            else if (javali.vida <= 0)
            {
                int dinheiroDropado = javali.droparDinheiro();
                Personagem.ReceberDinheiro(dinheiroDropado);
                MessageBox.Show($"Voc� venceu a batalha contra o inimigo e recebeu {dinheiroDropado} moedas!");
            }
            else
            {
                MessageBox.Show("A batalha terminou em empate!");
            }
        }
    }
}
