using System;

namespace ConsoleApp6
{
    class Programa6
    {
        static void Main(string[] args)
        {

            Console.Write("Insira o primeiro número: ");
            string n1 = Console.ReadLine();

            Console.Write("Insira o segundo número: ");
            string n2 = Console.ReadLine();

            Console.WriteLine();

            Console.Write("Insira um operador (+ - * /): ");
            string operador = Console.ReadLine();

            decimal resultado;
            
            if (operador == "+")
            {

                resultado = Convert.ToInt16(n1) + Convert.ToInt16(n2);
                Console.WriteLine("Resultado é: " + resultado);

            } else if (operador == "-")
            {

                resultado = Convert.ToInt16(n1) - Convert.ToInt16(n2);
                Console.WriteLine("Resultado é: " + resultado);

            } else if (operador == "*")
            {

                resultado = Convert.ToInt16(n1) * Convert.ToInt16(n2);
                Console.WriteLine("Resultado é: " + resultado);

            } else if (operador == "/" && Convert.ToInt16(n2) !=0)
            {

                resultado = Convert.ToInt16(n1) / Convert.ToInt16(n2);
                Console.WriteLine("Resultado é: " + resultado);

            } else
            {
                Console.WriteLine("Não é possível fazer divisão por zero!");

            }

        }

    }

}
