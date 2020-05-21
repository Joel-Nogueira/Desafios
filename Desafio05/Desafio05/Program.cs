using System;

namespace Desafio05
{
    class Program
    {
        private const int QtdPedreiro = 40;

        static void Main(string[] args)
        {
            Console.Write("Informe o valor do salário: ");
            double salario = double.Parse(Console.ReadLine());

            Console.Write("Informe o tamanho do lado: ");
            double lado = double.Parse(Console.ReadLine());

            double valorPorMetroQuadrado = salario * 0.1;
            Console.WriteLine("Valor por metro quadrado: " + valorPorMetroQuadrado);

            double areaDoQuarto = GetAreaDoQuarto(lado);
            Console.WriteLine("Área de um quarto: {0:F2} m2", areaDoQuarto);

            double areaDoBanheiro = GetAreaDoBanheiro(lado);
            Console.WriteLine("Área de um banheiro: {0:F2} m2", areaDoBanheiro);

            double areaDoEscritorio = GetAreaDoEscritorio(lado);
            Console.WriteLine("Área de um escritório: {0:F2} m2", areaDoEscritorio);

            double areaDaSala = GetAreaDaSala(lado);
            Console.WriteLine("Área da sala: {0:F2} m2", areaDaSala);

            double areaDaCopaECozinha = GetAreaDaCopaECozinha(lado);
            Console.WriteLine("Área da copa e da cozinha: {0:F2} m2", areaDaCopaECozinha);

            double areaDaCasa = GetAreaDaCasa(areaDoQuarto, areaDoBanheiro,
                areaDoEscritorio, areaDaSala, areaDaCopaECozinha);
            Console.WriteLine("Área da casa: {0:F2} m2", areaDaCasa);

            double valorDaMaoDeObraDaCasa = GetValorDaMaoDeObraDaCasa(valorPorMetroQuadrado, areaDaCasa);
            Console.WriteLine("Valor da mão de obra de uma casa: {0:F2} m2", valorDaMaoDeObraDaCasa);

            Console.WriteLine("Valor da mão de obra do condomínio: {0:F2} m2",
                GetValorDaMaoDeObraDoCondominio(valorDaMaoDeObraDaCasa));
        }

        static double GetAreaDoQuarto(double lado)
            => (lado * lado);

        static double GetAreaDoBanheiro(double lado)
            => (Math.PI * lado * lado * 0.25);

        static double GetAreaDoEscritorio(double lado)
            => (lado * lado * 0.5);

        static double GetAreaDaSala(double lado)
            => (8 * lado * lado);

        static double GetAreaDaCopaECozinha(double lado)
            => (lado * lado * 1.05);

        static double GetAreaDaCasa(double areaDoQuarto, double areaDoBanheiro,
                double areaDoEscritorio, double areaDaSala, double areaDaCopaECozinha)
            => 4 * (areaDoQuarto + areaDoBanheiro) + areaDaSala + areaDaCopaECozinha + areaDoEscritorio;

        static double GetValorDaMaoDeObraDaCasa(double valorPorMetroQuadrado, double areaDaCasa)
            => valorPorMetroQuadrado * areaDaCasa;

        static double GetValorDaMaoDeObraDoCondominio(double valorDaMaoDeObraDaCasa)
            => QtdPedreiro * valorDaMaoDeObraDaCasa;
    }
}
