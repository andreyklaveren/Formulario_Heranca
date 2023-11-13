//Classe Aluno - Filha da classe Pessoa

public class Aluno : Pessoa  //Após o ":" fica indicada a classe Pai 
{
    public string Matricula { get; set; } // O {get; set;} permite a leitura e escrita das variáveis a partir do objeto.
    public string Curso { get; set; }

    //Contrutor da classe Professor com 3 parâmetros - o " : base ()" indica qual contrutor da classe pai será utilizado
    public Aluno(string CPF, string Nome, string Matricula) : base(CPF, Nome)
    {
        this.CPF = CPF; // O "this." indica a variável global da classe.
        this.Nome = Nome;
        this.Matricula = Matricula;
    }
}