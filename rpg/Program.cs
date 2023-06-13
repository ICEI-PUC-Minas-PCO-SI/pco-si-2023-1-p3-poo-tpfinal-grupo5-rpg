//Exemplo de criação de uma pessoa, um monstro e um animal:
Pessoa p = new Pessoa();
Monstro m = new Monstro();
Animal a = new Animal();

Console.WriteLine($"Nome da pessoa: {p.getNome()}\nRaça: {p.getRaca().getNome()}\nClasse: {p.getClasse().getNome()}\nAtaque: {p.getAtaque()}\nDefesa: {p.getDefesa()}\nSorte: {p.getSorte()}\nNível: {p.getNivel()}\nVida: {p.getVida()}\nMana: {p.getMana()}\nDinheiro: {p.getDinheiro()}\nItem ativo: {p.getItemAtivo()}\nAtaques: {p.getAtaques()}\nItens: {p.getItens()}");
Console.WriteLine($"\n\nMonstro: {m.getNome()}");
Console.WriteLine($"\n\nAnimal: {a.getNome()}");

// REVISAR AS LINHAS 27 A 30 DE PERSONAGEM.CS