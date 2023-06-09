public static class RacasProntas{
    public static Raca[] geraRaca(){
        Raca[] Raca = new Raca[5];
        Raca humano = new Raca("Humano", 5, 5, 5, 0, 20, 5,AtaquesProntos.Corajoso(), "Os humanos são a raça mais comum e versátil. Eles geralmente têm habilidades equilibradas e não possuem vantagens ou desvantagens específicas.");
        Raca elfo = new Raca("Elfo", -10, 7, 5, -5, 25, 5, AtaquesProntos.ChamadoDivino(), "Os elfos são uma raça conhecida por sua graça, longevidade e conexão com a natureza. Eles são ágeis, possuem uma afinidade natural com a magia e geralmente têm sentidos aguçados");
        Raca anao = new Raca("Anão", 10, 5, 5, 0, 10, 5, AtaquesProntos.Cabecada(), "Os anões são conhecidos por sua força, resistência e habilidades em trabalhar com metais e pedras. Eles são geralmente mais baixos em estatura, mas são especialistas em combate corpo a corpo e possuem uma grande resistência a danos.");
        Raca orc = new Raca("Orc", 20, 3, 10, 0, 10, 5, AtaquesProntos.Dilacerar(), "Os orcs são uma raça forte e robusta, muitas vezes retratada como ferozes guerreiros e caçadores. Eles possuem uma constituição física poderosa e são conhecidos por sua habilidade em combate e resistência.");
        Raca gnomo = new Raca("Gnomo", -5, 20, 5, -3, 25, 15, AtaquesProntos.Engenhoso(), "Os gnomos são uma raça pequena, muitas vezes retratada como inventores e estudiosos. Eles são conhecidos por sua inteligência, habilidades em engenharia e magia ilusória.");
        return new Raca[]{humano, elfo, anao, orc, gnomo};
    }

    public static Raca Humano(){
        return geraRaca()[0];
    }
    public static Raca Elfo(){
        return geraRaca()[1];
    }
    public static Raca Anao(){
        return geraRaca()[2];
    }
    public static Raca Orc(){
        return geraRaca()[3];
    }
    public static Raca Gnomo(){
        return geraRaca()[4];
    }
}