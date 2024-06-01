using System;

class URI
{
    static void Main(string[] args)
    {
        /*
         ---DESAFIO---

        - Ler 2 valores inteiros e armazenar em variaveis (A e B)
        - Efetuar uma soma de A e B atribuindo o resultado na variavel X
        - Imprimir X (letra maiúscula) seguido pelo valor da variável X
        - Ter um espaço antes e depois do sinal de igualdade
         
         */

        int A = int.Parse(Console.ReadLine());
        int B = int.Parse(Console.ReadLine());

        int X = A + B;

        Console.WriteLine("X = " + X);
    }
}