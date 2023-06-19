public class Raca{
    private string nome;
    private string descricao;
    private int modVida;
    private int modMana;
    private int modAtaque;
    private int modDefesa;
    private int modSorte;
    private int modDinheiro;
    private Ataque Ataque;

    public Raca(){
        this.Nome = "";
        this.modVida = 0;
        this.modMana = 0;
        this.modAtaque = 0;
        this.modDefesa = 0;
        this.modSorte = 0;
        this.modDinheiro = 0;
        this.Ataque = null;
        this.Descricao = "";
    }
    public Raca(string nome, int modvida, int modmana, int modataque, int moddefesa, int modsorte, int moddinheiro, Ataque Ataque, string descricao){
        this.Nome = nome;
        this.modVida = modvida;
        this.modMana = modmana;
        this.modAtaque = modataque;
        this.modDefesa = moddefesa;
        this.modSorte = modsorte;
        this.modDinheiro = moddinheiro;
        this.Ataque = Ataque;
        this.Descricao = descricao;
    }

    public string Nome { get => nome; set => nome = value; }
    public string Descricao { get => descricao; set => descricao = value; }
    public int ModVida { get => modVida; set => modVida = value; }
    public int ModMana { get => modMana; set => modMana = value; }
    public int ModAtaque { get => modAtaque; set => modAtaque = value; }
    public int ModDefesa { get => modDefesa; set => modDefesa = value; }
    public int ModSorte { get => modSorte; set => modSorte = value; }
    public int ModDinheiro { get => modDinheiro; set => modDinheiro = value; }
    public Ataque Ataque1 { get => Ataque; set => Ataque = value; }
}