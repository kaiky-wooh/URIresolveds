using System;
using System.Globalization;

namespace URI1005
{
    class URI
    {
        static void Main(string[] args)
        {
            /*
             Ler 2 valores de ponto flutuante de dupla precisão A e B que correspondem a 2 notas de um aluno.
             que correspondem a 2 notas de um aluno. A seguir, 
             calcule a média do aluno, sabendo que a nota A tem peso 3.5 e a nota B tem peso 7.5 (A soma dos pesos portanto é 11)

             */


            double A, B, media;

            A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            media = ((A * 3.5) + (B * 7.5)) / 11;

            Console.WriteLine("MEDIA = " + media.ToString("F5"));
        }
    }
}