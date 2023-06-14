public class Item{
    protected string nome;
    protected int preco;
    protected int quantidade;
    protected int nivel;

    public Item(){
        this.Nome = "";
        this.Preco = 0;
        this.Quantidade = 0;
        this.Nivel = 0;
    }
    public Item(string nome, int preco, int quantidade, int nivel){
        this.Nome = nome;
        this.Preco = preco;
        this.Quantidade = quantidade;
        this.Nivel = nivel;
    }

    public string Nome { get => nome; set => nome = value; }
    public int Preco { get => preco; set => preco = value; }
    public int Quantidade { get => quantidade; set => quantidade = value; }
    public int Nivel { get => nivel; set => nivel = value; }
}