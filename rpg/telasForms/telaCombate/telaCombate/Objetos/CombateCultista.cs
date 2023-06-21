public class CombateCultista
{
    private Jogavel personagem;
    private Pessoa cultista;

    public CombateCultista(Jogavel personagem, Pessoa cultista)
    {
        this.personagem = personagem;
        this.cultista = cultista;

        // Criar objeto Combate com os argumentos corretos
        CombateCultista combate = new CombateCultista(personagem, cultista);
        // Resto do código do combate...
    }

    public Jogavel Personagem { get => personagem; set => personagem = value; }
    public Pessoa Inimigo { get => cultista; set => cultista = value; }
}
