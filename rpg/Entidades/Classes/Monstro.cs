sealed class Monstro : Combatente, IAtaqueEspecial
{
    // Construtores
    public Monstro()
    {

    }
    public Monstro(Double forca, Double defesa, int vida, int nivel) : base(forca, defesa, vida, nivel)
    {

    }

    // M�todos
    protected void ataqueEspecial(int nivel, double forca)
    {

    }
}