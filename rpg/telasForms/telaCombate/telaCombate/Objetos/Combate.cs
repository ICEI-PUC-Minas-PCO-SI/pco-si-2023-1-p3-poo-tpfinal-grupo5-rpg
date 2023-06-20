public class Combate
{
    private Jogavel personagem = new Jogavel();
    private Animal inimigo = new Animal();

    public Combate(Jogavel personagem, Animal inimigo)
    {
        this.Personagem = personagem;
        this.Inimigo = inimigo;
    }

    public Jogavel Personagem { get => personagem; set => personagem = value; }
    public Animal Inimigo { get => inimigo; set => inimigo = value; }
}
