using System;
using System.Text.RegularExpressions;

namespace Calculator
{
    class ConsoleCalculator {
        static void Main(string[] args) {
            Console.WriteLine("\n\x1b[31mDesenvolvido com ❤️ por Koytz. \x1b[0m");
            Console.WriteLine("\x1b[33mProjeto:\u001b[0m Calculator v1");
            Console.WriteLine("\x1b[33mDescrição:\u001b[0m Faça calculos de soma, subtração, multiplicação e divisão diretamente pelo console.");
            Console.WriteLine("\x1b[33mData de inicialização do desenvolvimento:\u001b[0m 26/05/2024.");
            Console.WriteLine("\x1b[33mData de finalização do desenvolvimento:\u001b[0m 26/05/2024.");
            Console.WriteLine("\x1b[33mVersão:\u001b[0m 0.5\n");

            Console.Write("\x1b[36mDigite a expressão (por exemplo, 1+1):\x1b[0m ");

            string operation = Console.ReadLine();
            string pattern = @"\s*([-+]?\d*\.?\d+)\s*([-+*/])\s*([-+]?\d*\.?\d+)\s*";

            Match match = Regex.Match(operation, pattern);

            if (match.Success) {
                Console.WriteLine($"\x1b[32mResultado da expressão: {operation}\x1b[0m\n");
            } else {
                Console.WriteLine("\x1b[31mEntrada inválida. Tente novamente.\x1b[0m");
            }
        }

    }
}