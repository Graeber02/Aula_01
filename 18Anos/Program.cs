/*using System;

namespace _18Anos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe ano nascimento!!");
            recebeAnoNascimento();

        }
        static void recebeAnoNascimento()
        {
            int anoA = Convert.ToInt32(Console.ReadLine());
            int anoAtual = DateTime.Now.Year;

            string resposta = calculaDiferenca(anoAtual, anoA);
            Console.WriteLine(resposta);
        }


        static string calculaDiferenca(int anoAtual, int anoA)
        {
            var diferenca = 0;
            diferenca = anoAtual - anoA;

            if (diferenca >= 18)
            {
                return "Maior de idade" + (@$" Voçê tem {diferenca} anos");
            }
            else
            {
                return "Menor de idade";
            }
        }
    }
}
*/


using System;

namespace FaixaEtaria
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe sua idade!!");
            recebeIdade();

        }
        static void recebeIdade()
        {
            int idade = Convert.ToInt32(Console.ReadLine());
            string ridade = calculaIF(idade);//executa o static void calculaIF
            Console.WriteLine(ridade);//chama o resultado do static void CalculaIF
        }


        static string calculaIF(int idade)
        {

            if (idade >= 18 && idade < 30)
            {
                return "adulto";
            }
            else if (idade >= 30 && idade < 50)
            {
                return "Meia Idade";
            }
            else if (idade >= 50 && idade < 70)
            {
                return "Idoso";
            }
            else if (idade < 18)
            {
                return "juvenil";
            }
            else
                return "ta fazendo hora extra";

        }

/*
        static string calculaSwitch(int idade);
        {
            string retorno = "";
              switch(idade)
            case 18:
                retorno = "válido";
                break;
            case 18:
                retorno = "válido";
                break;
            default:
                retorno = "incalido";
                break;
        }
    return retono;*/
}
}
