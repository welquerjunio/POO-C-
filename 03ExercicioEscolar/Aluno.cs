using System;

class Aluno
{
    // Atributos
    public string nome;
    public double nota1, nota2;

    // Métodos média
    public double  media()
    {
        return (nota1+nota2)/2;
    }
    // Método Situação
    public string situacao(double media)
    {
        return media >= 7 ? "aprovado" : "reprovado";

    }
    // Método Mensagem
    public void mensagem()
    {
         //Obter a média
         double obterMedia = media ();

         //Obter a situação
         string obterSituacao = situacao(obterMedia);

         // mensagem
         Console.WriteLine(nome+ " está "+obterSituacao+" com média "+obterMedia);
    }
}