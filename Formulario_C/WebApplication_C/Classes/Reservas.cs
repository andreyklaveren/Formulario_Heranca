//Classe Pessoa - Base para criação de Aluno e Professor

using System.Collections.Generic;


//Classes estaticas são criadas no início do programa e podem ser acessadass a qualquer momento 
public static class Dados
{
    //Variaveis estaticas para utilização em toda a aplicação
    public static List<Carro> Carros = new List<Carro>();

    //Metodo para adicionar um novo professor a lista;
    public static void AddCarros(Carro carro)
    {
        Dados.Carros.Add(carro);
    }
    //Metodo para retornar um professor a partir do indice;
    public static Carro GetCarro(int indice)
    {
        return Dados.Carros[indice];
    }
    //Metodo para retornar toda a lista de professsores;
    public static List<Carro> GetCarros()
    {
        return Dados.Carros;
    }
}