public static class AnimaisProntos{
    public static Animal[] geraAnimais(){

        Animal javali = new Animal("Javali", 50, 5, 5, 6);

        Animal lobo = new Animal("Lobo", 75, 7, 10, 8);

        return new Animal[]{javali, lobo};
    }

    public static Animal Javali(){
        return geraAnimais()[0];
    }
    public static Animal Lobo(){
        return geraAnimais()[1];
    }
}