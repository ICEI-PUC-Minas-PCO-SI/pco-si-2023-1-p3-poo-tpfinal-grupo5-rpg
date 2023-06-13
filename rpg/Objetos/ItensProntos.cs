public static class ItensProntos{
    public static Item[] geraItens(){
        Item espadaLonga = new Item("Espada Longa", 10, 1, 1);

        Item arcoCurto = new Item("Arco Curto", 10, 1, 1);

        Item adaga = new Item("Adaga", 10, 1, 1);

        Item cajado = new Item("Cajado", 10, 1, 1);

        Item escudo = new Item("Escudo", 10, 1, 1);

        return new Item[]{espadaLonga, arcoCurto, adaga, cajado, escudo};
    }

    public static Item EspadaLonga(){
        return geraItens()[0];
    }
    public static Item ArcoCurto(){
        return geraItens()[1];
    }
    public static Item Adaga(){
        return geraItens()[2];
    }
    public static Item Cajado(){
        return geraItens()[3];
    }
    public static Item Escudo(){
        return geraItens()[4];
    }
}