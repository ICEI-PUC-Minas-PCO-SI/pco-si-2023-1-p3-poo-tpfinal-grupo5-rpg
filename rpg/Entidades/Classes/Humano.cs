sealed class Humano : PersonagemPrincipal
{
    // Construtores
    public Humano()
    {

    }
    public Humano(List<Item> inventario) : base(inventario)
    {

    }

    // M�todos
    protected override string exibeMensagem()
    {
        return "";
    }
    protected override void atacar()
    {

    }
    protected override void defender()
    {

    }
}