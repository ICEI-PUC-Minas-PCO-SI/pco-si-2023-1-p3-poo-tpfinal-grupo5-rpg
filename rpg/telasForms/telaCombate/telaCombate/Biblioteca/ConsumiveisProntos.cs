public static class ConsumiveisProntos{
    public static Consumivel[] geraItens(){

        Consumivel pocaoVidaP = new Consumivel("Poção de Vida Pequena", 2, 1, 1, "vida", 20);

        Consumivel pocaoVidaM = new Consumivel("Poção de Vida Media", 8, 1, 1, "vida", 50);

        Consumivel pocaoVidaG = new Consumivel("Poção de Vida Grande", 15, 1, 1, "vida", 100);
        //////////////////
        Consumivel pocaoManaP = new Consumivel("Poção de Mana Pequena", 5, 1, 1, "mana", 20);

        Consumivel pocaoManaM = new Consumivel("Poção de Mana Media", 10, 1, 1, "mana", 50);

        Consumivel pocaoManaG = new Consumivel("Poção de Mana Grande", 20, 1, 1, "mana", 100);

        return new Consumivel[]{pocaoVidaP, pocaoVidaM, pocaoVidaG, pocaoManaP, pocaoManaM, pocaoManaG};
    }

    public static Consumivel PocaoVidaP(){
        return geraItens()[0];
    }
    public static Consumivel PocaoVidaM(){
        return geraItens()[1];
    }
    public static Consumivel PocaoVidaG(){
        return geraItens()[2];
    }
    public static Consumivel PocaoManaP(){
        return geraItens()[3];
    }
    public static Consumivel PocaoManaM(){
        return geraItens()[4];
    }
    public static Consumivel PocaoManaG(){
        return geraItens()[5];
    }
}