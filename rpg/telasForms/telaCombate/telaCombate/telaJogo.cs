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
    public partial class telaJogo : Form
    {
        private List<string> historia;
        private int indiceAtual;
        private Raca racaSelecionada;
        private Classe classeSelecionada;
        protected string nome;
        public telaJogo(Raca racaSelecionada, Classe classeSelecionada, string nome)
        {
            InitializeComponent();
            InitializeHistoria();
            this.racaSelecionada = racaSelecionada;
            this.classeSelecionada = classeSelecionada;
            this.nome = nome;
            indiceAtual = 0;
        }
        private void telaJogo_Load(object sender, EventArgs e)
        {
            textoIntro.Text = $"{nome} é um jovem comum, que vive uma vida comum, com seus afazeres comuns, em uma pacata vila.";
        }
        private void InitializeHistoria()
        {
            historia = new List<string>
            {
                "Tudo estava como sempre foi, até que, alguns animais que habitavam o vilarejo começaram a apresentar uma mudança significativa de comportamento.",
                $"Aqueles que costumavam ser dóceis, agora estavam atacando os moradores. Ele começou a achar que havia algo de errado com aqueles acontecimentos, mas não deu muita atenção.",
                "Ele morava ali desde que nasceu, não tinha como aquela simples vila se transformar em um cenário de mistério.",
                "Porém, com o passar dos dias, algumas pessoas começaram a desaparecer, dando mais um impulso ao suspense que pairava no ar.",
                $"Ele começa a perceber também que o comportamento do ancião do vilarejo, o senhor Orion, estava muito alterado: O velho corria pra lá e pra cá, fazendo rituais e em estado de negação.",
                "Havia algo grande acontecendo.",
                " "
            };
        }

        private void btnProsseguir_Click(object sender, EventArgs e)
        {
            if (indiceAtual < historia.Count)
            {
                textoIntro.Text = historia[indiceAtual];
                indiceAtual++;
            }

            if (indiceAtual >= historia.Count)
            {
                btnProsseguir.Text = "Procurar pistas";
                telaNPCs formsNPCs = new telaNPCs(racaSelecionada, classeSelecionada, nome);
                formsNPCs.Show();
                this.Hide();

            }
        }
    }
}
