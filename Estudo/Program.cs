using System;
using System.Collections.Generic;
using System.IO;
class Solution
{

    //enum cor { Azul, Roxo, Preto, Vermelho, Verde, Amarelo } // Criando o meu próprio tipo (int, string, etc)
    //enum options { Criar = 1, Deletar, Editar, Listar, Atualizar }

    static void Main(String[] args)
    {
        

        Console.ReadLine();
    }
}



/*                          Laços
        int contador = 0;

        while (contador < 10) 
        {
            Console.WriteLine("Rodando o while!");
            contador++;
        }

        int contador2 = 0;
        do // executa pelo menos uma vez mesmo que sejá falso
        {
            Console.WriteLine("Do While!");
            contador2++;
        } while (contador2 > 20);

        string[] nomes = { "Victor", "Lucas", "Marcelo", "Diogo", "Luiza", "Gilberto", "Rafael" };

        foreach(string nome in nomes)// [Para cada] [nome] no [nomes], repita o bloco
        {
            Console.WriteLine("ForEach Rodando");
            Console.WriteLine(nome);
        } 

        for(int i = 0; i < 10; i++)
        {
            Console.WriteLine("For rodando");
            Console.WriteLine(i);
        }

        for(int c = 0; c < nomes.Length; c++)
        {
            Console.WriteLine(nomes[c]);
        }

        for (int g = 10; g > 0; g--)
        {
            Console.WriteLine("Contagem regressiva " + g);
        }
        */




/*
Console.WriteLine("Selecione uma das opçõs abaixo");
Console.WriteLine("1-Criar\n2-Deletar\n3-Editar\n4-Listar\n5-Atualizar");

int index = int.Parse(Console.ReadLine());
options opcaoSel = (options)index;

switch (opcaoSel)
{
    case options.Criar:
        Console.WriteLine(opcaoSel);
        break;
    case options.Deletar:
        Console.WriteLine(opcaoSel);
        break;
    case options.Editar:
        Console.WriteLine(opcaoSel);
        break;
    case options.Listar:
        Console.WriteLine(opcaoSel);
        break;
    case options.Atualizar:
        Console.WriteLine(opcaoSel);
        break;
    default:
        Console.WriteLine("Opcão invalida");
        break;
}
*/



/*
       cor corFavorita = cor.Vermelho;
       cor corFavDeAlguem = cor.Roxo;

       Console.WriteLine((int)corFavorita);// Convertendo em número
       Console.WriteLine((cor)2); // Convertendo em cor
*/




/*

    ExibirMsg();
    GerarPreco(60);
    int soma1 = Somar(1, 3, 6);
    int soma2 = Somar(20, 30, 3);
    int soma3 = Somar(1, 6, 4);

    Console.WriteLine(soma1);
    Console.WriteLine(soma2);
    Console.WriteLine(soma3);


static void ExibirMsg()
{
    Console.WriteLine("Teste de exibição");
    Console.WriteLine("Estou uando funções");
    Console.WriteLine("Bem vindo!");
}

static void GerarPreco(int preco)
{
    int precoAbs = Math.Abs(preco); //Abs pega o modúlo do número (Sempre positivo)
    int valorFinal = precoAbs + (2 * precoAbs);
    Console.WriteLine("Valor Final:" + valorFinal);
}

static int Somar(int a, int b, int c) // O int é para mostrar o que será retornado, sendo possível usar int, string, bool etc... (é necessário sempre usar o return)
{
    int resultadoFinal = a + b + c;
    return resultadoFinal;


}
*/


/*
        string cor = "Verde";

        switch (cor)
        {
            case "Vermelho":
                Console.WriteLine("Ver");
                break;
            case "Amarelo":
                Console.WriteLine("Ama");
                break;
            case "Azul":
                Console.WriteLine("Azul");
                break;
            default: // Se nem um dos de cima rodar, esse ira rodar como padrão
                Console.WriteLine("Sua cor favorita é " + cor);
                break;
        }
        */



/*
        string[] produtos = new string[5] { // O número no parênteses define quantos itens tera o array
            "Sea of thieves",
            "Minecreft",
            "Stardew Valley",
            "Hollow Knight",
            "Portal 2" 
        };


        produtos[4] = "Portal 3";
        Console.WriteLine(produtos[0]);

        int[] valores = { 20, 40, 560, 3024, 234, 45 };
 */



/*
        int idade = int.Parse(Console.ReadLine()); // O parse converte para o que está o chamando 

        if (idade <= 11)
        {
            Console.WriteLine("Criança");
        } 
        else if (idade <= 18)
        {
            Console.WriteLine("Adolescente");
        } 
        else if (idade < 59)
        {
            Console.WriteLine("Adulto");
        } 
        else
        {
            Console.WriteLine("Idoso");
        }
 */

/* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution 

        string s = Console.ReadLine();
        string odd = String.Empty;
        string even = String.Empty;

        for (int i = 0; i < s.Length; i++)
        {
            string actualString;

            if (i % 2 != 0)
            {
                actualString = s[i].ToString();
                odd += actualString;
            }
            else
            {
                actualString = s[i].ToString();
                even += actualString;
            }
        }

        Console.WriteLine($"{even} {odd}");
        Console.ReadLine();

        */


/*using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;
// Módulos | Pacotes


namespace Estudo
{
    internal class Program // Inicio do Programa
    {
        static void Main(string[] args) // Função principal
        {
            double meal_cost = 12;
            int tip_percent = 20;
            int tax_percent = 8;

            var comidaGorgeta = meal_cost * (Convert.ToDouble(tip_percent) / 100);
            var comidaTaxa = (meal_cost * (Convert.ToDouble(tax_percent) / 100));
            var comidaPrecoFinal = meal_cost + comidaGorgeta + comidaTaxa;
            int comidaPrecoArredondado = Convert.ToInt32(Math.Round(comidaPrecoFinal));
            Console.WriteLine(comidaPrecoArredondado);

        }

    } // Fim do programa
}
*/
// IMPORTANTE : Se você está com as letras apagando enquanto você escreve, aperta no INS/INSERT no seu teclado, ajuda do Lucas do passado

/*
                               Tipos de Dados

               Int - Números inteiros negativos ou positivos
               Float - Múmeros com vitgula positivos e negativos || Double/Decimal
               Bool - True or False
               String - "" Text
               Char - 'a' Único caracter

            

            int ano2Guerra = 1942;
            string corFav = "Purple";
            float velForm1 = 294.48f;
            bool segGuerraMundial = true;

            Console.Write("Hello World!\n"); // O \n quebra a linha e vai para a próxima \next
            Console.WriteLine("My name is Lucas Bonato"); // o WriteLine faz a mesma função do \n, mas direto no método
            Console.ReadLine();
            

            const float piNumber = 3.14f; Definir uma "váriavel" que NUNCA pode ser mudada

            */