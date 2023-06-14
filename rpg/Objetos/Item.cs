public class Item{
    private string nome;
    private int preco;
    private int quantidade;
    private int nivel;

    private bool consumivel;

    private String modificador;
    private int valorModificador;

    public Item(){
        this.nome = "";
        this.preco = 0;
        this.quantidade = 0;
        this.nivel = 0;
        this.consumivel = false;
        this.modificador = "";
        this.valorModificador = 0;
    }
    public Item(string nome, int preco, int quantidade, int nivel, bool consumivel, string modificador, int valorModificador){
        this.nome = nome;
        this.preco = preco;
        this.quantidade = quantidade;
        this.nivel = nivel;
        this.consumivel = consumivel;
        this.modificador = modificador;
        this.valorModificador = valorModificador;
    }
    public string getNome(){
        return this.nome;
    }
    public int getPreco(){
        return this.preco;
    }
    public int getQuantidade(){
        return this.quantidade;
    }
    public int getNivel(){
        return this.nivel;
    }
    public bool getConsumivel(){
        return this.consumivel;
    }
    public string getModificador(){
        return this.modificador;
    }
    public int getValorModificador(){
        return this.valorModificador;
    }

    public void setNome(string nome){
        this.nome = nome;
    }
    public void setPreco(int preco){
        this.preco = preco;
    }
    public void setQuantidade(int quantidade){
        this.quantidade = quantidade;
    }
    public void setNivel(int nivel){
        this.nivel = nivel;
    }
    public void setConsumivel(bool consumivel){
        this.consumivel = consumivel;
    }
    public void setModificador(string modificador){
        this.modificador = modificador;
    }
    public void setValorModificador(int valorModificador){
        this.valorModificador = valorModificador;
    }

}