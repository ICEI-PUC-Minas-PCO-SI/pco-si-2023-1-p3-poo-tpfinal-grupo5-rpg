public class Pessoa : Personagem{
    public Pessoa(){
        this.nome = GeradorNomes.GerarNomePessoa();
        this.vida += 100;
        this.mana += 100;
        this.ataque += 10;
        this.defesa += 10;
        this.sorte += 1;
        this.dinheiro += 50;
    }
    public Pessoa(string nome, int vida, int mana, int ataque, int defesa, int sorte, int nivel, List<Ataque> ataques, List<Item> itens, int dinheiro, Classe classe, Raca raca){
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