using System;

namespace _03ExercicioEscolar
{
    class Program
    {
        static void Main(string[] args)
        {
            // instanciar objeto da class aluno
            Aluno a = new Aluno();
            a.nome = "Dênis";
            a.nota1 = 8;
            a.nota2 = 10;
            a.mensagem();
    }
  }
}
