using Microsoft.VisualBasic.Devices;
using System.Text.RegularExpressions;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;
using System.Drawing;
using System;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Threading;

namespace telaCombate
{
    public partial class Form1 : Form
    {
        private Animal javali;
        private Animal lobo;
        public Jogavel Personagem { get; set; }
        private Raca racaSelecionada;
        private Classe classeSelecionada;
        protected string nome;
        protected List<string> inventario = new List<string>();
        private Ataque ataqueEscolhido;
        private Arma armaPlayer;


        public int ManaAtual
        {
            get => Personagem.Mana;
        }

        public Form1(Raca racaSelecionada, Classe classeSelecionada, string nome)
        {
            InitializeComponent();
            this.racaSelecionada = racaSelecionada;
            this.classeSelecionada = classeSelecionada;
            this.nome = nome;
            
        }

        private string RemoverAcentos(string texto)
        {
            string textoNormalizado = texto.Normalize(NormalizationForm.FormD);
            var regex = new Regex("\\p{IsCombiningDiacriticalMarks}+");
            string textoSemAcentos = regex.Replace(textoNormalizado, string.Empty);
            return textoSemAcentos;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void btnAtaqBase_Click(object sender, EventArgs e)
        {
            ataqueEscolhido = AtaquesProntos.Basico();
            //lblInformacoes.Text = $"Dano: {ataqueEscolhido.Dano}, Gasto de Mana: {ataqueEscolhido.GastoDeMana}, �ndice de Acerto: {ataqueEscolhido.ChanceDeAcerto}%";
        }

        private Arma SelecionarArma()
        {
            if (classeSelecionada.Nome == "Guerreiro")
            {
                return armaPlayer = ArmasProntas.EspadaLonga();
               
            }
            else if (classeSelecionada.Nome == "Clerigo")
            {
                return armaPlayer = ArmasProntas.Cajado();
            }
            else if (classeSelecionada.Nome == "Ladino")
            {
                return armaPlayer = ArmasProntas.Adaga();
            }
            else if (classeSelecionada.Nome == "Tanque")
            {
                return armaPlayer = ArmasProntas.MarteloDeGuerra();
            }
            else if (classeSelecionada.Nome == "Arqueiro")
            {
                return armaPlayer = ArmasProntas.ArcoCurto();
            }
            else
            {
                return null;
            }
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

            //lblInformacoes.Text = $"Ataque: {ataqueEscolhido.Nome} Dano: {ataqueEscolhido.Dano}, Gasto de Mana: {ataqueEscolhido.GastoDeMana}, �ndice de Acerto: {ataqueEscolhido.ChanceDeAcerto}%";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            Animal[] animais = AnimaisProntos.geraAnimais();
            javali = animais[0];
            lobo = animais[1];

            //Infos inimigo
            nomeInimigo.Text = "";
            vidaInimigo.Text = javali.vida.ToString();

            //Infos personagem
            //nivelPersonagem.Text = Personagem.Nivel.ToString();
            moedasPersonagem.Text = Personagem.Dinheiro.ToString();
            vidaPersonagem.Text = Personagem.Vida.ToString();
            manaPersonagem.Text = Personagem.Mana.ToString();
            //Img personagem
            string nomeImagem = $"{RemoverAcentos(racaSelecionada.Nome.ToLower())}_{RemoverAcentos(classeSelecionada.Nome.ToLower())}";

            if (Properties.Resources.ResourceManager.GetObject(nomeImagem) is Image imagem)
            {
                playerImg.Image = imagem;
            }

            //Arma personagem
            armaPlayer = SelecionarArma();
            if (armaPlayer != null)
            {
                
                ListViewItem itemArma = new ListViewItem(armaPlayer.Nome);

                
                itemArma.SubItems.Add("1"); 
                

               
                listInventario.Items.Add(itemArma);
            }
            else
            {
                listInventario.Items.Clear(); 
                listInventario.Items.Add("Nenhuma arma selecionada");
            }
        }

        private void vidaPersonagem_Click(object sender, EventArgs e)
        {

        }

        private void btnBatalhar_Click(object sender, EventArgs e)
        {
            lblInformacoes.Text = "";
            Combate combate = new Combate(Personagem, javali);

            nomeInimigo.Text = combate.Inimigo.Nome.ToString();

            btnBatalhar.Text = "Executar ação";

            if (ataqueEscolhido == null)
            {
                MessageBox.Show("Vamos batalhar! Selecione um ataque.");
                return;
            }

            if (combate.Personagem.Mana < ataqueEscolhido.GastoDeMana)
            {

                MessageBox.Show("Mana insuficiente para usar esse ataque!");
                return;
            }
            else
            {

                int dano = combate.Personagem.atacar(ataqueEscolhido);
                combate.Inimigo.defender(dano);
                int danoInimigo = combate.Inimigo.atacar();
                combate.Personagem.defender(danoInimigo);
                lblInformacoes.Text += $"Você causou {dano} de dano. O inimigo causou {danoInimigo} de dano.";
                vidaPersonagem.Text = Personagem.Vida.ToString();
                manaPersonagem.Text = Personagem.Mana.ToString();
                vidaInimigo.Text = combate.Inimigo.vida.ToString();
            }



            //while (Personagem.Vida > 0 && javali.vida > 0)
            //{
            //    int danoPersonagem = combate.Personagem.atacar(ataqueEscolhido);
            //    //Personagem.defender(danoPersonagem);
            //    lblInformacoes.Text = $"Você causou {danoPersonagem} de dano.";

            //    if (javali.vida <= 0)
            //        break;

            //    System.Threading.Thread.Sleep(100);

            //    int danoInimigo = javali.atacar();
            //    int vidaAtual = (Personagem.Vida - danoInimigo); 
            //    vidaPersonagem.Text = vidaAtual.ToString();
            //    Personagem.defender(danoInimigo);
            //    lblInformacoes.Text += $" O inimigo causou {danoInimigo} de dano.";

            //    System.Threading.Thread.Sleep(100000);
            //}

            if (Personagem.Vida <= 0)
            {
                MessageBox.Show("Você foi derrotado pelo inimigo!");
                vidaPersonagem.Text = "0";
                manaPersonagem.Text = Personagem.Mana.ToString();
                vidaInimigo.Text = combate.Inimigo.vida.ToString();
                MessageBox.Show("FIM DE JOGO");
                this.Close();
            }
            else if (javali.vida <= 0)
            {
                vidaInimigo.Text = "0";
                int dinheiroDropado = javali.droparDinheiro();
                Personagem.ReceberDinheiro(dinheiroDropado);
                MessageBox.Show($"Você venceu a batalha contra o inimigo e recebeu {dinheiroDropado} moedas!");

                //Leva pra outra tela
                playerImg.Image = null;
                Jogavel personagem = new Jogavel(nome, classeSelecionada, racaSelecionada);
                telaNPCs02 formsNPC2 = new telaNPCs02(racaSelecionada, classeSelecionada, nome);
                formsNPC2.Personagem = personagem;
                this.Hide();
            }
        }

        private void btnUsarItem_Click(object sender, EventArgs e)
        {
            if (listInventario.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listInventario.SelectedItems[0];
                string nomeItem = selectedItem.SubItems[0].Text; // Obtém o nome do item selecionado

                // Verifique o tipo de item selecionado (arma, poção, etc.) e execute a ação apropriada
                if (nomeItem == "Arma") // Exemplo para uma arma
                {
                    // Realize a ação de consumir a arma aqui
                    // ...

                    // Remova o item consumido do inventário
                    listInventario.Items.Remove(selectedItem);
                }
                else if (nomeItem == "Poção") // Exemplo para uma poção
                {
                    // Realize a ação de consumir a poção aqui
                    // ...

                    // Reduza a quantidade da poção no inventário
                    int quantidade = int.Parse(selectedItem.SubItems[1].Text);
                    if (quantidade > 1)
                    {
                        quantidade--;
                        selectedItem.SubItems[1].Text = quantidade.ToString();
                    }
                    else
                    {
                        listInventario.Items.Remove(selectedItem);
                    }
                }
                else
                {
                    // O tipo de item selecionado não é suportado ou não possui uma ação específica
                    MessageBox.Show("Item selecionado não pode ser consumido.");
                }
            }
            else
            {
                MessageBox.Show("Nenhum item selecionado.");
            }
        }
    }
}
