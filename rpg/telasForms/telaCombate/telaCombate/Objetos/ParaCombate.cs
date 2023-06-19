public class ParaCombate : Item{
    protected String modificador;
    protected int valorModificador;

    public ParaCombate(String modificador, int valorModificador)
    {
        this.modificador = modificador;
        this.valorModificador = valorModificador;
        this.Nome = "";
        this.Preco = 0;
        this.Quantidade = 0;
        this.Nivel = 0;
    }

    public ParaCombate(){
        this.modificador = "";
        this.valorModificador = 0;
        this.Nome = "";
        this.Preco = 0;
        this.Quantidade = 0;
        this.Nivel = 0;
    }

    public String Modificador { get => modificador; set => modificador = value; }
    public int ValorModificador { get => valorModificador; set => valorModificador = value; }
}