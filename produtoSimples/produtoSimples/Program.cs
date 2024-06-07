using System;

namespace produtoSimples
{
    class URI
    {
        static void Main(string[] args)
        {
            /*
            Objetivo
            Leia dois valores inteiros. 
            A seguir, calcule o produto entre estes dois valores e atribua esta operação à variável PROD. 
            A seguir mostre a variável PROD com mensagem correspondente. 
            
            Entrada
            O arquivo de entrada contém 2 valores inteiros.

            Saída
            Imprima a mensagem "PROD" e a variável PROD conforme exemplo abaixo, com um espaço em branco antes e depois da igualdade.
             */

            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());

            int PROD = n1 * n2;

            Console.WriteLine("PROD = " + PROD);
        }
    }
}