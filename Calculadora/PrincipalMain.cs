using System;

namespace Calculadora
{
    class PrincipalMain
    {
        public static int Numero;
        public static char operacao;

        static void Main(string[] args)
        {
            string novamente;
            Console.WriteLine("Olá, tudo bem? oque gostaria de fazer?");
            do
            {
                Console.WriteLine("");
                Console.WriteLine("| Tabuada ou Calculadora |");
                string escolha = Console.ReadLine();

                if (escolha.Equals("Tabuada", StringComparison.CurrentCultureIgnoreCase))
                {
                    Tabuada.TabuadaGeral();
                }
                else if (escolha.Equals("Calculadora", StringComparison.CurrentCultureIgnoreCase))
                {
                    Calculador.CalculadoraGeral();
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("Não entendi, escolha uma opção correta por favor!");
                }


                // ------------------------------- TENTAR NOVAMENTE ---------------------------------------
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Quer ir novamente? (S/N)");
                // Lê a escolha , se quer tentar novamente ou não...
                novamente = Console.ReadLine();

                // Limpa a tela
                Console.Clear();

                // Se a variavel (novamente) for igual a "S" ou "s" declara ela como minúscula
                if (novamente.Equals("S", StringComparison.CurrentCultureIgnoreCase))
                {
                    novamente = "s";
                }

            } while (novamente == "s"); //Enquanto a variavel (novamente) for igual a "s", reinicia o processo, se não.. Finaliza!
        }
    }
}
