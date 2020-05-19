using System;
using System.Globalization;

namespace Desafio05
{
    class Program
    {
        private const double Salario = 1045.0;
        private const int QtdPedreiro = 40;
        static void Main(string[] args)
        {
            Console.Write("Informe o tamanho do lado: ");
            double lado = double.Parse(Console.ReadLine());

            Console.WriteLine("Custo total: " + GetCusto(lado).ToString("F2", CultureInfo.InvariantCulture));
        }

        static double GetCusto(double lado)
        {
            return QtdPedreiro * SalarioDoPedreiro(lado);
        }

        static double SalarioDoPedreiro(double lado)
        {
            return GetAreaTotal(lado) * Salario / 10;
        }

        static double GetAreaTotal(double lado)
        {
            return AreaDoRetangulo(lado) + AreaDosQuadrados(lado) + AreaDasCircunferencias(lado) +
                   AreaDoTriangulo(lado) + AreaDoTrapezio(lado);
        }

        static double AreaDoRetangulo(double lado)
        {
            return 8 * lado * lado;
        }

        static double AreaDosQuadrados(double lado)
        {
            return 4 * lado * lado;
        }

        static double AreaDasCircunferencias(double lado)
        {
            return Math.PI * Math.Pow(lado, 2);
        }

        static double AreaDoTriangulo(double lado)
        {
            return (lado * lado) / 2;
        }

        static double AreaDoTrapezio(double lado)
        {
            return (3 * lado * lado * 0.7) /  2;
        }
    }
}
