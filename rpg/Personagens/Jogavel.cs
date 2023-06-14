public class Jogavel : Pessoa{
    private int xp;
    public Jogavel(){
        this.Classe = GeradorDeClasses.GerarClasse();
        this.Raca = GeradorDeRacas.GerarRaca();
        this.inventario.Add(this.Classe.Item);
        this.Arma = null;
        this.Armadura = null;
        this.Nome = GeradorDeNomes.GerarNomePessoa();
        this.Dinheiro += 0 + this.Classe.ModDinheiro + this.Raca.ModDinheiro;
        this.Vida += 100 + this.Classe.ModVida + this.Raca.ModVida;
        this.Mana += 30 + this.Classe.ModMana + this.Raca.ModMana;
        this.Ataque += 10 + this.Classe.ModAtaque + this.Raca.ModAtaque;
        this.Defesa += 6 + this.Classe.ModDefesa + this.Raca.ModDefesa;
        this.Sorte += 0 + this.Classe.ModSorte + this.Raca.ModSorte;
        this.Nivel = 1;
    }

    public Jogavel(string nome, Classe classe, Raca raca){
        this.Classe = classe;
        this.Raca = raca;
        this.inventario.Add(this.Classe.Item);
        this.Arma = null;
        this.Armadura = null;
        this.Nome = nome;
        this.Dinheiro += 0 + this.Classe.ModDinheiro + this.Raca.ModDinheiro;
        this.Vida += 100 + this.Classe.ModVida + this.Raca.ModVida;
        this.Mana += 30 + this.Classe.ModMana + this.Raca.ModMana;
        this.Ataque += 10 + this.Classe.ModAtaque + this.Raca.ModAtaque;
        this.Defesa += 6 + this.Classe.ModDefesa + this.Raca.ModDefesa;
        this.Sorte += 0 + this.Classe.ModSorte + this.Raca.ModSorte;
        this.Nivel = 1;
    }
    public int Xp { get => xp; set => xp = value; }

    public void ganharXP(int xp){
        this.xp += xp;
    }
    public void passarDeNivel(){
        this.xp = 0;
        this.Nivel += 1;
        this.Vida += 5;
        this.Mana += 5;
        this.Ataque += 2;
        this.Defesa += 1;
        this.Sorte += 1;
    }
}