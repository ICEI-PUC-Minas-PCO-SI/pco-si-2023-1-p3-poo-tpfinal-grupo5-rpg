sealed class Missao : IDropar
{
    private String nomeMissao { get; set; }
    private int nivel { get; set; }

    //  Construtores
    public Missao()
    {

    }
    public Missao(String nomeMissao, int nivel)
    {
        this.nomeMissao = nomeMissao;
        this.nivel = nivel;
    }

    // Métodos
    private String exibeDetalhes(String detalhes)
    {
        return detalhes;
    }
    private void iniciarMissao()
    {

    }
    private String completarMissao(int moedasMissao, int xpMissao)
    {
        return "Missão finalizada!"
    }
    public int droparMoeda()
    {
        return 10;
    }
    public int droaparXp()
    {
        return 10;
    }
}