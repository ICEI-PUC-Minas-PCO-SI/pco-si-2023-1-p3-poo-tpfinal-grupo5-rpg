sealed class NPCVendedor : NPC, ITransacao
{
    // Construtores
    public NPCVendedor()
    {

    }
    public NPCVendedor(List<Item> inventario) : base(inventario)
    {

    }

    // M�todos
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
        return "Ol�, como posso ajudar?";
    }
}