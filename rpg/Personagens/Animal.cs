public class Animal : Personagem{
    public Animal(){
        this.nome = GeradorNomes.GerarNomeAnimal();
        this.vida += 10;
        this.mana += 20;
        this.ataque += 5;
        this.defesa += 5;
        this.sorte += 1;
        this.dinheiro += 5;
    }
    public Animal(string nome, int vida, int mana, int ataque, int defesa, int sorte, int nivel, List<Ataque> ataques, List<Item> itens, int dinheiro, Classe classe, Raca raca){
        this.nome = nome;
        this.vida = vida;
        this.mana = mana;
        this.ataque = ataque;
        this.defesa = defesa;
        this.sorte = sorte;
        this.nivel = nivel;
        this.ataques = ataques;
        this.itens = itens;
        this.dinheiro = dinheiro;
        this.classe = classe;
        this.raca = raca;
    }
}