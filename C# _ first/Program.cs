// Using = usando // Serve para adicionar modulo ao código 
//Modulos

using System; // Modúlos / Serve para que o C# seja capaz de manipular coisas do sistema operacional do usuario (data, console, etc)
using System.Collections.Generic; // Modúlos / 
using System.Linq; // Modúlos / Trabalhar com um conjunto muito grande de dados
using System.Text; // Modúlos / Permite que você manipule texto (minusculo, maiusculo, remover espaços em branco, etc)
using System.Threading.Tasks; // Modúlos / Serve para ao criar um programa que roda em varios nucleos de processadores 

//Inicio do programa
namespace C____first // Nome do código fonte 
{
    internal class Program // POO
    {
        static void Main(string[] args) // Função Principal (Todo código colocado dentro da função "MAIN" é o primeiro código que será executado;
        {

            int a = 13;
            string b = "Welcome! ";
            float c = 238.58f;
            char d = 'u';
            bool e = true;
            Console.WriteLine("Rev_First_Code_In_C#");
            Console.WriteLine(b);
            Console.WriteLine("Os valores correspondem, respectivamente:");
            Console.Write("Primeiro: ");
            Console.WriteLine(c);
            Console.Write("Segundo: ");
            Console.WriteLine(13);
            Console.WriteLine(e);
            Console.ReadLine();

            c = 348.29f;


           

        }
    }
}
