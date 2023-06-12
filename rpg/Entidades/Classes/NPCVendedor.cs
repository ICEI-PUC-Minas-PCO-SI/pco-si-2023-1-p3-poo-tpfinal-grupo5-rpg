sealed class NPCVendedor : NPC, ITransacao
{
    // Construtores
    public NPCVendedor()
    {

    }
    public NPCVendedor(List<Item> inventario) : base(inventario)
    {

    }

    // Métodos
    protected List<Item> mostrarInventario()
    {

    }
    protected void comprar(int valorItem)
    {

    }
    protected Item vender(int valorItem, int posItem)
    {

    }
    protected Item trocar(Item item, int posItem)
    {

    }
    protected override string exibeMensagem()
    {
        return "Olá, como posso ajudar?";
    }
}