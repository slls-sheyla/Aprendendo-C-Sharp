using System;

namespace ConsoleApp7
{
    class Programa7
    {
        static void Main(string[] args)
        {

            string usuario = "Usuario";
            string senha = "123";

            Console.Write("Digite o usuário: ");
            string u = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Digite a senha: ");
            string s = Console.ReadLine();
            Console.WriteLine();

            if(u != usuario || s != senha)
            {

                Console.WriteLine("Usuario ou senha incorretos!");

            } else
            {

                Console.WriteLine("Bem-vindo ao sistema!");

            }

            Console.ReadKey();

        }
    }
}
