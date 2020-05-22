using System;

namespace Desafio02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o diâmetro do círculo maior: ");
            double diametro = double.Parse(Console.ReadLine());

            double areaDoAlvo = GetAreaDeUmAlvo(diametro);
            Console.WriteLine("Papelão necessário para um alvo: {0:F2} cm2", areaDoAlvo);

            Console.WriteLine("Papelão necessário para 5000 alvos: {0:F2} cm2", 5000 * areaDoAlvo);
        }

        private static double GetAreaDeUmAlvo(double diametro)
        {
            double raio = diametro * 0.5;
            return (91 * Math.PI * Math.Pow(raio, 2)) / 36;
        }
    }
}
