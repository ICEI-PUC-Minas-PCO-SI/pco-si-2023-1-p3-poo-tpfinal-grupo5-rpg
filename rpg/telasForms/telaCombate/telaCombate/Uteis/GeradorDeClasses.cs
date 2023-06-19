public static class GeradorDeClasses{
    public static Classe GerarClasse(){
        int num = Dado.RandomNumber(1, 5);
        switch(num){
            case 1:
                return ClassesProntas.Guerreiro();
            case 2:
                return ClassesProntas.Arqueiro();
            case 3:
                return ClassesProntas.Ladino();
            case 4:
                return ClassesProntas.Clerigo();
            case 5:
                return ClassesProntas.Tanque();
            default:
                return ClassesProntas.Guerreiro();
        }
    }
}