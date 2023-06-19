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
            racaSelecionada = RacasProntas.Humano();
        }

        private void btnElfo_Click(object sender, EventArgs e)
        {
            racaSelecionada = RacasProntas.Elfo();
        }

        private void btnAnao_Click(object sender, EventArgs e)
        {
            racaSelecionada = RacasProntas.Anao();
        }

        private void btnOrc_Click(object sender, EventArgs e)
        {
            racaSelecionada = RacasProntas.Orc();
        }

        private void btnGnomo_Click(object sender, EventArgs e)
        {
            racaSelecionada = RacasProntas.Gnomo();
        }

        private void btnProsseguir_Click(object sender, EventArgs e)
        {
            telaClasse formsClasse = new telaClasse(racaSelecionada);
            formsClasse.Show();
            this.Hide();
        }

        private void telaRaça_Load(object sender, EventArgs e)
        {

        }
    }
}
