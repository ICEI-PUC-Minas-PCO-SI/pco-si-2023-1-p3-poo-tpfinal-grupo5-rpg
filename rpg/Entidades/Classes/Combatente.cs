abstract class Combatente : Personagem, IDropar
{
    private Double forca { get; set; }
    private Double defesa { get; set; }
    private int vida { get; set; }
    private int nivel { get; set; }

    // Construtores
    public Combatente()
    {

    }
    public Combatente(String nome, int moeda, Double forca, Double defesa, int vida, int nivel) : base(nome, moeda)
    {
        this.forca = forca;
        this.defesa = defesa;
        this.vida = vida;
        this.nivel = nivel;
    }

    // Métodos
    protected virtual void atacar()
    {
        
    }
    protected virtual void defender()
    {

    }
    public int droparMoeda()
    {
        return 10;
    } 
    public int droaparXp()
    {
        return 10;
    }
}