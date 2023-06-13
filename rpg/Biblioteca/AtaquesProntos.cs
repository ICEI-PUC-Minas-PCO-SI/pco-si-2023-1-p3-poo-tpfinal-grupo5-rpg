public static class AtaquesProntos{
    public static Ataque[] geraAtaques(){
        Ataque basico = new Ataque("Básico", 1, 5, 90);
        Ataque corajoso = new Ataque("Corajoso", 10, 10, 80);
        Ataque chamadoDivino = new Ataque("Chamado Divino", 10, 10, 80);
        Ataque cabecada = new Ataque("Cabeçada", 15, 10, 75);
        Ataque dilacerar = new Ataque("Dilacerar", 20, 10, 70);
        Ataque engenhoso = new Ataque("Engenhoso", 20, 20, 80);
        return new Ataque[]{basico, corajoso, chamadoDivino, cabecada, dilacerar, engenhoso};
    }

    public static Ataque Corajoso(){
        return geraAtaques()[1];
    }
    public static Ataque ChamadoDivino(){
        return geraAtaques()[2];
    }
    public static Ataque Cabecada(){
        return geraAtaques()[3];
    }
    public static Ataque Dilacerar(){
        return geraAtaques()[4];
    }
    public static Ataque Engenhoso(){
        return geraAtaques()[5];
    }
    public static Ataque Basico(){
        return geraAtaques()[0];
    }
}