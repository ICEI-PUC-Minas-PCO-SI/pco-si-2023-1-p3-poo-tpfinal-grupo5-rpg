﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Text.RegularExpressions;

namespace telaCombate
{
    public partial class telaPerPronto : Form
    {
        private Raca racaSelecionada;
        private Classe classeSelecionada;
        protected string nome;
        public Jogavel Personagem { get; set; }
        public telaPerPronto(Raca racaSelecionada, Classe classeSelecionada)
        {
            InitializeComponent();
            this.racaSelecionada = racaSelecionada;
            this.classeSelecionada = classeSelecionada;
            
        }
        private string RemoverAcentos(string texto)
        {
            string textoNormalizado = texto.Normalize(NormalizationForm.FormD);
            var regex = new Regex("\\p{IsCombiningDiacriticalMarks}+");
            string textoSemAcentos = regex.Replace(textoNormalizado, string.Empty);
            return textoSemAcentos;
        }

        private void telaPerPronto_Load(object sender, EventArgs e)
        {
            racaPersonagem.Text = racaSelecionada.Nome;
            classePersonagem.Text = classeSelecionada.Nome;
            descricaoRaca.Text = racaSelecionada.Descricao;
            descricaoClasse.Text = classeSelecionada.Descricao;

            string nomeImagem = $"{RemoverAcentos(racaSelecionada.Nome.ToLower())}_{RemoverAcentos(classeSelecionada.Nome.ToLower())}";

            if (Properties.Resources.ResourceManager.GetObject(nomeImagem) is Image imagem)
            {
                imgPersonagem.Image = imagem;
            }
            else
            {
                imgPersonagem.Image = Properties.Resources.O_Culto_do_abismo;
            }

        }

        private void nomePersonagem_TextChanged(object sender, EventArgs e)
        {
            string texto = nomePersonagem.Text;

            if (!string.IsNullOrWhiteSpace(texto) && texto.All(char.IsLetter))
            {
                nome = texto;
            }
            else
            {
               MessageBox.Show("O campo 'Nome' deve ser preenchido apenas com letras.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnJogar_Click(object sender, EventArgs e)
        {
            Jogavel personagem = new Jogavel(nome, classeSelecionada, racaSelecionada);
            telaJogo formJogo = new telaJogo(racaSelecionada, classeSelecionada, nome);
            formJogo.Personagem = personagem;
            formJogo.Show();
            this.Hide();
            imgPersonagem.Image = null;
        }
        private void telaPerPronto_FormClosed(object sender, FormClosedEventArgs e)
        {
            imgPersonagem.Image = null;
        }

    }
}
