using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraSimples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Calculadora Simples ===\n");

            double num1 = GetNumber("Digite o primeiro número: ");
            char operation = GetOperation();
            double num2 = GetNumber("Digite o segundo número: ");
            double result = Calculate(num1, num2, operation);

            Console.WriteLine($"\nResultado: {num1} {operation} {num2} = {result}");
            Console.WriteLine("\nPressione qualquer tecla para sair...");
            Console.ReadKey();
        }

        static double GetNumber(string message)
        {
            double number;
            Console.Write(message);
            while (!double.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Entrada inválida. Por favor, insira um número válido.");
                Console.Write(message);
            }
            return number;
        }

        static char GetOperation()
        {
            Console.Write("Selecione a operação (+, -, *, /): ");
            char operation;
            while (!char.TryParse(Console.ReadLine(), out operation) || !"+-*/".Contains(operation))
            {
                Console.WriteLine("Operação inválida. Por favor, escolha entre +, -, *, /.");
                Console.Write("Digite a operação (+, -, *, /): ");
            }
            return operation;
        }

        static double Calculate(double num1, double num2, char operation)
        {
            double result = 0;
            switch (operation)
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '/':
                    if (num2 != 0)
                        result = num1 / num2;
                    else
                    {
                        Console.WriteLine("Erro: Divisão por zero não é permitida.");
                        Environment.Exit(0);
                    }
                    break;
            }
            return result;
        }
    }
}
