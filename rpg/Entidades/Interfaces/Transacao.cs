interface ITransacao
{
    List<Item> mostrarInventario();
    void comprar(int valorItem); // valor do item a ser descontado nas moedas do jogador
    // jogador.moeda -= valorItem;
    Item vender(int valorItem, int posItem); // valor e posi��o do item no invent�rio
    // npc.moeda += valorItem;
    // Item itemVendido = npc.inventario[posItem];
    // inventario.RemoveAt(posItem);
    // return itemVendido;
    Item trocar(Item item, int posItem); // recebe um item e retorna o item da posi��o posItem
    // jogador.inventario.remove(item);
    // npc.inventario.Add(item);
    // Item itemTrocado = inventario[posItem];
    // inventario.RemoveAt(posItem);
    // return itemTrocado;
}