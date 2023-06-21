public class CombateCultista
{
    private Jogavel personagem;
    private Pessoa cultista;

    public CombateCultista(Jogavel personagem, Pessoa cultista)
    {
        this.personagem = personagem;
        this.cultista = cultista;
    }

    public Jogavel Personagem { get => personagem; set => personagem = value; }
    public Pessoa Cultista { get => cultista; set => cultista = value; }
}
