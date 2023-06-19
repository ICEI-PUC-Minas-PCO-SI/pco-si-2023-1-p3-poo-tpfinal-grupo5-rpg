using Microsoft.VisualBasic.Devices;

namespace telaCombate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void btnAtaqBase_Click(object sender, EventArgs e)
        {
            Ataque basico = new Ataque("Básico", 5, 0, 90);
            lblInformacoes.Text = $"Dano: {basico.Dano}, Gasto de Mana: {basico.GastoDeMana}, Índice de Acerto: {basico.ChanceDeAcerto}%";
        }
        private void btnAtaqMedio_Click(object sender, EventArgs e)
        {
            //string classe = Pessoa.Classe.Nome;

            Ataque medio;
            switch (classe)
            {
                    case "Anao":
                        medio = new Ataque("Cabeçada", 10, 5, 80);
                        break;

                    case "Guerreiro":
                        medio = new Ataque("Corajoso", 15, 10, 70);
                        break;

                    case "Ladino":
                        medio = new Ataque("Dilacerar", 12, 8, 75);
                        break;

                    case "Tanque":
                        medio = new Ataque("Engenhoso", 8, 3, 90);
                        break;

                    case "Clerigo":
                        medio = new Ataque("Chamado Divino", 20, 15, 60);
                        break;

                    default:
                        medio = new Ataque("Ataque Médio", 0, 0, 0);
                        break;
                }


                lblInformacoes.Text = $"Dano: {medio.Dano}, Gasto de Mana: {medio.GastoDeMana}, Índice de Acerto: {medio.ChanceDeAcerto}%";
            }

        }
    }