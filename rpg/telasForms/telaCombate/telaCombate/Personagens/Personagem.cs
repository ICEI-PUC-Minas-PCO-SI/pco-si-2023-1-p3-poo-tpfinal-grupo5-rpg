// REVISAR AS LINHAS 27 A 30
public class Personagem : IFalar{
    private string nome;
    private int dinheiro;

    public string Nome { get => nome; set => nome = value; }
    public int Dinheiro { get => dinheiro; set => dinheiro = value; }

    public Personagem(){
        this.Nome = "";
        this.Dinheiro = 0;
    }

    public Personagem(string nome, int dinheiro){
        this.Nome = nome;
        this.Dinheiro = dinheiro;
    }
    public string falar(string fala){
        return fala;
    }
}