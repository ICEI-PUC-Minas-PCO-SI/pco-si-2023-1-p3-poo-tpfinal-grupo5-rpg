namespace tela_personagem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonGuerreiro_MouseEnter(object sender, EventArgs e)
        {
            try
            {
                picturePersonagem.Image = Image.FromFile(@"humanoGuerreiro.png");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            labelClasse.Text = "Guerreiro";
        }

        private void buttonGuerreiro_MouseLeave(object sender, EventArgs e)
        {
            try
            {
                picturePersonagem.Image = Image.FromFile(@"inicial.jpeg");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            labelClasse.Text = "";
        }

        private void buttonArqueiro_MouseEnter(object sender, EventArgs e)
        {
            try
            {
                picturePersonagem.Image = Image.FromFile(@"arqueiro.jpeg");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            labelClasse.Text = "Arqueiro";
        }

        private void buttonArqueiro_MouseLeave(object sender, EventArgs e)
        {
            labelClasse.Text = "";
        }
        private void buttonClerigo_MouseEnter(object sender, EventArgs e)
        {
            try
            {
                picturePersonagem.Image = Image.FromFile(@"clerigo.jpeg");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            labelClasse.Text = "Clerigo";
        }

        private void buttonLadino_MouseEnter(object sender, EventArgs e)
        {
            try
            {
                picturePersonagem.Image = Image.FromFile(@"ladino.jpeg");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            labelClasse.Text = "Ladino";
        }

        private void buttonTanque_MouseEnter(object sender, EventArgs e)
        {
            try
            {
                picturePersonagem.Image = Image.FromFile(@"tanque.jpeg");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            labelClasse.Text = "Tanque";
        }
    }
}