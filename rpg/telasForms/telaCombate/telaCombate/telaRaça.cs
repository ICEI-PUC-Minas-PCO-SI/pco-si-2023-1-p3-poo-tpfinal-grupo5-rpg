using System;
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
    public partial class telaRaça : Form
    {
        public telaRaça()
        {
            InitializeComponent();
        }

        private Raca racaSelecionada;

        private void btnHumano_Click(object sender, EventArgs e)
        {
            Image imagemHumano = Properties.Resources.humano;

            imgRacaPersonagem.Image = imagemHumano;
            racaSelecionada = RacasProntas.Humano();
        }

        private void btnElfo_Click(object sender, EventArgs e)
        {
            Image imagemElfo = Properties.Resources.elfo;

            imgRacaPersonagem.Image = imagemElfo;
            racaSelecionada = RacasProntas.Elfo();
        }

        private void btnAnao_Click(object sender, EventArgs e)
        {
            Image imagemAnao = Properties.Resources.anao;

            imgRacaPersonagem.Image = imagemAnao;
            racaSelecionada = RacasProntas.Anao();
        }

        private void btnOrc_Click(object sender, EventArgs e)
        {
            Image imagemOrc = Properties.Resources.orc;

            imgRacaPersonagem.Image = imagemOrc;
            racaSelecionada = RacasProntas.Orc();
        }

        private void btnGnomo_Click(object sender, EventArgs e)
        {
            Image imagemGnomo = Properties.Resources.gnomo;

            imgRacaPersonagem.Image = imagemGnomo;
            racaSelecionada = RacasProntas.Gnomo();
        }

        private void btnProsseguir_Click(object sender, EventArgs e)
        {
            telaClasse formsClasse = new telaClasse(racaSelecionada);
            formsClasse.Show();
            this.Hide();
        }
    }
}
