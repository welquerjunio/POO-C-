using System;

class Atendente : Imposto
{
    //metodo
    public override void valeAlimentacao (double salario) // isso faz sobreescrever o metodo da class herdada 

    {
        Console.WriteLine("Desconto atendente do vale alimentação R$"+(salario * 0.12));
    }
    
}