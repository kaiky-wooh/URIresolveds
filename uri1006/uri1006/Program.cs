using System;
using System.Globalization;

namespace URI1006
{
    class URI1006
    {
        static void Main(string[] args)
        {
            // A peso 2, B peso 3, C peso 5

            double A, B, C, media;

            A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            media = (A * 2.0 + B * 3.0 + C * 5) / 10.0;
            Console.WriteLine("MEDIA = " + media.ToString("F1", CultureInfo.InvariantCulture));
        }
    }
}