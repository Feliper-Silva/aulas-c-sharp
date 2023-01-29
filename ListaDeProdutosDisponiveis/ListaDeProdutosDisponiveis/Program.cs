using System;
using System.Collections.Generic;
using System.Linq;

namespace ListaDeProdutosDisponiveis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //lista de produtos
            List<string> produtosDisponiveis = new List<string>()
            {
                "pão", "manteiga", "requeijão", "leite", "queijo", "presunto", "refrigerante", "arroz", "tomate", "doce", "alface"
            };

            // validar se foi preenchido os argumentos
            try
            {
                //lista quais produtos informados do argumento tem na lista do mercado
                var produtosSelecionados = produtosDisponiveis.Where(produto => args.Contains(produto)).ToList();

                foreach (var produtoSelecionado in produtosSelecionados)
                {
                    Console.WriteLine($"Este produto nós temos: {produtoSelecionado}");
                }

                // lista quais produtos informados do argumento NÃO tem na lista do mercado
                var produtosNaoDisponiveis = args.Where(args => !produtosDisponiveis.Contains(args)).ToList();

                foreach (var produtoNaoDisponivel in produtosNaoDisponiveis)
                {
                    Console.WriteLine($"Este produto nós não temos: {produtoNaoDisponivel}");
                }
                Console.WriteLine("-----------------------------------------------------");
                // retornar a lista de produtos disponiveis do mercado ORDENADOS em ordem alfabética
                var produtosDisponiveisOrdenadosPorNome = produtosDisponiveis.OrderBy(e=>e).ToList();
                foreach ( var produtoDisponivelOrdenado in produtosDisponiveisOrdenadosPorNome)
                {
                    Console.WriteLine($"Segue este produto disponível: {produtoDisponivelOrdenado}");
                }
                Console.WriteLine("-----------------------------------------------------");
                // codigo foreach da lista mercado ordenados em ordem alfabética encurtado
                produtosDisponiveisOrdenadosPorNome.ForEach(produto => Console.WriteLine($"Segue este produto disponível: {produto}"));
            }
            catch (Exception)
            {
                Console.WriteLine("Argumentos inválidos");
            };
        }
    }
}