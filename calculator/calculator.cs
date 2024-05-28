// Meu primeiro projeto, entendendo como funciona C#
// Calculadora simples feita diretamente no console em C#


using System; // biblioteca, permite usar coisas como 'Console.Write' sem precisar digitar o System previamente, ou seja: "System.Console.WriteLine" para "Console.Write"

namespace calculator // nome do espaço, pode ser qualquer nome mas é interessante colocar um nome que indique o que está fazendo
{
    class Program // serve como ponto de entrada para aplicativos de console. Eu posso acessar em outra classe definindo como Program program = new Program(); program.EXEMPLO(); (public void) ou (public int)
    {
    //  static void Teste() // Sem argumentos
        static void Main(string[] args) // Com argumentos de linha de comando - é especial e atua como o ponto de entrada do programa.
                                        // O nome Main é reconhecido pelo runtime do .NET como o ponto de entrada do aplicativo de console.
                                        // Não deve ser chamado explicitamente em outra parte do código
                                        // static é chamado de método

                                        // void = ele não retorna nenhum valor ao sistema operacional
                                        // int =  ele deve retornar um valor inteiro. Esse valor pode ser usado para indicar o sucesso ou a falha do programa

        {
            Console.WriteLine("Calculadora Simples"); // Imprime o texto no console, seguido de uma nova linha movendo automaticamente o cursor para próxima linha (\n também funciona aqui)
            Console.Write("Digite o primeiro número: "); // Imprime o texto no console sem adicionar uma nova linha, fazendo com que o cursor fique na mesma linha

            double num1 = Convert.ToDouble(Console.ReadLine()); // double = É usado para armazenar valores numéricos com precisão decimal. Exemplos: 3.14, -0.5. Não é um valor constante, ou seja, pode alterar até o final do código
                                                                //

            Console.Write("Digite o operador (+, -, *, /): ");

            char operador = Console.ReadLine()[0]; // char = Pode armazenar letras, números, símbolos ou até mesmo caracteres de controle. Não pode ser alterado após ser definido (semelhante ao const de javascript). Armazena apenas
                                                   // um único caractere. Caso queira armazenar coisas como uma palavra completa, seria correto usar "string" ao invés de "char". Char é mutável, string é constante

                                                   //

            Console.Write("Digite o segundo número: ");

            double num2 = Convert.ToDouble(Console.ReadLine());
            double resultado = 0;

            switch (operador)
            {
                case '+':
                    resultado = num1 + num2;
                    break;
                case '-':
                    resultado = num1 - num2;
                    break;
                case '*':
                    resultado = num1 * num2;
                    break;
                case '/':
                    if (num2 != 0)
                        resultado = num1 / num2;
                    else
                        Console.WriteLine("Erro: Divisão por zero!");
                    break;
                default:
                    Console.WriteLine("Operador inválido!");
                    break;
            }

            Console.WriteLine($"Resultado: {resultado}");
        }
    }
}
