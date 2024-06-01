using System;
using System.Globalization;

class URI 
{
    static void Main(string[] args)
    {
        /*
         --DESAFIO--

        Entrada
        A entrada contém um valor de ponto flutuante (dupla precisão), 
        no caso, a variável raio.

        Saida
        Apresentar a mensagem "A=" seguido pelo valor da variável area, 
        conforme exemplo abaixo, com 4 casas após o ponto decimal.

         */

        double raio = double.Parse(Console.ReadLine());
        double area = 3.14159 * (raio * raio);

        Console.WriteLine("A=" + area.ToString("F4"));
    }
}