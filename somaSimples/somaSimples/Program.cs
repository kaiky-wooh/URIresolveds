using System;

class URI
{
    static void Main(string[] args)
    {
        /*
         --DESAFIO--

        Objetivo:

        Ler dois valores inteiros nas variáveis (A e B)
        Calcular a soma entre elas e atribuir à variável SOMA e escrever o valor desta variável

        Entrada:
        O arquivo de entrada contém 2 valores inteiros.

        Saída:
        Imprima a mensagem "SOMA" com todas as letras maiúsculas, 
        com um espaço em branco antes e depois da igualdade seguido pelo valor correspondente à soma de A e B.
         */

        int A = int.Parse(Console.ReadLine());
        int B = int.Parse(Console.ReadLine());

        int SOMA = A + B;

        Console.WriteLine("SOMA = " + SOMA);
    }
}