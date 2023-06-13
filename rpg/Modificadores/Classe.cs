public class Classe{
    private string nome;
    private string descricao;
    private int Modvida;
    private int Modmana;
    private int Modataque;
    private int Moddefesa;
    private int Modsorte;
    private int Moddinheiro;
    private Item item;

    public Classe(){
        this.nome = "";
        this.Modvida = 0;
        this.Modmana = 0;
        this.Modataque = 0;
        this.Moddefesa = 0;
        this.Modsorte = 0;
        this.Moddinheiro = 0;
        this.item = null;
        this.descricao = "";
    }
    public Classe(string nome, int Modvida, int Modmana, int Modataque, int Moddefesa, int Modsorte, int Moddinheiro, Item item, string descricao){
        this.nome = nome;
        this.Modvida = Modvida;
        this.Modmana = Modmana;
        this.Modataque = Modataque;
        this.Moddefesa = Moddefesa;
        this.Modsorte = Modsorte;
        this.Moddinheiro = Moddinheiro;
        this.item = item;
        this.descricao = descricao;
    }
    public string getNome(){
        return this.nome;
    }
    public string getDescricao(){
        return this.descricao;
    }
    public int getModvida(){
        return this.Modvida;
    }
    public int getModmana(){
        return this.Modmana;
    }
    public int getModataque(){
        return this.Modataque;
    }
    public int getModdefesa(){
        return this.Moddefesa;
    }
    public int getModsorte(){
        return this.Modsorte;
    }
    public int getModdinheiro(){
        return this.Moddinheiro;
    }
    public Item getItem(){
        return this.item;
    }
    public void setNome(string nome){
        this.nome = nome;
    }
    public void setDescricao(string descricao){
        this.descricao = descricao;
    }
    public void setModvida(int Modvida){
        this.Modvida = Modvida;
    }
    public void setModmana(int Modmana){
        this.Modmana = Modmana;
    }
    public void setModataque(int Modataque){
        this.Modataque = Modataque;
    }
    public void setModdefesa(int Moddefesa){
        this.Moddefesa = Moddefesa;
    }
    public void setModsorte(int Modsorte){
        this.Modsorte = Modsorte;
    }
    public void setModdinheiro(int Moddinheiro){
        this.Moddinheiro = Moddinheiro;
    }
    public void setItem(Item item){
        this.item = item;
    }
}