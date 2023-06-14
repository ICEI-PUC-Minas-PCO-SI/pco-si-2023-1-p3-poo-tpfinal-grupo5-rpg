public static class ArmadurasProntas{
    public static Armadura[] geraArmadura(){
        Armadura escudo = new Armadura("Escudo", 10, 1, 1, "defesa", 3);

        return new Armadura[]{escudo};
    }
    public static Armadura Escudo(){
        return geraArmadura()[0];
    }
}