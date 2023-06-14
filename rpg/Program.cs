//Exemplo de criação de um personagem jogável
Console.WriteLine("Criando um personagem...");
Console.Write("Digite o nome do personagem: ");
string nome = Console.ReadLine();
Console.Clear();
Console.Write("Escolha a raça do personagem:\n1 - Humano\n2 - Elfo\n3 - Anão\n4 - Orc\n5 - Gnomo\n\nResposta: ");
int escolhaRaca = int.Parse(Console.ReadLine());
Raca raca = new Raca();
switch(escolhaRaca){
    case 1:
        raca = RacasProntas.Humano();
        break;
    case 2:
        raca = RacasProntas.Elfo();
        break;
    case 3:
        raca = RacasProntas.Anao();
        break;
    case 4:
        raca = RacasProntas.Orc();
        break;
    case 5:
        raca = RacasProntas.Gnomo();
        break;
    default:
        Console.WriteLine("Opção inválida!");
        break;
}
Console.Clear();
Console.Write("Escolha a classe do personagem:\n1 - Guerreiro\n2 - Clérigo\n3 - Arqueiro\n4 - Ladino\n5 - Tanque\n\nResposta: ");
int escolhaClasse = int.Parse(Console.ReadLine());
Classe classe = new Classe();
switch(escolhaClasse){
    case 1:
        classe = ClassesProntas.Guerreiro();
        break;
    case 2:
        classe = ClassesProntas.Clerigo();
        break;
    case 3:
        classe = ClassesProntas.Arqueiro();
        break;
    case 4:
        classe = ClassesProntas.Ladino();
        break;
    case 5:
        classe = ClassesProntas.Tanque();
        break;
}
Console.Clear();
Jogavel personagem = new Jogavel(nome, classe, raca);
Console.WriteLine("Personagem criado com sucesso!");
Console.WriteLine("Nome: " + personagem.Nome);
Console.WriteLine("Raça: " + personagem.Raca.Nome);
Console.WriteLine("Classe: " + personagem.Classe.Nome);
Console.WriteLine("Vida: " + personagem.Vida);
Console.WriteLine("Mana: " + personagem.Mana);
Console.WriteLine("Ataque: " + personagem.Ataque);
Console.WriteLine("Defesa: " + personagem.Defesa);
Console.WriteLine("Sorte: " + personagem.Sorte);
Console.WriteLine("Nível: " + personagem.Nivel);
Console.WriteLine("Dinheiro: " + personagem.Dinheiro);
if(personagem.Arma != null){Console.WriteLine("Arma: " + personagem.Arma.Nome);}
if(personagem.Armadura != null){Console.WriteLine("Armadura: " + personagem.Armadura.Nome);}
Console.WriteLine("Inventário: ");
foreach(Item item in personagem.Inventario){
    Console.WriteLine(item.Nome);
}
Console.WriteLine("Habilidades: ");
foreach(Ataque ataque in personagem.Ataques){
    Console.WriteLine(ataque.Nome);
}
Console.WriteLine("Pressione qualquer tecla para continuar...");
Console.ReadKey();
Console.Clear();

