using System;
using System.Collections.Generic;
using System.Text;

namespace Calculadora
{
    class Tabuada : PrincipalMain
    {
        public static int qtd;
        public static void TabuadaGeral()
        {
            //NESTA CLASSE É UTILIZADO VARIÁVEIS GLOBAIS, A FIM DE ESTUDOS, ENTÃO CASO VEJA ALGO COMO (PrincipalMain.Numero), quer dizer que a variável (Número)
            // está na classe (PrincipalMain) !

            // Limpa a tela
            Console.Clear();
            Console.WriteLine("Tabuada para qual número? : ");
            // Pergunta qual número da tabuada deseja e lê o mesmo...
            PrincipalMain.Numero = int.Parse(Console.ReadLine());

            // Pergunta e lê a operação da tabuada
            Console.WriteLine("Escolha a operação: ( + | - | * | / )");
            PrincipalMain.operacao = char.Parse(Console.ReadLine());

            // Pergunta e lê quantos calculos da tabuada deseja
            Console.WriteLine("Quer ver quantos resultados para a operação( " + PrincipalMain.operacao + " ) na tabuda? : ");
            qtd = int.Parse(Console.ReadLine());

            //Verifica a variavel (operacao), para validar qual operação foi escolhida, então chama o metodo, dependendo da escolha.
            switch (PrincipalMain.operacao)
            {
                case '+':
                    Soma();
                    break;
                case '-':
                    Subtracao();
                    break;
                case '*':
                    Multiplicacao();
                    break;
                case '/':
                    Divisao();
                    break;
                default:
                    Console.WriteLine("Valor errado! Tente Novamente!");
                    Console.WriteLine("");
                    TabuadaGeral();
                    break;
            }

        }


        public static void Multiplicacao()
        {
            // Limpa a tela
            Console.Clear();

            //For de 1 até a quantidade de calculos solicitados
            for (int i = 1; i <= qtd; i++)
            {
                //Calculo da Multiplicação
                int result = PrincipalMain.Numero * i;

                // Verifica se o i for menor ou igual a 9, adiciona um "0" na frente do número, para ficar mais organizado o resultado final
                if (i <= 9)
                {
                    Console.WriteLine("| " + PrincipalMain.Numero + " X " + "0" + i + " |: ( " + result + " )");
                }
                else
                {
                    Console.WriteLine("| " + PrincipalMain.Numero + " X " + i + " |: ( " + result + " )");
                }
            }
        }
        // O MESMO OCORRE PARA OS OUTROS OPERADORES...
        
        public static void Soma()
        {
            Console.Clear();
            for (int i = 1; i <= qtd; i++)
            {
                int result = PrincipalMain.Numero + i;

                if (i <= 9)
                {
                    Console.WriteLine("| " + PrincipalMain.Numero + " + " + "0" + i + " |: ( " + result + " )");
                }
                else
                {
                    Console.WriteLine("| " + PrincipalMain.Numero + " + " + i + " |: ( " + result + " )");
                }
            }

        }

        public static void Subtracao()
        {
            Console.Clear();
            for (int i = 1; i <= qtd; i++)
            {
                int result = PrincipalMain.Numero - i;

                if (i <= 9)
                {
                    Console.WriteLine("| " + PrincipalMain.Numero + " - " + "0" + i + " |: ( " + result + " )");
                }
                else
                {
                    Console.WriteLine("| " + PrincipalMain.Numero + " - " + i + " |: ( " + result + " )");
                }
            }
        }

        public static void Divisao()
        {
            Console.Clear();
            for (int i = 1; i <= qtd; i++)
            {
                double numer1 = PrincipalMain.Numero;
                double numer2 = i;

                double result = numer1 / numer2;

                if (i <= 9)
                {
                    Console.WriteLine("| " + PrincipalMain.Numero + " / " + "0" + i + " |: ( " + result.ToString("F2") + " )");
                }
                else
                {
                    Console.WriteLine("| " + PrincipalMain.Numero + " / " + i + " |: ( " + result.ToString("F3") + " )");
                }
            }
        }
    }

}
