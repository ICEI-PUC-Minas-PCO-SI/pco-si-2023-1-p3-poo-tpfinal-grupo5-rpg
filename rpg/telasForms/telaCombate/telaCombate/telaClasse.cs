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
    public partial class telaClasse : Form
    {
        private Raca racaSelecionada;
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
        private Image GetImageFromRaca(Raca racaSelecionada)
        {
            Image imagemRaca = null;

            if (racaSelecionada == RacasProntas.Humano())
            {
                imagemRaca = Properties.Resources.humano;
                imgClassePersonagem.Image = imagemRaca;
            }
            else if (racaSelecionada == RacasProntas.Elfo())
            {
                imagemRaca = Properties.Resources.elfo;
                imgClassePersonagem.Image = imagemRaca;
            }
            else if (racaSelecionada == RacasProntas.Anao())
            {
                imagemRaca = Properties.Resources.anao;
                imgClassePersonagem.Image = imagemRaca;
            }
            else if (racaSelecionada == RacasProntas.Orc())
            {
                imagemRaca = Properties.Resources.orc;
                imgClassePersonagem.Image = imagemRaca;
            }
            else if (racaSelecionada == RacasProntas.Gnomo())
            {
                imagemRaca = Properties.Resources.gnomo;
                imgClassePersonagem.Image = imagemRaca;
            }

            return imagemRaca;
        }


        private void btnGuerreiro_Click(object sender, EventArgs e)
        {
            //imgClassePersonagem.Image = ;
            classeSelecionada = ClassesProntas.Guerreiro();
        }
    }
}
