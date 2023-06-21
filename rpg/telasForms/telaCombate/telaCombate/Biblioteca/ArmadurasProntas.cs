public static class ArmadurasProntas{
    public static Armadura[] geraArmadura(){
        Armadura escudo = new Armadura("Escudo", 10, 1, 1, "defesa", 3);

        Armadura couraca = new Armadura("Couraça", 15, 1, 1, "defesa", 5);

        Armadura cotaDeMalha = new Armadura("Cota de Malha", 20, 1, 1, "defesa", 8);

        return new Armadura[]{escudo, couraca, cotaDeMalha};
    }
    public static Armadura Escudo(){
        return geraArmadura()[0];
    }
    public static Armadura Couraca(){
        return geraArmadura()[1];
    }
    public static Armadura CotaDeMalha(){
        return geraArmadura()[2];
    }
}