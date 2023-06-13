// REVISAR AS LINHAS 27 A 30
public class Personagem{
    protected string nome;
    protected int vida;
    protected int mana;
    protected int ataque;
    protected int defesa;
    protected int sorte;
    protected int nivel;
    protected int xp;
    protected List<Ataque> ataques = new List<Ataque>();
    protected List<Item> itens = new List<Item>();
    protected Item itemAtivo;
    protected Classe classe;
    protected Raca raca;
    protected int dinheiro;

    public Personagem(){
        this.nome = "";
        this.raca = GeradorDeRacas.GerarRaca();
        this.classe = GeradorDeClasses.GerarClasse();
        this.vida = 0 + this.raca.getModvida() + this.classe.getModvida();
        this.mana = 0 + this.raca.getModmana() + this.classe.getModmana();
        this.ataque = 0 + this.raca.getModataque() + this.classe.getModataque();
        this.defesa = 0 + this.raca.getModdefesa() + this.classe.getModdefesa();
        this.sorte = 0 + this.raca.getModsorte() + this.classe.getModsorte();
        this.nivel = 1;
        this.xp = 0;
        this.ataques.Add(AtaquesProntos.Basico());
        this.ataques.Add(this.raca.getAtaque());
        this.itens.Add(this.classe.getItem());
        this.itemAtivo = this.itens[0];
        this.dinheiro = 0 + this.raca.getModdinheiro() + this.classe.getModdinheiro();
    }

    public Personagem(string nome, int vida, int mana, int ataque, int defesa, int sorte, int nivel, List<Ataque> ataques, List<Item> itens, int dinheiro, Classe classe, Raca raca, Item itemAtivo, int xp){
        this.nome = nome;
        this.vida = vida;
        this.mana = mana;
        this.ataque = ataque;
        this.defesa = defesa;
        this.sorte = sorte;
        this.nivel = nivel;
        this.xp = xp;
        this.ataques = ataques;
        this.itens = itens;
        this.itemAtivo = itemAtivo;
        this.dinheiro = dinheiro;
        this.classe = classe;
        this.raca = raca;
    }

    public string getNome(){
        return this.nome;
    }
    public int getVida(){
        return this.vida;
    }
    public int getMana(){
        return this.mana;
    }
    public int getAtaque(){
        return this.ataque;
    }
    public int getDefesa(){
        return this.defesa;
    }
    public int getSorte(){
        return this.sorte;
    }
    public int getNivel(){
        return this.nivel;
    }
    public List<Ataque> getAtaques(){
        return this.ataques;
    }
    public List<Item> getItens(){
        return this.itens;
    }
    public Item getItemAtivo(){
        return this.itemAtivo;
    }
    public int getDinheiro(){
        return this.dinheiro;
    }
    public Classe getClasse(){
        return this.classe;
    }
    public Raca getRaca(){
        return this.raca;
    }
    public int getXp(){
        return this.xp;
    }
    public void setNome(string nome){
        this.nome = nome;
    }
    public void setVida(int vida){
        this.vida = vida;
    }
    public void setMana(int mana){
        this.mana = mana;
    }
    public void setAtaque(int ataque){
        this.ataque = ataque;
    }
    public void setDefesa(int defesa){
        this.defesa = defesa;
    }
    public void setSorte(int sorte){
        this.sorte = sorte;
    }
    public void setNivel(int nivel){
        this.nivel = nivel;
    }
    public void setAtaques(List<Ataque> ataques){
        this.ataques = ataques;
    }
    public void setItens(List<Item> itens){
        this.itens = itens;
    }
    public void setItemAtivo(Item itemAtivo){
        this.itemAtivo = itemAtivo;
    }
    public void setDinheiro(int dinheiro){
        this.dinheiro = dinheiro;
    }
    public void setClasse(Classe classe){
        this.classe = classe;
    }
    public void setRaca(Raca raca){
        this.raca = raca;
    }
    public void setXp(int xp){
        this.xp = xp;
    }

    public virtual int atacar(Ataque ataque){
        int dado = Dado.RandomNumber((0 + this.sorte), 100);
        dado -= (100 - ataque.getChanceDeAcerto());
        if(dado >= 0){
            return ataque.getDano() + this.ataque;
        }
        else{
            return 0;
        }
    }
    	
    public virtual void defender(int dano){
        this.vida -= dano - this.defesa;
    }

    public virtual void usarItem(Item item){
        this.itemAtivo = item;
    }

    public virtual void falar(string fala){
        Console.WriteLine(fala);
    }

    public virtual void comprarItem(Item item){
        this.itens.Add(item);
    }

    public virtual void venderItem(Item item){
        this.itens.Remove(item);
    }

    public virtual List<Item> droparItens(){
        return this.itens;
    }
}