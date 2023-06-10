abstract class Personagem
{
    private String nome { get; set; }
    private int moeda { get; set; }

    // Construtores
    public Personagem()
    {

    }
    public Personagem(String nome, int moeda)
    {
        this.nome = nome;
        this.moeda = moeda;
    }

    // Métodos
    protected virtual string exibeMensagem()
    {
        return "";
    }
}