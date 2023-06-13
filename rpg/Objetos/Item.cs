public class Item{
    private string nome;
    private int preco;
    private int quantidade;
    private int nivel;

    public Item(){
        this.nome = "";
        this.preco = 0;
        this.quantidade = 0;
        this.nivel = 0;
    }
    public Item(string nome, int preco, int quantidade, int nivel){
        this.nome = nome;
        this.preco = preco;
        this.quantidade = quantidade;
        this.nivel = nivel;
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
}