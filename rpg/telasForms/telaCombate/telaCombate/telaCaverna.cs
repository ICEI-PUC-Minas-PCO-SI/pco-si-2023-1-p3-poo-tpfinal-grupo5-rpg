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
            //int cultistaIndex = Dado.RandomNumber(0, 4);
            cultista = PessoasProntas.CultistaTanque();
            //Infos personagem
            //nivelPersonagem.Text = Personagem.Nivel.ToString();

            //Infos Inimigo
            nomeInimigo.Text = "";
            vidaInimigo.Text = cultista.Vida.ToString();

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
        private void btnAtaqBase_Click(object sender, EventArgs e)
        {
            ataqueEscolhido = AtaquesProntos.Basico();
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
                ataqueEscolhido = new Ataque("Ataque Médio", 10, 10, 75);
            }
        }
        private void btnBatalhar_Click(object sender, EventArgs e)
        {
            lblInformacoes.Text = "";
            CombateCultista combate = new CombateCultista(Personagem, cultista);

            nomeInimigo.Text = "Cultista";

            btnBatalhar.Text = "Executar ação";

            if (ataqueEscolhido == null)
            {
                MessageBox.Show("Vamos batalhar! Selecione um ataque.");
                return;
            }

            if (combate.Personagem.Mana < ataqueEscolhido.GastoDeMana)
            {

                MessageBox.Show("Mana insuficiente para usar esse ataque!");
                return;
            }
            else
            {

                int dano = combate.Personagem.atacar(ataqueEscolhido);
                combate.Cultista.defender(dano);
                int danoInimigo = combate.Cultista.atacar(AtaquesProntos.Basico());
                combate.Personagem.defender(danoInimigo);
                lblInformacoes.Text += $"Você causou {dano} de dano. O inimigo causou {danoInimigo} de dano.";
                vidaPersonagem.Text = Personagem.Vida.ToString();
                manaPersonagem.Text = Personagem.Mana.ToString();
                vidaInimigo.Text = combate.Cultista.Vida.ToString();
            }


            if (Personagem.Vida <= 0)
            {
                MessageBox.Show("Você foi derrotado pelo inimigo!");
                vidaPersonagem.Text = "0";
                manaPersonagem.Text = Personagem.Mana.ToString();
                vidaInimigo.Text = combate.Cultista.Vida.ToString();
                MessageBox.Show("FIM DE JOGO");
                this.Close();
            }
            else if (cultista.Vida <= 0)
            {
                vidaInimigo.Text = "0";
                int dinheiroDropado = cultista.droparDinheiro();
                Personagem.ReceberDinheiro(dinheiroDropado);
                MessageBox.Show($"Você venceu a batalha contra o inimigo e recebeu {dinheiroDropado} moedas!");

                //Leva pra outra tela
                 playerImg.Image = null;
                Jogavel personagem = new Jogavel(nome, classeSelecionada, racaSelecionada);
                maisHistoria formsHistoria = new maisHistoria(racaSelecionada, classeSelecionada, nome);
                formsHistoria.Personagem = personagem;
                formsHistoria.Show();
                this.Hide();
            }
        }

        //private void btnAtaqEspecial_Click(object sender, EventArgs e)
        //{
        //    //MessageBox.Show("dsfsidofoidf");
        //}

        private void btnAtaqEspecial_Click_1(object sender, EventArgs e)
        {
            if (classeSelecionada.Nome == "Guerreiro")
            {
                ataqueEscolhido = AtaquesProntos.GolpeFurioso();
            }
            else if (classeSelecionada.Nome == "Clerigo")
            {
                ataqueEscolhido = AtaquesProntos.CuraDivina();
            }
            else if (classeSelecionada.Nome == "Ladino")
            {
                ataqueEscolhido = AtaquesProntos.AtaqueSorrateiro();
            }
            else if (classeSelecionada.Nome == "Tanque")
            {
                ataqueEscolhido = AtaquesProntos.EscudoDeProtecao();
            }
            else if (classeSelecionada.Nome == "Arqueiro")
            {
                ataqueEscolhido = AtaquesProntos.ChuvaDeFlechas();
            }
            else
            {
                ataqueEscolhido = new Ataque("Ataque Especial", 30, 20, 100);
            }
        }
    }
}
