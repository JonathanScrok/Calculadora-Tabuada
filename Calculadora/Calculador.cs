using System;
using System.Collections.Generic;
using System.Text;

namespace Calculadora
{
    class Calculador : PrincipalMain
    {
        public static int x;
        public static int z;
        public static void CalculadoraGeral()
        {
            // Limpa a tela
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("Digite a conta: (CARACTERES SEPARADOS DE ESPAÇOS)");
            // Lê três valores de entrada na mesma linha, separados de espaço(Ex: 2 * 3) 
            string[] valores = Console.ReadLine().Split(' ');
            //Armazena os três valores e três variaveis: x,y ,z
            x = int.Parse(valores[0]);
            char y = char.Parse(valores[1]);
            z = int.Parse(valores[2]);

            //Verifica a variavel (y), para validar qual operação foi escolhida, então chama o metodo, dependendo da escolha.
            switch (y)
            {
                case '*':
                    Multiplicacao();
                    break;
                case '+':
                    Soma();
                    break;
                case '-':
                    Subtracao();
                    break;
                case '/':
                    Divisao();
                    break;
                default:
                    break;
            }

        }

        //Metodos 
        public static void Multiplicacao()
        {
            // Limpa a tela
            Console.Clear();

            // Calcula a multiplicação
            int result = x * z;

            // Mostra o resultado Final na tela
            Console.WriteLine("");
            Console.WriteLine("| " + x + " X " + z + " |: ( " + result + " )");
        }

        // O MESMO OCORRE PARA OS OUTROS OPERADORES...
        public static void Soma()
        {
            Console.Clear();
            int result = x + z;
            Console.WriteLine("");
            Console.WriteLine("| " + x + " + " + z + " |: ( " + result + " )");
        }

        public static void Subtracao()
        {
            Console.Clear();
            int result = x - z;
            Console.WriteLine("");
            Console.WriteLine("| " + x + " - " + z + " |: ( " + result + " )");
        }

        public static void Divisao()
        {
            Console.Clear();
            int result = x / z;
            Console.WriteLine("");
            Console.WriteLine("| " + x + " / " + z + " |: ( " + result + " )");
        }
    }
}
