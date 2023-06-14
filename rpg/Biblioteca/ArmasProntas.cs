public static class ArmasProntas{
    public static Arma[] geradArma(){
        Arma espadaLonga = new Arma("Espada Longa", 10, 1, 1, "ataque", 3);

        Arma arcoCurto = new Arma("Arco Curto", 10, 1, 1, "ataque", 3);

        Arma adaga = new Arma("Adaga", 10, 1, 1, "ataque", 3);

        Arma cajado = new Arma("Cajado", 10, 1, 1, "vida", 3);

        return new Arma[]{espadaLonga, arcoCurto, adaga, cajado};
    }

    public static Arma EspadaLonga(){
        return geradArma()[0];
    }
    public static Arma ArcoCurto(){
        return geradArma()[1];
    }
    public static Arma Adaga(){
        return geradArma()[2];
    }
    public static Arma Cajado(){
        return geradArma()[3];
    }
}