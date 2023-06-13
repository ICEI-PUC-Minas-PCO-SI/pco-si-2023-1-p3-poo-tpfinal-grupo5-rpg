public class Ataque{
    private string nome;
    private int dano;
    private int gastoDemana;
    private int chanceDeAcerto;

    public Ataque(){
        this.nome = "";
        this.dano = 0;
        this.gastoDemana = 0;
        this.chanceDeAcerto = 0;
    }
    public Ataque(string nome, int dano, int gastoDemana, int chanceDeAcerto){
        this.nome = nome;
        this.dano = dano;
        this.gastoDemana = gastoDemana;
        this.chanceDeAcerto = chanceDeAcerto;
    }

    public string getNome(){
        return this.nome;
    }
    public int getDano(){
        return this.dano;
    }
    public int getGastoDemana(){
        return this.gastoDemana;
    }
    public int getChanceDeAcerto(){
        return this.chanceDeAcerto;
    }
    public void setNome(string nome){
        this.nome = nome;
    }
    public void setDano(int dano){
        this.dano = dano;
    }
    public void setGastoDemana(int gastoDemana){
        this.gastoDemana = gastoDemana;
    }
    public void setChanceDeAcerto(int chanceDeAcerto){
        this.chanceDeAcerto = chanceDeAcerto;
    }
    
}