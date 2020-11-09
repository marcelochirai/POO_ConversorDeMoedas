using System;
using System.Globalization;

namespace POO_DolarComIOF
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculo dolar = new Calculo();
            
            Console.Write("Qual é a cotação do dólar?  ");
            dolar.CotDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantos dólares você irá comprar?  ");
            dolar.QtdDolar = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write(dolar);

            Console.ReadKey();
        }

    }
}
