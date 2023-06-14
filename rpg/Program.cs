//Exemplo de criação de uma pessoa, um monstro e um animal:
Pessoa[] p = new Pessoa[5];
Monstro m = new Monstro();
Animal a = new Animal();

for(int i = 0; i<5; i++){
    p[i] = new Pessoa();
    Console.WriteLine($"Nome da pessoa: {p[i].getNome()}\nRaça: {p[i].getRaca().getNome()}\nClasse: {p[i].getClasse().getNome()}\nAtaque: {p[i].getAtaque()}\nDefesa: {p[i].getDefesa()}\nSorte: {p[i].getSorte()}\nNível: {p[i].getNivel()}\nVida: {p[i].getVida()}\nMana: {p[i].getMana()}\nDinheiro: {p[i].getDinheiro()}");
    if(p[i].getArma() != null){
        Console.WriteLine($"Arma: {p[i].getArma().getNome()}");
    }
    if(p[i].getArmadura() != null){
        Console.WriteLine($"Armadura: {p[i].getArmadura().getNome()}");
    }
    for(int j = 0; j < p[i].getAtaques().Count; j++){
        Console.WriteLine($"Ataque {j+1}: {p[i].getAtaques()[j].getNome()}");
    }
    Console.Write($"Inventário: ");
    for(int k = 0; k < p[i].getItens().Count; k++){
        Console.Write($"{p[i].getItens()[k].getNome()}");
        if(k != p[i].getItens().Count-1)
            Console.Write(", ");
    }
    Console.WriteLine("\n---------------------------\n");
}

Console.WriteLine($"\n----------------------------\nMonstro: {m.getNome()}\nAtaque: {m.getAtaque()}\nDefesa: {m.getDefesa()}\nSorte: {m.getSorte()}\nNível: {m.getNivel()}\nVida: {m.getVida()}\nMana: {m.getMana()}\nDinheiro: {m.getDinheiro()}");
Console.WriteLine($"\n---------------------------\nAnimal: {a.getNome()}\nAtaque: {m.getAtaque()}\nDefesa: {m.getDefesa()}\nSorte: {m.getSorte()}\nNível: {m.getNivel()}\nVida: {m.getVida()}\nMana: {m.getMana()}\nDinheiro: {m.getDinheiro()}");

