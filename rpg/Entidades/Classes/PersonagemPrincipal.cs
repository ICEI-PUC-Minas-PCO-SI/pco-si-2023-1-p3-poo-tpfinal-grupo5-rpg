abstract class PersonagemPrincipal : Pessoa, ITransacao, IAtaqueEspecial, IAtaqueIntermediario
{
    protected List<Item> inventario;

    // Construtores
    public PersonagemPrincipal()
    {

    }
    public PersonagemPrincipal(List<Item> inventario) : base()
    {
        this.inventario = inventario;
    }

    // Métodos
    protected List<Item> mostrarInventario()
    {

    }
    public void comprar(int valorItem)
    {

    }
    public Item vender(int valorItem, int posItem)
    {

    }
    public Item trocar(Item item, int posItem)
    {

    }
    public void ataqueEspecial(int nivel, double forca)
    {

    }
    public void ataqueIntermediario(int nivel, double forca)
    {

    }
}