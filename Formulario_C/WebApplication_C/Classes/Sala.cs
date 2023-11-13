//Classe Pessoa - Base para criação de Aluno e Professor

public class Pessoa
{
    public string Nome { get; set; }
    public string CPF { get; set; }

    public Pessoa(string CPF) {
        this.CPF = CPF;
        this.Nome = "";
    }

    public Pessoa(string CPF, string Nome)
    {
        this.CPF = CPF;
        this.Nome = Nome;
    }

}