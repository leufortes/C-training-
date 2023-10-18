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

            //REV 18/10/2023 - BÁSICO DE VARIAVEIS - INT, FLOAT, CHAR, STRING, BOOL

            int numero = 30;
            float ponto = 30.50f;
            char ajuste = 'a';
            string nome = "Leonardo Fortes Alcantara";
            var modelo = "AI_ftp"; // Declarando uma variavel por meio do "VAR"
            dynamic cor_favorita = "Vermelho"; // Exemplo de manipulação de tipo de variavel 

            Console.Write("Seu numero é igual ");
            Console.Write(ajuste);
            Console.Write(" : ");
            Console.Write(numero);
            Console.Write(" e ");
            Console.WriteLine(ponto);
            Console.WriteLine("Seu nome é: ");
            Console.WriteLine(nome);


            nome = "Nicole"; // Manipulação de variaveis

            Console.WriteLine(nome); // Impressão da variavel manipulada

            Console.WriteLine(modelo); // Impressão do atalho de atribuição a variaveis

            Console.WriteLine(cor_favorita); // Visualização da variavel de tipo dynamic

            cor_favorita = 230.256f; // Alterado o tipo da variavel para float assim, na proxima vizualizãção o valor sera alterado

            Console.WriteLine(cor_favorita); // Impressão da variavel com a alteração de tipo usando dynamic

            cor_favorita = 2654; // Alerando para um valor inteiro

            Console.WriteLine(cor_favorita); // Impressão da variavel no tipo INT

            // Em c# a típagem dinamica não é muito utilizada e acaba sendo bem especifica


            // NEW - 18/10/2023 - CONSTANTES

            const float PI = 3.14f; // Declaração de umavariavel constante - CONSTANTE - TIPO - NOME = VALOR

            Console.WriteLine(PI);

            // ENTRADA DO USUARIO

            Console.WriteLine("Escreva seu nome: ");
            string usuario = Console.ReadLine();

            Console.Write("Seu nome é: ");
            Console.Write(usuario);
            Console.ReadLine();  

        }
    }
}
