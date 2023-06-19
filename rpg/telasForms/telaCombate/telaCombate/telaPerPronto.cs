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
    public partial class telaPerPronto : Form
    {
        private Raca racaSelecionada;
        private Classe classeSelecionada;
        private string nome;
        public telaPerPronto(Raca racaSelecionada, Classe classeSelecionada)
        {
            InitializeComponent();
            this.racaSelecionada = racaSelecionada;
            this.classeSelecionada = classeSelecionada;
            
        }

        private void telaPerPronto_Load(object sender, EventArgs e)
        {
            racaPersonagem.Text = racaSelecionada.Nome;
            classePersonagem.Text = classeSelecionada.Nome;
            descricaoRaca.Text = racaSelecionada.Descricao;
            descricaoClasse.Text = classeSelecionada.Descricao;

            string nomeImagem = $"{racaSelecionada.Nome.ToLower()}_{classeSelecionada.Nome.ToLower()}";

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
            nome = nomePersonagem.Text;
        }
    }
}
