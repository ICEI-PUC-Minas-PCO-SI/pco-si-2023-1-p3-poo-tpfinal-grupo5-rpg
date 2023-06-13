using System;

public static class GeradorNomes
{
    private static readonly Random random = new Random();

    private static readonly string[] nomesPessoas = { "Emma", "Liam", "Olivia", "Noah", "Ava", "Isabella", "Sophia", "Mia", "Charlotte", "Amelia", "Harper", "Evelyn", "Abigail", "Emily", "Elizabeth", "Mila", "Ella", "Avery", "Sofia", "Camila", "Aria", "Scarlett", "Victoria", "Madison", "Luna", "Grace", "Chloe", "Penelope", "Layla", "Riley", "Zoey", "Nora", "Lily", "Eleanor", "Hannah", "Lillian", "Addison", "Aubrey", "Ellie", "Stella", "Natalie", "Zoe", "Leah", "Hazel", "Violet", "Aurora", "Savannah", "Audrey", "Brooklyn", "Bella", "Claire" };


    private static readonly string[] sobrenomesPessoas = { "Smith", "Johnson", "Williams", "Brown", "Jones", "Miller", "Davis", "Garcia", "Wilson", "Taylor" };

    private static readonly string[] nomesAnimais = { "Buddy", "Luna", "Charlie", "Rocky", "Lucy", "Cooper", "Max", "Bailey", "Daisy", "Sadie", "Molly", "Tucker", "Lola", "Bear", "Milo", "Zoe", "Ruby", "Roxy", "Coco", "Stella", "Bentley", "Chloe", "Teddy", "Penny", "Leo", "Gus", "Bella", "Riley", "Duke", "Oscar", "Zeus", "Hank", "Winston", "Jack", "Rosie", "Abby", "Harley", "Sammy", "Ginger", "Jax", "Lily", "Koda", "Charlie", "Hazel", "Willow", "Lucky", "Finn", "Pepper", "Dexter", "Jasper" };

    private static readonly string[] nomesMonstros = { "Drácula", "Espectro", "Serpente", "Horror", "Demônio", "Arconte", "Lorde", "Quimera", "Maldição", "Besta", "Fantasma", "Morcego", "Inferno", "Titã", "Cavaleiro", "Criatura", "Assombração", "Ciclope", "Monge", "Víbora", "Saqueador", "Rei", "Espírito", "Fera", "Senhor", "Pesadelo", "Assassino", "Espreitador", "Bruxa", "Aberração", "Guardião", "Horror", "Mestre", "Sombra", "Colosso", "Cão", "Devorador", "Aparição", "Gigante", "Peste", "Lâmina", "Verme", "Criatura", "Serpente", "Fantasma", "Espectro", "Emissário", "Carrasco" };



    private static readonly string[] vulgosMonstros = { "Devorador de Almas", "Flagelo Noturno", "Abominação Voraz", "Lâmina Sombria", "Carniceiro Sinistro", "Senhor da Perdição", "Horror do Abismo", "Cavaleiro da Morte", "Pesadelo Cruel", "Terror Espectral", "Cão Infernal", "Assassino das Sombras", "Tormento Macabro", "Espírito Vingativo", "Devorador de Sonhos", "Peste Negra", "Aberração Desolada", "Sanguinário Voraz", "Criatura Abominável", "Espreitador Sombrio", "Conquistador das Trevas", "Maldição Profana", "Fera Devastadora", "Mestre das Ilusões", "Lâmina Afiada", "Devorador de Mentes", "Desperto da Ruína", "Vórtice Sombrio", "Terror do Submundo", "Sombra Malévola", "Flagelo Sanguinolento", "Espírito Atormentado", "Carrasco da Noite", "Lâmina da Perdição", "Besta Voraz", "Abominação Infernal", "Manto Sinistro", "Ceifador Implacável", "Devorador de Esperanças", "Fera Apocalíptica", "Espectro Sanguinário", "Monge da Escuridão", "Príncipe das Trevas", "Tormento Sombrio", "Lâmina Obscura", "Fúria Maléfica", "Senhor das Sombras", "Pesadelo Eterno", "Emissário da Destruição", "Cavaleiro Sinistro", "Legado Maldito", "Bruxo da Perdição", "Colosso Sombrio" };


    public static string GerarNomePessoa()
    {
        int nomeIndex = random.Next(nomesPessoas.Length);
        int sobrenomeIndex = random.Next(sobrenomesPessoas.Length);
        
        string nome = nomesPessoas[nomeIndex];
        string sobrenome = sobrenomesPessoas[sobrenomeIndex];

        return nome + " " + sobrenome;
    }

    public static string GerarNomeAnimal()
    {
        int index = random.Next(nomesAnimais.Length);
        return nomesAnimais[index];
    }

    public static string GerarNomeMonstro()
    {
        int nomeIndex = random.Next(nomesMonstros.Length);
        int vulgoIndex = random.Next(vulgosMonstros.Length);
        
        string nome = nomesMonstros[nomeIndex];
        string vulgo = vulgosMonstros[vulgoIndex];

        return $"{nome} {vulgo}";
    }
}
