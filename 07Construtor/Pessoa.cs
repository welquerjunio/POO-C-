using System;

class Pessoa
{
    // Constrotor (todo construtor é publico)
    // assim que vc instancia um objeto o construtor é executado

    public Pessoa()
    {
        Console.WriteLine("Construtor executado");
    }

    public Pessoa (string nome)
    {
        Console.WriteLine("Olá "+nome);
    }

}