public static class PessoasProntas
{
    public static Pessoa[] geraPessoas()
    {
        Pessoa[] pessoas = new Pessoa[5];

        Pessoa cultistaG = new Pessoa(ClassesProntas.Guerreiro(), RacasProntas.Humano(), ArmasProntas.EspadaLonga(), ArmadurasProntas.Couraca(), new List<Item>(), 750, 15, 20);

        Pessoa cultistaA = new Pessoa(ClassesProntas.Arqueiro(), RacasProntas.Humano(), ArmasProntas.ArcoCurto(), ArmadurasProntas.Couraca(), new List<Item>(), 700, 10, 25);

        Pessoa cultistaC = new Pessoa(ClassesProntas.Clerigo(), RacasProntas.Humano(), ArmasProntas.Cajado(), ArmadurasProntas.Couraca(), new List<Item>(), 600, 5, 30);

        Pessoa cultistaL = new Pessoa(ClassesProntas.Ladino(), RacasProntas.Humano(), ArmasProntas.Adaga(), ArmadurasProntas.Couraca(), new List<Item>(), 650, 10, 25);

        Pessoa cultistaT = new Pessoa(ClassesProntas.Tanque(), RacasProntas.Humano(), ArmasProntas.EspadaLonga(), ArmadurasProntas.Couraca(), new List<Item>(), 800, 20, 15);

        Pessoa oibaf = new Pessoa(ClassesProntas.Guerreiro(), RacasProntas.Humano(), ArmasProntas.EspadaLonga(), ArmadurasProntas.CotaDeMalha(), new List<Item>(), 1000, 35, 40);

        return new Pessoa[] {cultistaG, cultistaA, cultistaC, cultistaL, cultistaT, oibaf};
    }

    public static Pessoa CultistaGuerreiro()
    {
        return geraPessoas()[0];
    }
    public static Pessoa CultistaArqueiro()
    {
        return geraPessoas()[1];
    }
    public static Pessoa CultistaClerigo()
    {
        return geraPessoas()[2];
    }
    public static Pessoa CultistaLadino()
    {
        return geraPessoas()[3];
    }
    public static Pessoa CultistaTanque()
    {
        return geraPessoas()[4];
    }
    public static Pessoa Oibaf()
    {
        return geraPessoas()[5];
    }
}