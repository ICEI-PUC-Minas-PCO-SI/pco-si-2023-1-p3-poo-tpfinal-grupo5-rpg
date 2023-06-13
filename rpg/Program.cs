//Exemplo de criação de uma pessoa, um monstro e um animal:
Pessoa[] p = new Pessoa[5];
Monstro m = new Monstro();
Animal a = new Animal();

for(int i = 0; i<5; i++){
    p[i] = new Pessoa();
    Console.WriteLine($"Nome da pessoa: {p[i].getNome()}\nRaça: {p[i].getRaca().getNome()}\nClasse: {p[i].getClasse().getNome()}\nAtaque: {p[i].getAtaque()}\nDefesa: {p[i].getDefesa()}\nSorte: {p[i].getSorte()}\nNível: {p[i].getNivel()}\nVida: {p[i].getVida()}\nMana: {p[i].getMana()}\nDinheiro: {p[i].getDinheiro()}\nItem ativo: {p[i].getItemAtivo()}\nAtaques: {p[i].getAtaques()}\nItens: {p[i].getItens()}\n---------------------------\n");
}

Console.WriteLine($"\n----------------------------\nMonstro: {m.getNome()}\nAtaque: {m.getAtaque()}\nDefesa: {m.getDefesa()}\nSorte: {m.getSorte()}\nNível: {m.getNivel()}\nVida: {m.getVida()}\nMana: {m.getMana()}\nDinheiro: {m.getDinheiro()}");
Console.WriteLine($"\n---------------------------\nAnimal: {a.getNome()}\nAtaque: {m.getAtaque()}\nDefesa: {m.getDefesa()}\nSorte: {m.getSorte()}\nNível: {m.getNivel()}\nVida: {m.getVida()}\nMana: {m.getMana()}\nDinheiro: {m.getDinheiro()}");

// REVISAR AS LINHAS 27 A 30 DE PERSONAGEM.CS