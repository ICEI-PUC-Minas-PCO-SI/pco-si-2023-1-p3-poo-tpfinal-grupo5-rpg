using Microsoft.VisualBasic.Devices;
using System.Text.RegularExpressions;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;
using System.Drawing;
using System;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Threading;

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

        public int ManaAtual
        {
            get => Personagem.Mana;
        }

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
            // lblInformacoes.Text = $"Dano: {ataqueEscolhido.Dano}, Gasto de Mana: {ataqueEscolhido.GastoDeMana}, �ndice de Acerto: {ataqueEscolhido.ChanceDeAcerto}%";
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

            // lblInformacoes.Text = $"Ataque: {ataqueEscolhido.Nome} Dano: {ataqueEscolhido.Dano}, Gasto de Mana: {ataqueEscolhido.GastoDeMana}, �ndice de Acerto: {ataqueEscolhido.ChanceDeAcerto}%";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Animal[] animais = AnimaisProntos.geraAnimais();
            javali = animais[0];
            lobo = animais[1];

            vidaInimigo.Text = javali.vida.ToString();

            moedasPersonagem.Text = Personagem.Dinheiro.ToString();
            

            vidaPersonagem.Text = Personagem.Vida.ToString();
            manaPersonagem.Text = Personagem.Mana.ToString();
           
            

            string nomeImagem = $"{RemoverAcentos(racaSelecionada.Nome.ToLower())}_{RemoverAcentos(classeSelecionada.Nome.ToLower())}";

            if (Properties.Resources.ResourceManager.GetObject(nomeImagem) is Image imagem)
            {
                playerImg.Image = imagem;
            }
        }

        private void vidaPersonagem_Click(object sender, EventArgs e)
        {

        }

        private void btnBatalhar_Click(object sender, EventArgs e)
        {
            lblInformacoes.Text = "";
            Combate combate = new Combate(Personagem, javali);

            btnBatalhar.Text = "Executar ação";
            if (ataqueEscolhido == null)
            {
                MessageBox.Show("Vamos batalhar! Selecione um ataque.");
                return;
            }

            if (Personagem.Mana < ataqueEscolhido.GastoDeMana)
            {
                MessageBox.Show("Mana insuficiente para usar esse ataque!");
                return;
            }
            else{
                int dano = combate.Personagem.atacar(ataqueEscolhido);
                combate.Inimigo.defender(dano);
                int danoInimigo = combate.Inimigo.atacar();
                combate.Personagem.defender(danoInimigo);
                lblInformacoes.Text += $"Você causou {dano} de dano. O inimigo causou {danoInimigo} de dano.";
            }

            // lblInformacoes.Text = "";

            // while (Personagem.Vida > 0 && javali.vida > 0)
            // {
            //     int danoPersonagem = combate.Personagem.atacar(ataqueEscolhido);
            //     //Personagem.defender(danoPersonagem);
            //     lblInformacoes.Text = $"Você causou {danoPersonagem} de dano.";

            //     if (javali.vida <= 0)
            //         break;

            //     System.Threading.Thread.Sleep(100);

            //     int danoInimigo = javali.atacar();
            //     int vidaAtual = (Personagem.Vida - danoInimigo); 
            //     vidaPersonagem.Text = vidaAtual.ToString();
            //     Personagem.defender(danoInimigo);
            //     lblInformacoes.Text += $" O inimigo causou {danoInimigo} de dano.";

            //     System.Threading.Thread.Sleep(100000);
            // }
            

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

            vidaPersonagem.Text = Personagem.Vida.ToString();
            manaPersonagem.Text = Personagem.Mana.ToString();
            vidaInimigo.Text = combate.Inimigo.vida.ToString();
        }




    }
}
