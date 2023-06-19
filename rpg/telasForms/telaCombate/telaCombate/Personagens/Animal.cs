public class Animal : Personagem, IDroparDinheiro, IDefender, IAtacar{
    private int vida;
    private int defesa;
    public Animal(){
        this.Nome = GeradorDeNomes.GerarNomeAnimal();
        this.Dinheiro += Dado.RandomNumber(1, 10);
        this.vida = Dado.RandomNumber(1, 20);
        this.defesa = Dado.RandomNumber(1, 10);
    }
    public Animal(int nivel){
        this.Nome = GeradorDeNomes.GerarNomeAnimal();
        this.Dinheiro += Dado.RandomNumber(1, 10) * (nivel / 2);
        this.vida = Dado.RandomNumber(1, 20) * (nivel / 2);
        this.defesa = Dado.RandomNumber(1, 10) * (nivel / 2);
    }
    public Animal(string nome, int vida, int defesa, int dinheiro){
        this.Nome = nome;
        this.vida = vida;
        this.defesa = defesa;
        this.Dinheiro = dinheiro;
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

    public int atacar(Ataque ataque)
    {
        return Dado.RandomNumber(1, 4);
    }
}