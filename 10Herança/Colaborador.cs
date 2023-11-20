using System;

class Colaborador : Pessoa // passando ":Pessoa" na class, gera a herança onde faz a class pessoa herdar os atributos e metodos da class Pessoa, desde que não seja private
{
    // Atributos
    private double salario;

    //Método construtor
    public Colaborador(string nome, int idade, double salario)
    {
        this.nome = nome;
        this.idade = idade;
        this.salario = salario;

        mensagemPessoa();
        mensagemColaborador();

    }

    //Método
    private void mensagemColaborador()
    {
        Console.WriteLine("Salário: "+salario);
    }
}