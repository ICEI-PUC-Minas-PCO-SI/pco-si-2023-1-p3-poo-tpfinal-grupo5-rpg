public class Ataque{
    private string nome;
    private int dano;
    private int gastoDemana;
    private int chanceDeAcerto;

    public Ataque(){
        this.Nome = "";
        this.Dano = 0;
        this.GastoDemana = 0;
        this.ChanceDeAcerto = 0;
    }
    public Ataque(string nome, int dano, int gastoDemana, int chanceDeAcerto){
        this.Nome = nome;
        this.Dano = dano;
        this.GastoDemana = gastoDemana;
        this.ChanceDeAcerto = chanceDeAcerto;
    }

    public string Nome { get => nome; set => nome = value; }
    public int Dano { get => dano; set => dano = value; }
    public int GastoDemana { get => gastoDemana; set => gastoDemana = value; }
    public int ChanceDeAcerto { get => chanceDeAcerto; set => chanceDeAcerto = value; }
}