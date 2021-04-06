using System;

namespace Calculadora
{
    class PrincipalMain
    {
        public static int Numero;
        public static char operacao;
        public static string novamente;
        static void Main(string[] args)
        {
            Console.WriteLine("Olá, tudo bem? oque gostaria de fazer?");
            do
            {
                Inicio(); //Chama o método de Inicio, para começar o programa

                ValidaTentarNovamente(); //Chama o método de Inicio, para começar o programa

            } while (novamente == "s"); //Enquanto a variavel (novamente) for igual a "s", reinicia o processo, se não.. Finaliza!
        }

        private static void Inicio()
        {
            Console.WriteLine("");
            // Escolha de Tabuada ou Calculadora
            Console.WriteLine("| Tabuada ou Calculadora |");
            string escolha = Console.ReadLine();


            if (escolha.Equals("Tabuada", StringComparison.CurrentCultureIgnoreCase)) //Se for escolhido Tabuada chamar o metodo TabuadaGeral()
            {
                Tabuada.TabuadaGeral();
            }
            else if (escolha.Equals("Calculadora", StringComparison.CurrentCultureIgnoreCase)) //Se for escolhido Calculadora chamar o metodo CalculadoraGeral();
            {
                Calculador.CalculadoraGeral();
            }
            else //Se não for escolhida uma opção válida
            {
                Console.WriteLine("");
                Console.WriteLine("Não entendi, escolha uma opção correta por favor!");
                Inicio();
            }
        }

        public static void ValidaTentarNovamente()
        {
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
        }
    }
}
