public class Classe{
    private string nome;
    private string descricao;
    private int modVida;
    private int modMana;
    private int modAtaque;
    private int modDefesa;
    private int modSorte;
    private int modDinheiro;
    private Item item;

    public Classe(){
        this.Nome = "";
        this.ModVida = 0;
        this.ModMana = 0;
        this.ModAtaque = 0;
        this.ModDefesa = 0;
        this.ModSorte = 0;
        this.ModDinheiro = 0;
        this.Item = null;
        this.Descricao = "";
    }
    public Classe(string nome, int modvida, int modmana, int modataque, int moddefesa, int modsorte, int moddinheiro, Item item, string descricao){
        this.nome = nome;
        this.modVida = modvida;
        this.modMana = modmana;
        this.modAtaque = modataque;
        this.modDefesa = moddefesa;
        this.modSorte = modsorte;
        this.modDinheiro = moddinheiro;
        this.Item = item;
        this.descricao = descricao;
    }

    public string Nome { get => nome; set => nome = value; }
    public string Descricao { get => descricao; set => descricao = value; }
    public int ModVida { get => modVida; set => modVida = value; }
    public int ModMana { get => modMana; set => modMana = value; }
    public int ModAtaque { get => modAtaque; set => modAtaque = value; }
    public int ModDefesa { get => modDefesa; set => modDefesa = value; }
    public int ModSorte { get => modSorte; set => modSorte = value; }
    public int ModDinheiro { get => modDinheiro; set => modDinheiro = value; }
    public Item Item { get => item; set => item = value; }
}