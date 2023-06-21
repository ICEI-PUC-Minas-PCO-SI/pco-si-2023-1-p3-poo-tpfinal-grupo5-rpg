public class Pessoa : Combatente, IComercio, IDroparItem, IUsarItem{
    private Classe classe;
    private Raca raca;
    private Arma arma;
    private Armadura armadura;
    protected List<Item> inventario = new List<Item>();
    public Pessoa(){
        this.Classe = GeradorDeClasses.GerarClasse();
        this.Raca = GeradorDeRacas.GerarRaca();
        this.inventario.Add(this.Classe.Item);
        this.Arma = null;
        this.Armadura = null;
        this.Nome = GeradorDeNomes.GerarNomePessoa();
        this.Dinheiro += Dado.RandomNumber(0, 30) + this.Classe.ModDinheiro + this.Raca.ModDinheiro;
        this.Vida += Dado.RandomNumber(60, 100) + this.Classe.ModVida + this.Raca.ModVida;
        this.Mana += Dado.RandomNumber(20, 50) + this.Classe.ModMana + this.Raca.ModMana;
        this.Ataque += Dado.RandomNumber(5, 12) + this.Classe.ModAtaque + this.Raca.ModAtaque;
        this.Defesa += Dado.RandomNumber(5, 10) + this.Classe.ModDefesa + this.Raca.ModDefesa;
        this.Sorte += Dado.RandomNumber(-5, 10) + this.Classe.ModSorte + this.Raca.ModSorte;
        this.Nivel = 1;
        this.Ataques.Add(this.raca.Ataque1);
    }

    public Pessoa(Classe classe, Raca raca, Arma arma, Armadura armadura, List<Item> inventario)
    {
        this.classe = classe;
        this.raca = raca;
        this.arma = arma;
        this.armadura = armadura;
        this.inventario = inventario;
    }

    public Pessoa(Classe classe, Raca raca, Arma arma, Armadura armadura, List<Item> inventario, int vida, int defesa, int ataque)
    {
        this.classe = classe;
        this.raca = raca;
        this.arma = arma;
        this.armadura = armadura;
        this.inventario = inventario;
        this.vida = vida;
        this.defesa = defesa;
        this.ataque = ataque;
    }

    public Classe Classe { get => classe; set => classe = value; }
    public Raca Raca { get => raca; set => raca = value; }
    public Arma Arma { get => arma; set => arma = value; }
    public Armadura Armadura { get => armadura; set => armadura = value; }
    public List<Item> Inventario { get => inventario; set => inventario = value; }

    public void comprar(Item item){
        if(this.Dinheiro >= item.Preco){
            this.Dinheiro -= item.Preco;
            this.inventario.Add(item);
        }
    }
    public void vender(Item item){
        this.Dinheiro += item.Preco;
        this.inventario.Remove(item);
    }

    public Item droparItem(Item item){
        this.inventario.Remove(item);
        return item; 
    }

    public void usarArma(Arma arma){
        string modificador = "";
        if(this.Arma != null){
            modificador = this.Arma.Modificador;
            switch(modificador){
                case "vida":
                    this.Vida -= this.Arma.ValorModificador;
                    break;
                case "mana":
                    this.Mana -= this.Arma.ValorModificador;
                    break;
                case "ataque":
                    this.Ataque -= this.Arma.ValorModificador;
                    break;
                case "defesa":
                    this.Defesa -= this.Arma.ValorModificador;
                    break;
                case "sorte":
                    this.Sorte -= this.Arma.ValorModificador;
                    break;
            }
        }
        this.Arma = arma;
        modificador = arma.Modificador;
        switch(modificador){
            case "vida":
                this.Vida += arma.ValorModificador;
                break;
            case "mana":
                this.Mana += arma.ValorModificador;
                break;
            case "ataque":
                this.Ataque += arma.ValorModificador;
                break;
            case "defesa":
                this.Defesa += arma.ValorModificador;
                break;
            case "sorte":
                this.Sorte += arma.ValorModificador;
                break;
        }
    }

    public void usarArmadura(Armadura armadura){
        string modificador = "";
        if(this.Armadura != null){
            modificador = this.Armadura.Modificador;
            switch(modificador){
                case "vida":
                    this.Vida -= this.Armadura.ValorModificador;
                    break;
                case "mana":
                    this.Mana -= this.Armadura.ValorModificador;
                    break;
                case "ataque":
                    this.Ataque -= this.Armadura.ValorModificador;
                    break;
                case "defesa":
                    this.Defesa -= this.Armadura.ValorModificador;
                    break;
                case "sorte":
                    this.Sorte -= this.Armadura.ValorModificador;
                    break;
            }
        }
        this.Armadura = armadura;
        modificador = armadura.Modificador;
        switch(modificador){
            case "vida":
                this.Vida += armadura.ValorModificador;
                break;
            case "mana":
                this.Mana += armadura.ValorModificador;
                break;
            case "ataque":
                this.Ataque += armadura.ValorModificador;
                break;
            case "defesa":
                this.Defesa += armadura.ValorModificador;
                break;
            case "sorte":
                this.Sorte += armadura.ValorModificador;
                break;
        }
    }
    public void usarConsumivel(Consumivel consumivel){
        string modificador = "";
        modificador = consumivel.Modificador;
        switch(modificador){
            case "vida":
                this.Vida += consumivel.ValorModificador;
                break;
            case "mana":
                this.Mana += consumivel.ValorModificador;
                break;
            case "ataque":
                this.Ataque += consumivel.ValorModificador;
                break;
            case "defesa":
                this.Defesa += consumivel.ValorModificador;
                break;
            case "sorte":
                this.Sorte += consumivel.ValorModificador;
                break;
        }
    }

    public override int atacar(Ataque ataque)
    {
        return base.atacar(ataque);
    }
    public override void defender(int dano)
    {
        base.defender(dano);
    }
    public override int droparDinheiro()
    {
        return base.droparDinheiro();
    }
}