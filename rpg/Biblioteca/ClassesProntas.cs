public static class ClassesProntas{
    public static Classe[] geraClasses(){
        Classe[] classes = new Classe[5];
        Classe guerreiro = new Classe("Guerreiro", 5, 7, 5, 5, 0, 5,ArmasProntas.EspadaLonga(), "O guerreiro é um combatente habilidoso que se destaca no combate corpo a corpo. Ele possui grande força e resistência, além de ser especialista no uso de armas e armaduras pesadas.");
        Classe arqueiro = new Classe("Arqueiro", -5, 0, 7, 0, 15, 5, ArmasProntas.ArcoCurto(), "O arqueiro é um especialista em ataques à distância com arco e flecha. Ele possui grande precisão e habilidades de tiro, podendo atacar inimigos de longe com eficiência. O arqueiro é geralmente versátil, capaz de lidar com uma ampla variedade de situações de combate.");
        Classe ladino = new Classe("Ladino", -8, 7, 10, 0, 8, 10, ArmasProntas.Adaga(), "O ladino é um especialista em habilidades furtivas, trapaças e ataques sorrateiros. Ele é ágil, rápido e possui uma grande variedade de habilidades de desativação de armadilhas, furtividade, roubo e ataques críticos. O ladino é conhecido por sua capacidade de causar dano maciço em um único golpe.");
        Classe clerigo = new Classe("Clerigo", 0, 10, -9, 8, 8, 10, ArmasProntas.Cajado(), "O clérigo é um servo divino, com habilidades de cura e apoio ao grupo. Ele possui poderes sagrados e é capaz de curar ferimentos, remover maldições e proteger os aliados contra efeitos negativos. Além disso, o clérigo pode realizar ataques sagrados contra inimigos mortos-vivos ou malignos.");
        Classe tanque = new Classe("Tanque", 14, -5, 0, 13, 0, 5, ArmadurasProntas.Escudo(), "Os tanques geralmente possuem uma grande quantidade de pontos de vida e defesa, permitindo que resistam a ataques inimigos por mais tempo. Eles são especialistas no uso de armaduras pesadas e escudos, o que aumenta ainda mais sua capacidade defensiva. Além disso, podem ter habilidades para bloquear ou mitigar danos, tornando-se verdadeiras fortalezas no campo de batalha.");
        return new Classe[]{guerreiro, arqueiro, ladino, clerigo, tanque};
    }

    public static Classe Guerreiro(){
        return geraClasses()[0];
    }
    public static Classe Arqueiro(){
        return geraClasses()[1];
    }
    public static Classe Ladino(){
        return geraClasses()[2];
    }
    public static Classe Clerigo(){
        return geraClasses()[3];
    }
    public static Classe Tanque(){
        return geraClasses()[4];
    }
 
}