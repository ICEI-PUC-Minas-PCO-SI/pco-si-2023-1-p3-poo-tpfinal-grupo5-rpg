public class Animal : Combatente, IDroparDinheiro, IDefender, IAtacar{
    public int vida;
    private int defesa;
    private int dano;
    public Animal(){
        this.Nome = GeradorDeNomes.GerarNomeAnimal();
        this.Dinheiro += Dado.RandomNumber(1, 10);
        this.vida = Dado.RandomNumber(1, 20);
        this.defesa = Dado.RandomNumber(1, 10);
        this.dano = Dado.RandomNumber(1, 20);
    }
    public Animal(int nivel){
        this.Nome = GeradorDeNomes.GerarNomeAnimal();
        this.Dinheiro += Dado.RandomNumber(1, 10) * (nivel / 2);
        this.vida = Dado.RandomNumber(1, 20) * (nivel / 2);
        this.defesa = Dado.RandomNumber(1, 10) * (nivel / 2);
    }
    public Animal(string nome, int vida, int defesa, int dinheiro, int dano){
        this.Nome = nome;
        this.vida = vida;
        this.defesa = defesa;
        this.Dinheiro = dinheiro;
        this.dano = dano;
    }

    public int Defesa { get => defesa; set => defesa = value; }
    protected int Vida { get => vida; set => vida = value; }

    public int droparDinheiro(){
        int dinheiro = this.Dinheiro;
        this.Dinheiro = 0;
        return dinheiro;
    }
    public void defender(int dano){
        this.vida -= dano - this.defesa;
    }

    public int atacar()
    {
        return dano;
    }
}