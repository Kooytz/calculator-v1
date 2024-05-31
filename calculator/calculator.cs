using System;

namespace Calculator {
    class ConsoleCalculator {
        static void Main(string[] args) {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Header();

            Console.Write("\x1b[36mDigite o primeiro número do cálculo:\x1b[0m ");
            string firstNumber = Console.ReadLine();

            if (!IsValidNumber(firstNumber, out double firstNumberValid)) {
                Console.WriteLine("\x1b[31mEntrada inválida. Tente novamente com um número válido.\x1b[0m\n");
                return;
            }

            Console.Write("\x1b[36mDigite o operador (+, -, *, /): \x1b[0m");
            char Operator = Console.ReadLine()[0];

            if (!IsValidOperator(Operator)) {
                Console.WriteLine("\x1b[31mEntrada inválida. Tente novamente com um sinal de operação matemática válida.\x1b[0m\n");
                return;
            }

            Console.Write("\x1b[36mDigite o segundo número do cálculo:\x1b[0m ");
            string secondNumber = Console.ReadLine();

            if (!IsValidNumber(secondNumber, out double SecondNumberValid)) {
                Console.WriteLine("\x1b[31mEntrada inválida. Tente novamente com um número válido.\x1b[0m\n");
                return;
            }

            double result = 0;

            switch(Operator) {
                case '+':
                    result = firstNumberValid + SecondNumberValid; 
                break;

                case '-':
                    result = firstNumberValid - SecondNumberValid;
                break;

                case '*':
                    result = firstNumberValid * SecondNumberValid;
                break;

                case '/':
                    if (SecondNumberValid == 0) {
                        Console.WriteLine("\x1b[31mErro: Divisão por zero!\x1b[0m\n");
                        return;
                    } else { 
                        result = firstNumberValid / SecondNumberValid;
                    }
                break;
            }

            Console.WriteLine($"\n\x1b[32mResultado: {firstNumberValid} {Operator} {SecondNumberValid} = {result}\x1b[0m\n");
        }

        static bool IsValidNumber(string input, out double number) {
            return double.TryParse(input, out number);
        }

        static bool IsValidOperator(char input) {
            return input == '+' || input == '-' || input == '*' || input == '/';
        }

        static void Header(){
            Console.WriteLine("\n\x1b[31mDesenvolvido com \u2764  por Koytz. \x1b[0m");
            Console.WriteLine("\x1b[33mProjeto:\u001b[0m Calculator v1");
            Console.WriteLine("\x1b[33mDescrição:\u001b[0m Faça calculos de soma, subtração, multiplicação e divisão diretamente pelo console.");
            Console.WriteLine("\x1b[33mData de inicialização do desenvolvimento:\u001b[0m 26/05/2024.");
            Console.WriteLine("\x1b[33mData de finalização do desenvolvimento:\u001b[0m 29/05/2024.");
            Console.WriteLine("\x1b[33mVersão:\u001b[0m 1.0\n");
        }
    }
}