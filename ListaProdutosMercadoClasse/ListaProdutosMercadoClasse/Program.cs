using System;
using System.Collections.Generic;
using System.Linq;
using ListaProdutosMercadoClasse.Classes;
namespace ListaProdutosMercadoClasse
{
    internal class Program
    {
        //receber alguns produtos como argumento
        static void Main(string[] args)
        {
            List<Produto> produtosDisponiveis = new List<Produto>();
            produtosDisponiveis.Add(new Produto() { Nome = "Pão", Preco = 0.5 });
            produtosDisponiveis.Add(new Produto() { Nome = "Shampoo", Preco = 19.90 });
            produtosDisponiveis.Add(new Produto() { Nome = "Azeite", Preco = 14.5 });
            produtosDisponiveis.Add(new Produto() { Nome = "Refrigerante", Preco = 6.25 });
            produtosDisponiveis.Add(new Produto() { Nome = "Queijo", Preco = 12.75 });

            //verificar se foi digitado o  argumento
            if (args.Length == 0) 
            {
                Console.WriteLine("Você não passou os produtos que deseja comprar!");
                return;
            }

            // Verifica e mostra a lista de produtos disponíveis
            var produtosSelecionadosDisponiveis = produtosDisponiveis.Where(produto => args.Any(argumento => produto.Nome.ToUpper() == argumento.ToUpper()));

           foreach(var produto in produtosSelecionadosDisponiveis)
            {
                Console.WriteLine($"Este produto nós temos:\n{produto.ExibirDadosProduto()}");
            }

           //verificar e mostrar os produtos não disponiveis 
           var produtosNaoDisponiveis = args.Where(argumento=> !produtosDisponiveis.Any(produto => produto.Nome.ToUpper() == argumento.ToUpper()));

            foreach( var produtoNaoDisponivel in produtosNaoDisponiveis)
            {
                Console.WriteLine($"Este produto nós não temos infezlimente =/:{produtoNaoDisponivel}");
            }
            Console.WriteLine("--------Produtos Disponíveis ordenados---------");
            //Exibir a lista de produtos disponíveis ordenados por ordem alfabética do mercado,
            // para que o usúario posssa pedir na próxima vez.
           var produtosOrdenadosPorNome = produtosDisponiveis.OrderBy(produto => produto.Nome).ToList();

            foreach( var produtoOrdenado in produtosOrdenadosPorNome)
            {
                Console.WriteLine(produtoOrdenado.ExibirDadosProduto());
            }
        }
    }
}