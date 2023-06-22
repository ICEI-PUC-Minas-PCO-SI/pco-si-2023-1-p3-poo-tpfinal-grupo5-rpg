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
            btnComprarItem.Visible = true;
            pictureBox3.Visible = true;
            moedasPersonagem.Visible = true;
            nomeNPC.Text = "Mercador";
            label1.Visible=true;
            inventarioPersonagem.Visible=true;

            string imgMercador = "npcVendedor";
            if (Properties.Resources.ResourceManager.GetObject(imgMercador) is Image imagemNovoNPC)
            {
                imgNpc.Image = imagemNovoNPC;
            }

            itensVenda.Visible = true;
            List<Consumivel> itensDisponiveis = ConsumiveisProntos.geraItens().ToList();
            itensVenda.DataSource = itensDisponiveis;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void moedasPersonagem_Click(object sender, EventArgs e)
        {

        }

        private void btnComprarItem_Click(object sender, EventArgs e)
        {
            
            if (itensVenda.SelectedRows.Count > 0)
            {
                
                Consumivel itemSelecionado = itensVenda.SelectedRows[0].DataBoundItem as Consumivel;

                // Verificar se o personagem tem dinheiro suficiente para comprar o item
                if (Personagem.Dinheiro >= itemSelecionado.Preco)
                {
                    
                    Personagem.comprar(itemSelecionado);

                    moedasPersonagem.Text = Personagem.Dinheiro.ToString();

                    //// Remover o item da lista de itens disponíveis
                    //itensVenda.Rows.Remove(itensVenda.SelectedRows[0]);

                    inventarioPersonagem.DataSource = null;
                    inventarioPersonagem.DataSource = Personagem.Inventario;
                }
                else
                {
                    MessageBox.Show("Você não tem dinheiro suficiente para comprar este item!");
                }
            }

            else
            {
                MessageBox.Show("Selecione um item para comprar!");
            }
        }

        private void btnFloresta_Click(object sender, EventArgs e)
        {
            imgPersonagem.Image = null;
            imgNpc.Image = null;

            btnComprarItem.Visible = false;
            pictureBox3.Visible = false;
            moedasPersonagem.Visible = false;
            nomeNPC.Text = "";
            label1.Visible = false;
            inventarioPersonagem.Visible = false;

            imgPersonagem.Image = null;
            imgNpc.Image = null;
            Jogavel personagem = new Jogavel(nome, classeSelecionada, racaSelecionada);
            telaFloresta formsFloresta = new telaFloresta(racaSelecionada, classeSelecionada, nome);
            formsFloresta.Personagem= personagem;   
            formsFloresta.Show();
            this.Hide();

        }

        private void btnCaverna_Click(object sender, EventArgs e)
        {
            imgPersonagem.Image = null;
            imgNpc.Image = null;
            Jogavel personagem = new Jogavel(nome, classeSelecionada, racaSelecionada);
            telaCaverna formcaverna = new telaCaverna(racaSelecionada, classeSelecionada, nome);
            formcaverna.Personagem= personagem;
            formcaverna.Show();
            this.Hide();


        }

        private void btnHistoria_Click(object sender, EventArgs e)
        {
            imgPersonagem.Image = null;
            imgNpc.Image = null;
            Jogavel personagem = new Jogavel(nome, classeSelecionada, racaSelecionada);
            telaMissao formmissao = new telaMissao(racaSelecionada, classeSelecionada, nome);
            formmissao.Personagem=personagem;
            formmissao.Show();
            this.Hide();
        }
    }
}
