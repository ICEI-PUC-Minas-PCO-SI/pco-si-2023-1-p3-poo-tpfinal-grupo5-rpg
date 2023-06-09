﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace telaCombate
{
    public partial class telaClasse : Form
    {
        private Raca racaSelecionada = new Raca();
        public telaClasse(Raca racaSelecionada)
        {
            InitializeComponent();
            this.racaSelecionada = racaSelecionada;
        }
        private Classe classeSelecionada;

        private void telaClasse_Load(object sender, EventArgs e)
        {
            racaTexto.Text = racaSelecionada.Nome;
        }
        private void btnGuerreiro_Click(object sender, EventArgs e)
        {
            classeSelecionada = ClassesProntas.Guerreiro();
        }

        private void btnArqueiro_Click(object sender, EventArgs e)
        {
            classeSelecionada = ClassesProntas.Arqueiro();
        }

        private void btnLadino_Click(object sender, EventArgs e)
        {
            classeSelecionada = ClassesProntas.Ladino();
        }

        private void btnClerigo_Click(object sender, EventArgs e)
        {
            classeSelecionada = ClassesProntas.Clerigo();
        }

        private void btnTanque_Click(object sender, EventArgs e)
        {
            classeSelecionada = ClassesProntas.Tanque();
        }

        private void btnProsseguir_Click(object sender, EventArgs e)
        {
            telaPerPronto formsPerPronto = new telaPerPronto(racaSelecionada, classeSelecionada);
            formsPerPronto.Show();
            this.Hide();
        }

        private void racaTexto_Click(object sender, EventArgs e)
        {

        }
    }
}
