public class Ataque{
    private string nome;
    private int dano;
    private int gastoDeMana;
    private int chanceDeAcerto;

    public Ataque(){
        this.Nome = "";
        this.Dano = 0;
        this.GastoDeMana = 0;
        this.ChanceDeAcerto = 0;
    }
    public Ataque(string nome, int dano, int gastoDeMana, int chanceDeAcerto){
        this.Nome = nome;
        this.Dano = dano;
        this.GastoDeMana = gastoDeMana;
        this.ChanceDeAcerto = chanceDeAcerto;
    }

    public string Nome { get => nome; set => nome = value; }
    public int Dano { get => dano; set => dano = value; }
    public int GastoDeMana { get => gastoDeMana; set => gastoDeMana = value; }
    public int ChanceDeAcerto { get => chanceDeAcerto; set => chanceDeAcerto = value; }
}