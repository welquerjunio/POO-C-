using System;

class Imposto
{
    //métodos
    public virtual void valeAlimentacao(double salario) //virtual permite que o metodo possa ser sobreescrito
    {
        Console.WriteLine("Desconto padrão do vale alimentação R$"+(salario * 0.1));
    }
    public void valeTransporte(double salario)
    {
        Console.WriteLine("Desconto padrão do vale transporte R$"+(salario * 0.06));
    }


}