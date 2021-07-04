using System;

namespace ProjetoFinal
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcao;
            
            Console.Clear();

            do
            {
                exibeMenu();
                opcao = Console.ReadLine().Trim().ToUpper();

                switch (opcao)
                {
                    case "A":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine(
                            "\nSou um programa que executa as operações aritméticas.");
                        Console.ResetColor();
                        Console.Write(
                            "Caso tenha alguma duvida ou qualquer problema "); 
                        Console.Write("entre em contato (https://github.com/kaylany-paulus).\n");
                        break;
                    case "S":
                        calculaSoma();
                        break;
                    case "B":
                        calculaSubtracao();
                        break;
                    case "M":
                        calculaProduto();
                        break;
                    case "D":
                        calculaDivisao();
                        break;
                    case "E":
                        calculaExponenciacao();
                        break;
                    case "R":
                        calculaRadiciacao();
                        break;
                    case "X":
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\n\nObrigado por utilizar nosso programa!");
                        Console.ResetColor();
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("\nFuncionalidade indisponível");
                        Console.ResetColor();
                        break;
                }
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("\nPressione uma tecla para continuar...");
                Console.ResetColor();
                Console.ReadKey();
                Console.Clear();
            }
            while (opcao != "X");

        }

        static void exibeMenu()
        {
            Console.WriteLine("---------------------------");
            Console.WriteLine("|           Menu          |");
            Console.WriteLine("---------------------------");
            Console.WriteLine("| S - Soma (+)            |");
            Console.WriteLine("| B - Subtração (-)       |");
            Console.WriteLine("| M - Multiplicação (x)   |");
            Console.WriteLine("| D - Divisão (/)         |");
            Console.WriteLine("| E - Exponenciação (¹²³) |");
            Console.WriteLine("| R - Radiciação (V)      |");
            Console.WriteLine("---------------------------");
            Console.WriteLine("| A - Sobre o programa    |");
            Console.WriteLine("| X - Sair                |");
            Console.WriteLine("---------------------------");
        }

        static void calculaSoma()
        {
            double numeroUm, numeroDois, resultado;
            Console.WriteLine("---------------------------");
            Console.WriteLine("|          Soma           |");
            Console.WriteLine("---------------------------");

            numeroUm = digitaNumeroOrdenado("primeiro");
            numeroDois = digitaNumeroOrdenado("segundo");

            resultado = numeroUm + numeroDois;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"\nA soma de {numeroUm} + {numeroDois} é igual a {resultado:N2}");
            Console.ResetColor();
        }

        static void calculaSubtracao()
        {
            double numeroUm, numeroDois, resultado;
            Console.WriteLine("---------------------------");
            Console.WriteLine("|       Subtração         |");
            Console.WriteLine("---------------------------");

            numeroUm = digitaNumeroOrdenado("primeiro");
            numeroDois = digitaNumeroOrdenado("segundo");

            resultado = numeroUm - numeroDois;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"\nA subtração de {numeroUm} - {numeroDois} é igual a {resultado}");
            Console.ResetColor();
        }

        static void calculaProduto()
        {
            double numeroUm, numeroDois, resultado;
            Console.WriteLine("---------------------------");
            Console.WriteLine("|      Multiplicação      |");
            Console.WriteLine("---------------------------");

            numeroUm = digitaNumeroOrdenado("primeiro");
            numeroDois = digitaNumeroOrdenado("segundo");

            resultado = numeroUm * numeroDois;
            
            Console.ForegroundColor  = ConsoleColor.Cyan;
            Console.WriteLine($"\nO produto de {numeroUm} x {numeroDois} é igual a {resultado:N2}");
            Console.ResetColor();
        }

        static void calculaDivisao()
        {
            double numeroUm, numeroDois, resultado;
            Console.WriteLine("---------------------------");
            Console.WriteLine("|         Divisão         |");
            Console.WriteLine("---------------------------");

            numeroUm = digitaNumeroOrdenado("primeiro");
            numeroDois = digitaNumeroOrdenado("segundo");

            if (numeroDois == 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("\nNão é possível a divisão por zero!");
                Console.ResetColor();
            }
            else
            {
                resultado = numeroUm / numeroDois;
                Console.ForegroundColor  = ConsoleColor.Cyan;
                Console.WriteLine($"\nA divisão de {numeroUm} / {numeroDois} é igual a {resultado:N2}");
                Console.ResetColor();
            }
        }

        static void calculaExponenciacao()
        {
            double @base, potencia, resultado;
            Console.WriteLine("---------------------------");
            Console.WriteLine("|     Exponenciação       |");
            Console.WriteLine("---------------------------");

            @base = digitaNumero("\nDigite a base..: ");
            potencia = digitaNumero("\nDigite a potência..: ");

            resultado = Math.Pow(@base, potencia);

            Console.ForegroundColor  = ConsoleColor.Cyan;
            Console.WriteLine($"\nA potência de {@base} elevado a {potencia} é igual a {resultado:N2}");
            Console.ResetColor();
        }

        static void calculaRadiciacao()
        {
            double numero, resultado;
            Console.WriteLine("---------------------------");
            Console.WriteLine("|        Radiciação       |");
            Console.WriteLine("---------------------------");

            numero = digitaNumero("\nDigite um número..: ");

            if (numero < 0)
            {
                Console.ForegroundColor  = ConsoleColor.DarkRed;
                Console.WriteLine("\nNão existem raízes de números negativos!");
                Console.ResetColor();
            }
            else
            {
                resultado = Math.Sqrt(numero);
                Console.ForegroundColor  = ConsoleColor.Cyan;
                Console.WriteLine($"\nA raiz de {numero} é igual a {resultado:N2}");
                Console.ResetColor();
            }
        }

        static double digitaNumero(string mensagem)
        {
            double numero = 0;
            Console.Write(mensagem);
            Double.TryParse(Console.ReadLine(), out numero);
            return numero;
        }

        static double digitaNumeroOrdenado(string ordem)
        {
            return digitaNumero($"\nDigite o {ordem} número..: ");
        }

    }
}
