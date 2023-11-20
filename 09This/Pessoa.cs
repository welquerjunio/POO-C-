using System;

class Pessoa
{
    //atributo
    private string nome = "Tatiana";

    // construtor
    public Pessoa(string nome)
    {
        Console.WriteLine(nome);
        Console.WriteLine(this.nome); // this sempre vai ligar o atributo da classe ao seu metodo, this remete a um atributo
    }


}