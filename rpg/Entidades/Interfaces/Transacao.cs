interface ITransacao
{
    List<Item> mostrarInventario();
    void comprar(int valorItem); // valor do item a ser descontado nas moedas do jogador
    // jogador.moeda -= valorItem;
    Item vender(int valorItem, int posItem); // valor e posição do item no inventário
    // npc.moeda += valorItem;
    // Item itemVendido = npc.inventario[posItem];
    // inventario.RemoveAt(posItem);
    // return itemVendido;
    Item trocar(Item item, int posItem); // recebe um item e retorna o item da posição posItem
    // jogador.inventario.remove(item);
    // npc.inventario.Add(item);
    // Item itemTrocado = inventario[posItem];
    // inventario.RemoveAt(posItem);
    // return itemTrocado;
}