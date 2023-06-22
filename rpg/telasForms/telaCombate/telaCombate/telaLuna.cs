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
    public partial class telaLuna : Form
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
        public telaLuna(Raca racaSelecionada, Classe classeSelecionada, string nome)
        {
            InitializeComponent();
            this.racaSelecionada = racaSelecionada;
            this.classeSelecionada = classeSelecionada;
            this.nome = nome;
        }

        public void botoes(){
            btnAtaqBase.Text = "Básico";
            switch(classeSelecionada.Nome){
                case "Guerreiro":
                    btnAtaqMedio.Text = "Corajoso";
                    btnAtaqEspecial.Text = "Golpe Furioso";
                    break;
                case "Ladino":
                    btnAtaqMedio.Text = "Dilacerar";
                    btnAtaqEspecial.Text = "Ataque Sorrateiro";
                    break;
                case "Arqueiro":
                    btnAtaqMedio.Text = "Engenhoso";
                    btnAtaqEspecial.Text = "Chuva de Flechas";
                    break;
                case "Clerigo":
                    btnAtaqMedio.Text = "Chamado Divino";
                    btnAtaqEspecial.Text = "Cura Divina";
                    break;
                case "Tanque":
                    btnAtaqMedio.Text = "Cabeçada";
                    btnAtaqEspecial.Text = "Escudo de Proteção";
                    break;
            }
        }

        private void telaLuna_Load(object sender, EventArgs e)
        {
            cultista = PessoasProntas.CultistaGuerreiro();

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
        }

        private string RemoverAcentos(string texto)
        {
            string textoNormalizado = texto.Normalize(NormalizationForm.FormD);
            var regex = new Regex("\\p{IsCombiningDiacriticalMarks}+");
            string textoSemAcentos = regex.Replace(textoNormalizado, string.Empty);
            return textoSemAcentos;
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

        private void btnAtaqEspecial_Click(object sender, EventArgs e)
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

        private void btnBatalhar_Click(object sender, EventArgs e)
        {
            botoes();
            lblInformacoes.Text = "";
            CombateCultista combate = new CombateCultista(Personagem, cultista);

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
                playerImg.Image = null;
                imgInimigo.Image = null;
                MessageBox.Show("Você foi derrotado por Luna!");
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
                MessageBox.Show("Você libertou Luna! Agora vocês podem se unir contra Oibaf");

                //Leva pra outra tela
                playerImg.Image = null;
                imgInimigo.Image = null;    
                Jogavel personagem = new Jogavel(nome, classeSelecionada, racaSelecionada);
                falarComOrion formOrion = new falarComOrion(racaSelecionada, classeSelecionada, nome);
                formOrion.Personagem = personagem;
                formOrion.Show();
                this.Hide();
            }
        }
    }
}
