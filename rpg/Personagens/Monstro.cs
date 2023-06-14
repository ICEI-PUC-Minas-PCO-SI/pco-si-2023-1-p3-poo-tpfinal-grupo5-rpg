public class Monstro : Combatente{
    public Monstro(){
        this.Nome = GeradorDeNomes.GerarNomeMonstro();
        this.Dinheiro += Dado.RandomNumber(0, 15);
        this.Vida = Dado.RandomNumber(15, 25);
        this.Mana = Dado.RandomNumber(0, 40);
        this.Ataque = Dado.RandomNumber(2, 8);
        this.Defesa = Dado.RandomNumber(0, 5);
        this.Sorte = Dado.RandomNumber(0, 5);
        this.Nivel = 1;
    }
    Monstro(int nivel){
        this.Nome = GeradorDeNomes.GerarNomeMonstro();
        this.Dinheiro += Dado.RandomNumber(0, 15) * nivel/2;
        this.Vida = Dado.RandomNumber(15, 25)* nivel/2;
        this.Mana = Dado.RandomNumber(0, 40)* nivel/2;
        this.Ataque = Dado.RandomNumber(2, 8)* nivel/2;
        this.Defesa = Dado.RandomNumber(0, 5)* nivel/2;
        this.Sorte = Dado.RandomNumber(0, 5)* nivel/2;
        this.Nivel = nivel;
    }
}