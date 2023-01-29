using System;

namespace EstruturasDeRepeticoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Favor informar palavras no argumento!");
                return;
            }
            //For
            for (var i=0 ; i < args.Length; i++)
            {
                Console.WriteLine($"Estrutura for, indice e valor: {i}, {args[i]}");
            }
            Console.WriteLine("-----------------------------------------------------");

            //While
            var indice = 0;
            while(indice < args.Length)
            {
                Console.WriteLine($"Estrutura While, indice lidos e valor lido: {indice}, {args[indice]}");
                indice++;
            }
            Console.WriteLine("-----------------------------------------------------");

            //Do While crescente
            var loopsEfetuados = 0;
            do
            {
                Console.WriteLine($"Estrutura Do While, loops efetuados e valor lido: {loopsEfetuados}, {args[loopsEfetuados]}");

                loopsEfetuados++;
            } while (loopsEfetuados < args.Length);
            Console.WriteLine("-----------------------------------------------------");

            //Do While Decrescente
            var loopsEfetuadosInvertidos = args.Length;
            do
            {
                Console.WriteLine($"Estrutura Do While Invertido, loops efetuados e valor lido: {loopsEfetuadosInvertidos}, {args[loopsEfetuadosInvertidos-1]}");

                loopsEfetuadosInvertidos--;
            } while (loopsEfetuadosInvertidos >0);
            Console.WriteLine("-----------------------------------------------------");

            foreach(var argumento in args) 
            {
                Console.WriteLine($"Estrutura Foreach, argumento e argumento lido: {argumento}");
            }
        }
    }
}