public class Arma : ParaCombate{
    public Arma(string nome, int preco, int quantidade, int nivel, string modificador, int valorModificador){
        this.Nome = nome;
        this.Preco = preco;
        this.Quantidade = quantidade;
        this.Nivel = nivel;
        this.Modificador = modificador;
        this.ValorModificador = valorModificador;
    }
}