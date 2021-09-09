using System;

namespace ConsoleApp3
{
    class Programa3
    {
        static void Main(string[] args)
        {
            Console.Write("Insira o seu nome: ");
            string nome = Console.ReadLine();

            Console.Write("O que você está fazendo?");
            string ocupacao = Console.ReadLine();

            Console.Write("Olá ");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(nome);

            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine(" soube que você está " + ocupacao);
            
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.Write("Sucesso na sua jornada!");
            Console.ReadKey();
        }
    }
}
