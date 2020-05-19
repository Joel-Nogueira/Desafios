using Desafio06.Entities;
using Desafio06.Enums;

namespace Desafio06
{
    class FactoryNumero
    {
        public string GetNomedoNumero(char numero, int ordem)
        {
            Numero num = null;

            switch (numero)
            {
                case '0':
                    num = new Zero();
                    break;
                case '1': 
                    num = new Um(numero, ordem);
                    break;
                case '2':
                    num = new Dois(numero, ordem);
                    break;
                case '3':
                    num = new Tres(numero, ordem);
                    break;
                case '4':
                    num = new Quatro(numero, ordem);
                    break;
                case '5':
                    num = new Cinco(numero, ordem);
                    break;
                case '6':
                    num = new Seis(numero, ordem);
                    break;
                case '7':
                    num = new Sete(numero, ordem);
                    break;
                case '8':
                    num = new Oito(numero, ordem);
                    break;
                case '9':
                    num = new Nove(numero, ordem);
                    break;
            }

            return num.GetNome();
        }
    }
}
