// Using = usando // Serve para adicionar modulo ao código 
//Modulos

using System; // Modúlos / Serve para que o C# seja capaz de manipular coisas do sistema operacional do usuario (data, console, etc)
using System.Collections.Generic; // Modúlos / 
using System.Collections.Specialized;
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
        static void Main(string[] args) // Função principal

        {


            int valor_a;
            int valor_b;
            int valor_c;

            Console.WriteLine("Digite três valores que deseja somar: ");
            Console.WriteLine("Digite o primeiro valor: ");
            valor_a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor: ");
            valor_b = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o terceiro valor: ");
            valor_c = int.Parse(Console.ReadLine());

            Console.WriteLine("Calculando a soma... ");
            Thread.Sleep(3000);

            Console.WriteLine(soma(valor_a, valor_b, valor_c));
            

           

            

            

            
            
            
            Console.ReadLine();


        }

        static int soma(int a, int b, int c)
        {

            int conta = a + b + c;
            return conta;


        }


    }

}













            /*double salario;

           Console.WriteLine("Calculo de imposto de renda com base do ano de 2022: ");
           Console.WriteLine("Digite seu salário");
           salario = double.Parse(Console.ReadLine());
           double calculo2 = salario / 100  * 7.5;
           double calculo3 = salario / 100 * 15;
           double calculo4 = salario / 100 * 22.5;
           double calculo5 = salario / 100 * 27.5;



           if (salario > 0 && salario < 1903.98)
           {
               Console.WriteLine("Você está isento de imposto de renda!");

           }
           else if (salario > 1903.99 && salario < 2826.65)
           {
               Console.WriteLine("Com seu sálario, você pagará 7,5%");
               Console.WriteLine("7,5% de " + salario + " = " + calculo2);

           }
           else if (salario > 2826.66 && salario < 3751.05)
           {
               Console.WriteLine("Com seu sálario, você pagará 15%");
               Console.WriteLine("15% de " + salario + " = " + calculo3);

           }
           else if (salario > 3751.06 && salario < 4664.68)
           {
               Console.WriteLine("Com seu sálario, você pagará 22,5%");
               Console.WriteLine("22,5% de " + salario + " = " + calculo4);
           }
           else if (salario > 4664.68)
           {
               Console.WriteLine("Com seu sálario, você pagará 27.5%");
               Console.WriteLine("27,5% de " + salario + " = " + calculo5);
           }


           Console.ReadLine();


       }

       static void teste_func (int teste) // Declarada nova função 
       {
           int precoabs = Math.Abs(teste); // adicionado Math.Abs vinculada do valor que será definido 
           Console.WriteLine("Valor de função de: " + precoabs); // O valor é declarado, passa pela função de Math.Abs e o transcreve em um valor positivo */


        








    



