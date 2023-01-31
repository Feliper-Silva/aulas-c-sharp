using ListaDeAnimais.Classes;
using System;
using System.Linq;

namespace ListaDeAnimais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Favor digitar o nome do animal para buscarmos na nossa base:");
            var nomeAnimal = Console.ReadLine();

            if (string.IsNullOrEmpty(nomeAnimal) || string.IsNullOrWhiteSpace(nomeAnimal)) {

                Console.WriteLine("Favor passar um nome de animal vertebrado válido!");
                return;
            }

            var listaDeAnimais = new List<Animal>();
            listaDeAnimais.Add(new Mamifero() { Nome = "Vaca", QuantidadeDeMamas = 4 });
            listaDeAnimais.Add(new Reptil() { Nome = "Cobra"});
            listaDeAnimais.Add(new Ave() {Nome = "Coruja"});
            listaDeAnimais.Add(new Peixe () { Nome = "nemo", QuantidadeDeNadadeiras=2});

            var animalSelecionado = listaDeAnimais.FirstOrDefault( animal => animal.Nome.ToUpper() == nomeAnimal.ToUpper()); 

            if (animalSelecionado == null)
            {
                Console.WriteLine("animal não está na nossa lista!");
                return;
            }

            if ( animalSelecionado is Mamifero)
            {
                Console.WriteLine($"O animal encontrado é um mamífero com nome {animalSelecionado.Nome} e quantidade de mamas ={((Mamifero)animalSelecionado).QuantidadeDeMamas}");
            }
            else if ( animalSelecionado is Reptil)
            {
                Console.WriteLine($"O animal encontroda é um réptil com nome {animalSelecionado.Nome} e não sabe controlar sua temperatura = {((Reptil)animalSelecionado).ControlaTemperaturaDoCorpo}");
            }
            else if ( animalSelecionado is Ave)
            {
                Console.WriteLine($"O animal encontrado é uma ave com nome {animalSelecionado.Nome} e tem penas = {((Ave)animalSelecionado).TemPena}");
            }
            else if ( animalSelecionado is Peixe)
            {
                Console.WriteLine($"O animal encontrado é um peixe com nome {animalSelecionado.Nome} e tem quantidade de nadadeiras = {((Peixe)animalSelecionado).QuantidadeDeNadadeiras}");
            }
            else
            {
                Console.WriteLine($"O animal encontrado é um animal é tem nome {animalSelecionado.Nome}");
            }
        }
    }
}