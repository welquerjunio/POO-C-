using System;

abstract class Padrao
{
    // metodo obrigatorio (pode ser publico ou protegido)
    public abstract void taxaEmprestimo(double valor);

    //metodo opcional
    public void calculoPoupanca(double valor, double taxa)
{
    Console.WriteLine("Ganhos obtidos pela poupança R$ "+(valor * taxa));
}

}