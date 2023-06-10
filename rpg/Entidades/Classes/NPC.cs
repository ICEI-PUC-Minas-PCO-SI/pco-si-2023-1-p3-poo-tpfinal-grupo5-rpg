abstract class NPC : Personagem
{
    private List<Item> inventario { get; set; }

    // Construtores
    public NPC()
    {

    }
    public NPC(String nome, int moeda, List<Item> inventario) : base(nome, moeda)
    {
        this.inventario = inventario;
    }
}