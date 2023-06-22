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
    public partial class batalhaOibaf : Form
    {
        public Jogavel Personagem { get; set; }
        private Raca racaSelecionada;
        private Classe classeSelecionada;
        private Ataque ataqueEscolhido;
        private Arma armaPlayer;
        private Combatente monstro;
        protected string nome;

        public int ManaAtual
        {
            get => Personagem.Mana;
        }
        public batalhaOibaf(Raca racaSelecionada, Classe classeSelecionada, string nome)
        {
            InitializeComponent();
            this.racaSelecionada = racaSelecionada;
            this.classeSelecionada = classeSelecionada;
            this.nome = nome;
        }

        public void botoes()
        {
            btnAtaqBase.Text = "Básico";
            switch (classeSelecionada.Nome)
            {
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

        private void batalhaOibaf_Load(object sender, EventArgs e)
        {
            nomeInimigo.Text = "Oibaf";
            //monstro = new Monstro("Oibaf", 20, 1500, 200, 50, 30, 100, 1, ataques);

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
    }
}
