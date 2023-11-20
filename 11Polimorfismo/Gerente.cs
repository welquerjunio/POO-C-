using System;

class Gerente : Imposto
{
    // metodo
    public override void valeAlimentacao(double salario) //override sobreescrive o metodo
    {
        Console.WriteLine("Desconto gerente do vale alimentação R$"+(salario * 0.15));

    }
}