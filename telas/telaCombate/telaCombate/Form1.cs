using System.Windows.Forms;

namespace telaCombate
{
    public partial class Form1 : Form
    {
        private string cenarioAtual = "vila02.jpg";
        public Form1()
        {
            InitializeComponent();
        }
        private void AtualizarCenario()
        {
            switch (cenarioAtual)
            {
                case "vila02.jpg":
                    pictureBox1.BackgroundImage = Properties.Resources.vila02;
                    break;
                case "florestaNoite.jpg":
                    pictureBox1.BackgroundImage = Properties.Resources.florestaChuva;
                    break;
                case "calabouco.jpg":
                    pictureBox1.BackgroundImage = Properties.Resources.calabouco;
                    break;
                case "caverna.jpg":
                    pictureBox1.BackgroundImage = Properties.Resources.caverna;
                    break;
                case "cidadeDestruida.jpg":
                    pictureBox1.BackgroundImage = Properties.Resources.cidadeDestruida;
                    break;
                case "floresta.jpg":
                    pictureBox1.BackgroundImage = Properties.Resources.floresta;
                    break;
                case "florestaChuva.jpg":
                    pictureBox1.BackgroundImage = Properties.Resources.florestaChuva;
                    break;
                case "inferno.jpg":
                    pictureBox1.BackgroundImage = Properties.Resources.inferno;
                    break;
                case "masmorra.jpg":
                    pictureBox1.BackgroundImage = Properties.Resources.masmorra;
                    break;
                case "pocoDia.jpg":
                    pictureBox1.BackgroundImage = Properties.Resources.pocoDia;
                    break;
                case "pocoNoite.jpg":
                    pictureBox1.BackgroundImage = Properties.Resources.pocoNoite;
                    break;
                case "quarto.jpg":
                    pictureBox1.BackgroundImage = Properties.Resources.quarto;
                    break;
                case "vila01.jpg":
                    pictureBox1.BackgroundImage = Properties.Resources.vila01;
                    break;
                case "vils03.jpg":
                    pictureBox1.BackgroundImage = Properties.Resources.vils03;
                    break;

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}