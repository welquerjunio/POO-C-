using System;

namespace _08GetSet
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p = new Pessoa(); // instanciando
            p.Nome = "Ralf"; // enviando nome
            Console.WriteLine(p.Nome); //exibido o nome
        }
    }
}
