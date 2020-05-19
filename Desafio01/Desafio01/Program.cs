using System;
using System.Globalization;

namespace Desafio01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Comprimento da ponte: ");
            double comprimento = double.Parse(Console.ReadLine());

            double alturaTotalHaste = comprimento / 20;

            double distanciaCabosPonte = comprimento / 11;

            double distanciaCabosHaste = alturaTotalHaste / 5;

            double alturaHaste = 0.0;
            double comprimentoBase = 0.0;

            double[] comprimentoDasCordas = new double[5];

            double km = 0.0;

            for (int i = 0; i < 5; i++)
            {
                alturaHaste += distanciaCabosPonte;
                comprimentoBase += distanciaCabosHaste;
                comprimentoDasCordas[i] = GetComprimentoDaCorda(alturaHaste, comprimentoBase);
                km += comprimentoDasCordas[i];
            }

            double totalkm = 4 * km;

            Console.WriteLine("Altura da haste: " + alturaTotalHaste.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Comprimento da primeira corda: " + comprimentoDasCordas[0].ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Comprimento da segunda corda: " + comprimentoDasCordas[1].ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Comprimento da terceira corda: " + comprimentoDasCordas[2].ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Comprimento da quarta corda: " + comprimentoDasCordas[3].ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Comprimento da quinta corda: " + comprimentoDasCordas[4].ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Comprimento total da corda: " + totalkm.ToString("F4", CultureInfo.InvariantCulture));
        }

        static double GetComprimentoDaCorda(double alturaHaste, double comprimentoBase)
        {
            return Math.Sqrt(Math.Pow(alturaHaste, 2.0) + Math.Pow(comprimentoBase, 2.0)); ;
        }
    }
}
