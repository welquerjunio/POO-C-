using System;

namespace _11Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            // instanciar estagiadio
            Imposto objetoE = new Estagiario(); //meu objetoE vai ter acesso ao meu vale transporte e vale alimentação
            objetoE.valeAlimentacao(1000);
            objetoE.valeTransporte(1000);
            Console.WriteLine("--------------------");

            // instancia gerente
            Imposto objetoG = new Gerente();
            objetoG.valeAlimentacao(5000);
            objetoG.valeTransporte(5000);
            Console.WriteLine("--------------------");

            // instancia atendente
            Imposto objetoA = new Atendente();
            objetoA.valeAlimentacao(2000);
            objetoA.valeTransporte(2000);
        }
    }
}
