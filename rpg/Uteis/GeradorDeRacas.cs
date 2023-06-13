public static class GeradorDeRacas{
    public static Raca GerarRaca(){
        int num = Dado.RandomNumber(1, 5);
        switch(num){
            case 1:
                return RacasProntas.Humano();
            case 2:
                return RacasProntas.Elfo();
            case 3:
                return RacasProntas.Anao();
            case 4:
                return RacasProntas.Orc();
            case 5:
                return RacasProntas.Gnomo();
            default:
                return RacasProntas.Humano();
        }
    }
}