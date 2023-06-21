public static class AtaquesProntos{
    public static Ataque[] geraAtaques(){
        Ataque basico = new Ataque("Básico", 0, 0, 100);
        Ataque corajoso = new Ataque("Corajoso", 5, 10, 100);
        Ataque chamadoDivino = new Ataque("Chamado Divino", 10, 20, 100);
        Ataque cabecada = new Ataque("Cabeçada", 5, 5, 100);
        Ataque dilacerar = new Ataque("Dilacerar", 20, 30, 100);
        Ataque engenhoso = new Ataque("Engenhoso", 10, 20, 100);
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