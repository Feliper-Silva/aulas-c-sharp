using System;
using System.Runtime.CompilerServices;

namespace ListaDeConvidados
{
    class Program
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("Informe o nome do convidado: ");
            var nomeConvidado = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(nomeConvidado) || string.IsNullOrEmpty(nomeConvidado))
            {
                Console.WriteLine("Por favor digitar o nome do convidado!");
                return;
            }

            Console.WriteLine("Informe a idade do convidado: ");
            var idadeString = Console.ReadLine();
            int idade;

            bool idadeInformada = int.TryParse(idadeString, out idade);

            if (idadeInformada == false) {

                Console.WriteLine("Idade não informada para seguir com o programa!");
                return;
            }

            bool estaConvidado;

            switch (nomeConvidado)
            {
                case "Daniel":
                    estaConvidado = true;
                    break;

                case "Evandro":
                    estaConvidado = true;
                    break;

                case "Matheus":
                    estaConvidado = true;
                    break;
                case "Gabriela":
                    estaConvidado = true;
                    break;

                case "Felipe":
                    estaConvidado = true;
                    break;

                default: 
                    estaConvidado = false; 
                    break;
            
             }

            if (estaConvidado == true && idade >= 18)
            {
                Console.WriteLine("Entrada permitida!! \nParabéns, seja bem vindo!");
            }
            if (estaConvidado == false)
            {
                Console.WriteLine("Você não está na lista de convidados, favor verificar com a pessoa que te convidou!");
            }
            if (idade < 18)
            {
                Console.WriteLine("Você não tem 18 anos! \nEntrada não permitida na festa!");
            }


        }
    }
}