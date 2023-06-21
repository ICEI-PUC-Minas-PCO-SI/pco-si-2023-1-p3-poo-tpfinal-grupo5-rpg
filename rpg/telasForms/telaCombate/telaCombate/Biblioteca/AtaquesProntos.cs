public static class AtaquesProntos{
    public static Ataque[] geraAtaques(){
        Ataque basico = new Ataque("Básico", 0, 0, 100);
        Ataque corajoso = new Ataque("Corajoso", 5, 10, 100);
        Ataque chamadoDivino = new Ataque("Chamado Divino", 10, 20, 100);
        Ataque cabecada = new Ataque("Cabeçada", 5, 5, 100);
        Ataque dilacerar = new Ataque("Dilacerar", 20, 30, 100);
        Ataque engenhoso = new Ataque("Engenhoso", 10, 20, 100);

        Ataque golpeFurioso = new Ataque("Golpe Furioso", 40, 15, 100);
        Ataque curaDivina = new Ataque("Cura Divina", 40, 10, 100);
        Ataque ataqueSorrateiro = new Ataque("Ataque Sorrateiro", 37, 8, 100);
        Ataque escudoDeProtecao = new Ataque("Escudo de Proteção", 45, 15, 100);
        Ataque chuvaDeFlechas = new Ataque("Chuva de Flechas", 40, 15, 100);


        return new Ataque[]{basico, corajoso, chamadoDivino, cabecada, dilacerar, engenhoso, golpeFurioso, curaDivina, ataqueSorrateiro, escudoDeProtecao, chuvaDeFlechas};
    }

    public static Ataque GolpeFurioso()
    {
        return geraAtaques()[6];
    }
    public static Ataque CuraDivina()
    {
        return geraAtaques()[7];
    }
    public static Ataque AtaqueSorrateiro()
    {
        return geraAtaques()[8];
    }
    public static Ataque EscudoDeProtecao()
    {
        return geraAtaques()[9];
    }
    public static Ataque ChuvaDeFlechas()
    {
        return geraAtaques()[10];
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