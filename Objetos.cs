
using System;

class Pessoa
{
    // Atributos
    public string Nome;
    public int Idade;

    // Construtor
    public Pessoa(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }

    // Método
    public void Apresentar()
    {
        Console.WriteLine("Olá, meu nome é " + Nome + " e tenho " + Idade + " anos.");
    }
}

class Program
{
    static void Main()
    {
        // Criando objetos
        Pessoa pessoa1 = new Pessoa("Eric", 18);
        Pessoa pessoa2 = new Pessoa("Luna", 22);

        // Chamando métodos
        pessoa1.Apresentar();
        pessoa2.Apresentar();
    }
}
