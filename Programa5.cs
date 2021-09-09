using System;

namespace ConsoleApp5
{
    class Programa5
    {
        static void Main(string[] args)
        {

            Console.Write("Insira a sua idade: ");
            string idade = Console.ReadLine();

            int idadeUsuario = Convert.ToInt16(idade);
            int regraIdade = 18;

            if(idadeUsuario >= regraIdade)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Bem-vindo ao sistema!");

            } else
            {

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Você não está autorizado a entrar no sistema!");
                Console.Write("Menor de idade!");

            }

            Console.ReadLine();

        }
    }
}
