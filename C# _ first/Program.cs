// Using = usando // Serve para adicionar modulo ao código 
//Modulos

using System; // Modúlos / Serve para que o C# seja capaz de manipular coisas do sistema operacional do usuario (data, console, etc)
using System.Collections.Generic; // Modúlos / 
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Linq; // Modúlos / Trabalhar com um conjunto muito grande de dados
using System.Net;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Text; // Modúlos / Permite que você manipule texto (minusculo, maiusculo, remover espaços em branco, etc)
using System.Threading;
using System.Threading.Tasks; // Modúlos / Serve para ao criar um programa que roda em varios nucleos de processadores 

//Inicio do programa
namespace C____first // Nome do código fonte 
{
    internal class Program // POO
    {
        static void Main(string[] args)
        {
            int preco_do_produto = 60;
            int valor_pago;

            Console.WriteLine("Temos um relógio que está no valor de: ");
            Console.Write("R$");
            Console.WriteLine(preco_do_produto);
           

            Console.WriteLine("Digite o valor que você quer pagar:");
            valor_pago = int.Parse(Console.ReadLine());

            int troco = valor_pago - preco_do_produto;
            int sobra = preco_do_produto - valor_pago;


            if (valor_pago == 60)
            {
                Console.WriteLine("Você pagou o valor cheio, muito obrigado!");
            }
            else if (valor_pago > 60)
            {
                Console.WriteLine("Você pagou um valor acima do esperado.");
                Console.WriteLine("Gerando seu troco...");
                Thread.Sleep(3000);
                Console.WriteLine("Seu troco é de:");
                Console.WriteLine(troco);
            }
            else
            {
                Console.WriteLine("Você pagou um valor menor do que o esperado");
                Console.WriteLine("Gerando valor restante...");
                Thread.Sleep(3000);
                Console.WriteLine("O valor que resta é de:");
                Console.WriteLine(sobra);
            }
            Console.ReadLine();
        } 

    }
}


