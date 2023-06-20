public static class AnimaisProntos{
    public static Animal[] geraAnimais(){

        Animal javali = new Animal("Javali", 51, Dado.RandomNumber(3, 6), Dado.RandomNumber(1, 3), 12);

        Animal lobo = new Animal("Lobo", 75, Dado.RandomNumber(4, 7), Dado.RandomNumber(2, 4), 17);

        return new Animal[]{javali, lobo};
    }

    public static Animal Javali(){
        return geraAnimais()[0];
    }
    public static Animal Lobo(){
        return geraAnimais()[1];
    }
}