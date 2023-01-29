using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static float RealizarOperacao(float primeiroNumero,float SegundoNumero, string operadorInformado)
        {
            switch (operadorInformado)
            {
                case "+": 
                    return primeiroNumero + SegundoNumero;
                case "-": 
                    return primeiroNumero - SegundoNumero;
                case "*":
                    return primeiroNumero * SegundoNumero;
                case "/":
                    return primeiroNumero / SegundoNumero;
                case "%":
                    return primeiroNumero % SegundoNumero;
                default:
                    return 0f;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Informe um número: ");
            var primeiroNumeroString = Console.ReadLine();
            float primeiroNumero;

            bool isPrimeiroNumeroValido = float.TryParse(primeiroNumeroString, out primeiroNumero);

            if (!isPrimeiroNumeroValido)
            {
                Console.WriteLine("Primeiro número inválido!");
                return;
            }

            Console.WriteLine("Informe outro número: ");
            var segundoNumeroString = Console.ReadLine();
            float segundoNumero;

            bool isSegundoNumeroValido = float.TryParse(segundoNumeroString, out segundoNumero);

            if (!isSegundoNumeroValido) 
            {
                Console.WriteLine("Segundo número informado inválido!");
                return;
            }

            Console.WriteLine("Informe o operador matemático");
            var operadorInformado = Console.ReadLine();

            float resultado = RealizarOperacao(primeiroNumero, segundoNumero, operadorInformado);
            Console.WriteLine("O Resultado da sua operação foi: " + resultado);
        }
    }
}