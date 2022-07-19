using System;
using System.Globalization;

namespace questao5
{
    class Program
    {
        static void Main(string[] args)
        {
            int codigo1, qtde1, codigo2, qtde2;
            double valor1, valor2, total;

            string[] valores = Console.ReadLine().Split(' ');
            codigo1 = int.Parse(valores[0]);
            qtde1 = int.Parse(valores[1]);
            valor1 = double.Parse(valores[2], CultureInfo.InvariantCulture);

            valores = Console.ReadLine().Split(' ');
            codigo2 = int.Parse(valores[0]);
            qtde2 = int.Parse(valores[1]);
            valor2 = double.Parse(valores[2],CultureInfo.InvariantCulture);

            total = valor1 * qtde1 + valor2 * qtde2;

            Console.WriteLine("VALOR A PAGAR: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
