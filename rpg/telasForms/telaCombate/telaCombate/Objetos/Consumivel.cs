public class Consumivel : ParaCombate{
    public Consumivel(string nome, int preco, int quantidade, int nivel, string modificador, int valorModificador){
        this.Nome = nome;
        this.Preco = preco;
        this.Quantidade = quantidade;
        this.Nivel = nivel;
        this.Modificador = modificador;
        this.valorModificador = valorModificador;
    }
}