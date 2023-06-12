sealed class Item
{
    private String nomeItem { get; set; }
    private int valorItem { get; set; }
    private int nivelItem { get; set; }

    // Construtores
    public Item()
    {

    }
    public Item(String nomeItem, int valorItem, int nivelItem)
    {
        this.nomeItem = nomeItem;
        this.valorItem = valorItem;
        this.nivelItem = nivelItem;
    }

    // Métodos
    private T modificarAtributo<T>(T atributo)
    {
        return atributo;
    }
}