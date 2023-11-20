using System;

class Pessoa
{
    // atributos
    public double peso, altura;

    // Metodo calculo
    public double calculo()
    {
        return peso / (altura * altura);
    }

    // método situação
    public string situacao(double imc)
    {
        //variavel
        string retorno;

        //condicional
        if(imc < 18.5)
        {
            retorno = "Abaixo do peso";
        }
        else if(imc < 25)
        {
            retorno = "Penso normal";
        }
        else if(imc < 30)
        {
            retorno = "Acima do peso";
        }
        else if (imc < 35)
        {
            retorno = "Obesidade I";
        }
        else if (imc < 40)
        {
            retorno = "Obesidade II";
        }
        else
        {
            retorno = "Obesidade III";
        }
        return retorno;
    }
        // metodo de mensagem
        public void mensagem()
        {   
            //obter cálculo
            double obterCalculo = calculo();
            //obter situação
            string obterSituacao = situacao(obterCalculo);

            //exibir mensagem
            Console.WriteLine("Seu IMC é de "+obterCalculo);
            Console.WriteLine("SUa situação é "+obterSituacao);
        }
}  


