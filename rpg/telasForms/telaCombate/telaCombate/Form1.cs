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
        public Jogavel Personagem { get; set; }
        private Raca racaSelecionada;
        private Classe classeSelecionada;
        protected string nome;
        private int vidaAtual;
        //private Combatente combatenteInimigo;
        public Form1(Raca racaSelecionada, Classe classeSelecionada, string nome)
        {
            InitializeComponent();
            this.racaSelecionada = racaSelecionada;
            this.classeSelecionada = classeSelecionada;
            this.nome = nome;
            //combatenteInimigo = CriarCombatenteInimigo();
        }
        //private Combatente CriarCombatenteInimigo()
        //{
        //    Combatente inimigo = new Combatente();
        //    inimigo.Vida = 100;
        //    inimigo.Mana = 50;
        //    inimigo.Ataque = 20;
        //    inimigo.Defesa = 15;
        //    inimigo.Sorte = 10;
        //    inimigo.Nivel = 1;
        //    inimigo.Ataques = new List<Ataque>();

            
        //}

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
            Ataque basico = new Ataque("Básico", 5, 0, 90);
            lblInformacoes.Text = $"Dano: {basico.Dano}, Gasto de Mana: {basico.GastoDeMana}, Índice de Acerto: {basico.ChanceDeAcerto}%";
        }
        private void btnAtaqMedio_Click(object sender, EventArgs e)
        {
            Ataque ataqueMedio;

            if (classeSelecionada.Nome == "Guerreiro")
            {
                ataqueMedio = new Ataque("Corajoso", 10, 10, 80);
            }
            else if (classeSelecionada.Nome == "Clerigo")
            {
                ataqueMedio = new Ataque("Chamado Divino", 10, 10, 80);
            }
            else if (classeSelecionada.Nome  == "Ladino")
            {
                ataqueMedio = new Ataque("Dilacerar", 20, 10, 70);
            }
            else if (classeSelecionada.Nome == "Tanque")
            {
                ataqueMedio = new Ataque("Cabeçada", 15, 10, 75);
            }
            else if (classeSelecionada.Nome ==  "Arqueiro")
            {
                ataqueMedio = new Ataque("Engenhoso", 20, 20, 80);
            }
            else
            {
                
                ataqueMedio = new Ataque("Ataque Médio", 10, 10, 75);
            }

            lblInformacoes.Text = $"Ataque: {ataqueMedio.Nome} Dano: {ataqueMedio.Dano}, Gasto de Mana: {ataqueMedio.GastoDeMana}, Índice de Acerto: {ataqueMedio.ChanceDeAcerto}%";
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            moedasPersonagem.Text = Personagem.Dinheiro.ToString();
            int vidaMaxima = Personagem.Vida;
            vidaAtual = Personagem.Vida;
            progressBarVida.Maximum = vidaMaxima;
            progressBarVida.Value = vidaAtual;


            testeLabel.Text = "Vida: " + Personagem.Vida.ToString();


            string nomeImagem = $"{RemoverAcentos(racaSelecionada.Nome.ToLower())}_{RemoverAcentos(classeSelecionada.Nome.ToLower())}";

            if (Properties.Resources.ResourceManager.GetObject(nomeImagem) is Image imagem)
            {
                playerImg.Image = imagem;
            }
            //Personagem.VidaAtual = Personagem.Vida 
            progressBarVida.Maximum = Personagem.Vida;
            //vidaPersonagem.Value = Personagem.VidaAtual;
            //ProgressBarRenderer.SetColor(vidaPersonagem, Color.Red);
        }

        private void ReceberDano(int quantidadeDano)
        {
            vidaAtual -= quantidadeDano;

            if (vidaAtual <= 0)
            {
                vidaAtual = 0; 

                MessageBox.Show("Você foi derrotado!");
            }

            progressBarVida.Value = vidaAtual; 
            testeLabel.Text = "Vida: " + vidaAtual.ToString(); 
        }
        private void vidaPersonagem_Click(object sender, EventArgs e)
        {
         
            
        }
    }
    }