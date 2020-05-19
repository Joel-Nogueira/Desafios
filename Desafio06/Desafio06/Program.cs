using System;
using Desafio06.Entities;
using Desafio06.Enums;

namespace Desafio06
{
    class Program
    {
        private const int NumeroMinimo = 1;
        private const int NumeroMaximo = 10000;

        static void Main(string[] args)
        {
            string numero = Console.ReadLine();
            int numeroPermitido = int.Parse(numero);

            while ((numeroPermitido >= NumeroMinimo) && (numeroPermitido <= NumeroMaximo))
            {
                Console.WriteLine(GetNumeroPorExtenso(numero));
                numero = Console.ReadLine();
                numeroPermitido = int.Parse(numero);
            }
        }

        static string GetNumeroPorExtenso(string numero)
        {
            FactoryNumero fn = new FactoryNumero();
            int ordem = numero.Length;
            string nomeDoNumero = "";

            for (int i = 0, ordemAtual = ordem; i < ordem; i++, ordemAtual--)
            {
                nomeDoNumero = nomeDoNumero + EscolheEntreEpacoOuE(i, numero[i], ordemAtual);

                string parteDoNumero = numero.Substring(i, ordem - i);

                if (Numero.EhIrregular(parteDoNumero))
                {
                    nomeDoNumero = nomeDoNumero + new Irregular(parteDoNumero).GetNome();
                    break;
                }
                else
                    nomeDoNumero = nomeDoNumero + fn.GetNomedoNumero(numero[i], ordemAtual);
            }

            return nomeDoNumero;
        }

        public static string EscolheEntreEpacoOuE(int indice, char numero, int ordemAtual)
        {
            string str = "";
            if ((indice > 0) && (numero != '0') && ordemAtual < 3)
                str = " e ";
            else if ((indice > 0) && (indice < 2) && (numero != '0'))
                str = " ";
            return str;
        }
    }
}
