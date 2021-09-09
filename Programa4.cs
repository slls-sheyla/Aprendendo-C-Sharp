using System;

namespace ConsoleApp4
{
    class Programa4
    {
        static void Main(string[] args)
        {
            Console.Write("Insira o primeiro valor: ");
            string valor1 = Console.ReadLine();

            Console.WriteLine("Insira o segundo valor: ");
            string valor2 = Console.ReadLine();

            string resultado = valor1 + valor2;

            Console.WriteLine();

            Boolean comparacao = valor1 == valor2;
            Console.WriteLine("Resultado é igual: " + comparacao);

            Boolean comparacaoMaiorQue = Convert.ToInt16(valor1) > Convert.ToInt16(valor2);

            Console.WriteLine("Valor 1  é maior que o valor 2: " + comparacaoMaiorQue);

            Console.ReadKey();
        }
    }
}
