using System;

namespace Aula22Static
{
    class Program
    {
        static void Main(string[] args)
        {
          
            System.Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Red;
            System.Console.WriteLine("--SISTEMA PARA CONVERSÃO DE MOEDAS--");

             Console.ForegroundColor = ConsoleColor.Green;

           Conversor.CotacaoDolar = 5.23f;

           System.Console.WriteLine("");
           System.Console.WriteLine("Valor de conversão de Dolar para Real =");
           System.Console.WriteLine( Conversor.ConveterDolarParaReal(100) );

            System.Console.WriteLine("");
            System.Console.WriteLine("Valor de conversão de Real para Dolar =");
            System.Console.WriteLine( Conversor.ConveterRealParaDolar(100) );
           

           
           Console.ForegroundColor = ConsoleColor.Blue;

           Conversor.CotacaoEuro = 5.92f;

           System.Console.WriteLine("");
           System.Console.WriteLine("Valor de conversão de Euro para Real =");
           System.Console.WriteLine( Conversor.ConveterEuroParaReal(50) );

            System.Console.WriteLine("");
            System.Console.WriteLine("Valor de conversão de Real para Euro =");
            System.Console.WriteLine( Conversor.ConveterRealParaEuro(50) );


        }
    }
}
