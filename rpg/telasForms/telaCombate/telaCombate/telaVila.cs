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
    public partial class telaVila : Form
    {
        public Jogavel Personagem { get; set; }
        private Raca racaSelecionada;
        private Classe classeSelecionada;
        protected string nome;
        private DataGridView dvItens;
        public telaVila(Raca racaSelecionada, Classe classeSelecionada, string nome)
        {
            InitializeComponent();
            this.racaSelecionada = racaSelecionada;
            this.classeSelecionada = classeSelecionada;
            this.nome = nome;
        }

        private void telaVila_Load(object sender, EventArgs e)
        {
            //dvItens = new DataGridView();
            //dvItens.Dock = DockStyle.Fill;
            //dvItens.AutoGenerateColumns = false;

            //dvItens.Columns.Add("colNome", "Nome");
            //dvItens.Columns.Add("colPreco", "Preço");
            //dvItens.Columns.Add("colQuantidade", "Quantidade");

            //List<Consumivel> itensDisponiveis = ConsumiveisProntos.geraItens().ToList();
            //dvItens.DataSource = itensDisponiveis;

            //Controls.Add(dvItens);

           

            //// Adicione as colunas do DataGridView
            //DataGridViewTextBoxColumn colNome = new DataGridViewTextBoxColumn();
            //colNome.DataPropertyName = "Nome";
            //dvItens.Columns.Add(colNome);

            //DataGridViewTextBoxColumn colPreco = new DataGridViewTextBoxColumn();
            //colPreco.DataPropertyName = "Preco";
            //dvItens.Columns.Add(colPreco);

            //DataGridViewTextBoxColumn colQuantidade = new DataGridViewTextBoxColumn();
            //colQuantidade.DataPropertyName = "Quantidade";
            //dvItens.Columns.Add(colQuantidade);

          

            nomeNPC.Text = "";
            string nomeImagem = $"{RemoverAcentos(racaSelecionada.Nome.ToLower())}_{RemoverAcentos(classeSelecionada.Nome.ToLower())}";

            if (Properties.Resources.ResourceManager.GetObject(nomeImagem) is Image imagem)
            {
                imgPersonagem.Image = imagem;
            }
        }

        private string RemoverAcentos(string texto)
        {
            string textoNormalizado = texto.Normalize(NormalizationForm.FormD);
            var regex = new Regex("\\p{IsCombiningDiacriticalMarks}+");
            string textoSemAcentos = regex.Replace(textoNormalizado, string.Empty);
            return textoSemAcentos;
        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            nomeNPC.Text = "Mercador";

            string imgMercador = "npcVendedor";
            if (Properties.Resources.ResourceManager.GetObject(imgMercador) is Image imagemNovoNPC)
            {
                imgNpc.Image = imagemNovoNPC;
            }

            itensVenda.Visible = true;
            List<Consumivel> itensDisponiveis = ConsumiveisProntos.geraItens().ToList();
            itensVenda.DataSource = itensDisponiveis;
        }
    }
}
