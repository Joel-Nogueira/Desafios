using System;

namespace Desafio07
{
    public static class StringExtensions
    {
        public static string SubstituiCaracteresNaMesmaPosicao(this String objeto, char caracter, string valor)
        {
            string valorAuxiliar = valor.ToUpper();
            char caracterAuxiliar = Char.ToUpper(caracter);

            int ultimoIndice = valorAuxiliar.Length - 1;
            int indice = valorAuxiliar.IndexOf(caracterAuxiliar.ToString(), 0, valorAuxiliar.Length);

            while (indice != -1)
            {
                objeto = objeto.Remove(indice, 1).Insert(indice, valor[indice].ToString());
                indice = valorAuxiliar.IndexOf(caracterAuxiliar.ToString(), indice + 1, ultimoIndice - indice);
            }

            return objeto;
        }

        public static bool EhUmaLetra(this String objeto)
        {
            if (objeto.Length == 1)
                if (Char.IsLetter(objeto[0]))
                    return true;
            return false;
        }
    }
}
