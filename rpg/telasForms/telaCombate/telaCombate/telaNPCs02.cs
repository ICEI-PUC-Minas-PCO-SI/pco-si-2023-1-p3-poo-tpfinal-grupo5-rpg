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
    public partial class telaNPCs02 : Form
    {
        public Jogavel Personagem { get; set; }
        private Raca racaSelecionada;
        private Classe classeSelecionada;
        protected string nome;
        public telaNPCs02(Raca racaSelecionada, Classe classeSelecionada, string nome)
        {
            this.racaSelecionada = racaSelecionada;
            this.classeSelecionada = classeSelecionada;
            this.nome = nome;
            InitializeComponent();
            
        }
        private string RemoverAcentos(string texto)
        {
            string textoNormalizado = texto.Normalize(NormalizationForm.FormD);
            var regex = new Regex("\\p{IsCombiningDiacriticalMarks}+");
            string textoSemAcentos = regex.Replace(textoNormalizado, string.Empty);
            return textoSemAcentos;
        }
        private void telaNPCs02_Load(object sender, EventArgs e)
        {

        }
    }
}
