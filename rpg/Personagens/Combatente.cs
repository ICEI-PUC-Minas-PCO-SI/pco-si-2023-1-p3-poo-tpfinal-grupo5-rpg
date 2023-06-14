public class Combatente : Personagem, IAtacar, IDefender, IDroparDinheiro{
    private int vida;
    private int mana;
    private int ataque;
    private int defesa;
    private int sorte;
    private int nivel;
    private List<Ataque> ataques = new List<Ataque>();

    public Combatente(){
        this.ataques.Add(AtaquesProntos.Basico()); 
    }
    public Combatente(string nome, int dinheiro, int vida, int mana, int ataque, int defesa, int sorte, int nivel, List<Ataque> ataques){
        this.Nome = nome;
        this.Dinheiro = dinheiro;
        this.vida = vida;
        this.mana = mana;
        this.ataque = ataque;
        this.defesa = defesa;
        this.sorte = sorte;
        this.nivel = nivel;
        this.ataques = ataques; 
    }

    public int Vida { get => vida; set => vida = value; }
    public int Mana { get => mana; set => mana = value; }
    public int Ataque { get => ataque; set => ataque = value; }
    public int Defesa { get => defesa; set => defesa = value; }
    public int Sorte { get => sorte; set => sorte = value; }
    public int Nivel { get => nivel; set => nivel = value; }
    public List<Ataque> Ataques { get => ataques; set => ataques = value; }

    public int atacar(Ataque ataque){
        this.mana = this.mana - ataque.GastoDemana;
        int Acerto = Dado.RandomNumber(this.sorte, 100);
        if(Acerto > (100 - ataque.ChanceDeAcerto)){
            int Critico = Dado.RandomNumber(this.sorte, 100);
            if(Critico > 90){
                return ataque.Dano * 2;
            }
            else if(Critico > 50){
                return ataque.Dano;
            }
            else if(Critico < 0){
                return 0;
            }
            else{
                return ataque.Dano * (Critico / 100);
            }
        }
        else{
            return 0;
        }
    }

    public void defender(int dano){
        int Defesa = Dado.RandomNumber(this.sorte, 100);
        this.vida -= (dano - (dano * (Defesa / 100)));
    }

    public int droparDinheiro(){
        int dinheiro = this.Dinheiro;
        this.Dinheiro = 0;
        return dinheiro;
    }
}