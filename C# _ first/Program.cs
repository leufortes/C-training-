// Using = usando // Serve para adicionar modulo ao código 
//Modulos

using System; // Modúlos / Serve para que o C# seja capaz de manipular coisas do sistema operacional do usuario (data, console, etc)
using System.Collections.Generic; // Modúlos / 
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Linq; // Modúlos / Trabalhar com um conjunto muito grande de dados
using System.Net;
using System.Runtime.InteropServices;
using System.Text; // Modúlos / Permite que você manipule texto (minusculo, maiusculo, remover espaços em branco, etc)
using System.Threading;
using System.Threading.Tasks; // Modúlos / Serve para ao criar um programa que roda em varios nucleos de processadores 

//Inicio do programa
namespace C____first // Nome do código fonte 
{
    internal class Program // POO
    {
        static void Main(string[] args) // Função Principal (Todo código colocado dentro da função "MAIN" é o primeiro código que será executado;
        {

            int valor_pago = 0;
            int preço_do_produto = 80;

            Console.Write("O valor de um fone é de: ");
            Console.WriteLine(preço_do_produto);

            Console.WriteLine("Digite o valor que você tem para pagar: ");
            valor_pago = int.Parse(Console.ReadLine());

            Console.Write("Você pagou: ");
            Console.WriteLine(valor_pago);
            
            if (valor_pago == 80)
                    {

                Console.WriteLine("Você pagou o valor completo!");
            }
            else if (valor_pago > 80)
                        {
                Console.WriteLine("Você pagou um valor maior do que deveria ser pago. ");
                Console.WriteLine("Seu troco é de: ");
                float troco = valor_pago - preço_do_produto;
                Console.WriteLine(troco);
            }
            else
            {
                Console.WriteLine("Você pagou um valor abaixo do que deveria ser pago");
                Console.WriteLine("Faltam: ");
                float diferença = preço_do_produto - valor_pago;
                Console.WriteLine(diferença);

            }
       

            Console.ReadLine();

        } 
    }
}
