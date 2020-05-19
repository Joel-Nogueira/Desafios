using Desafio06.Enums;

namespace Desafio06.Entities
{
    public class Irregular : Numero
    {
        private string _numero;
        private string _nome;

        public Irregular(string numero)
        {
            _numero = numero;
            DecideNome();
        }

        private void DecideNome()
        { 
           switch ((Ordem)_numero.Length)
           {
                case Ordem.Dezena:
                    _nome = GetNomeDaDezenaIrregular();
                    break;
                case Ordem.Centena:
                    _nome = "cem";
                    break;
            }
        }

        private string GetNomeDaDezenaIrregular()
        {
            string nome = "";

            switch (_numero)
            {
                case "10":
                    nome = "dez";
                    break;
                case "11":
                    nome = "onze";
                    break;
                case "12":
                    nome = "doze";
                    break;
                case "13":
                    nome = "treze";
                    break;
                case "14":
                    nome = "quatorze";
                    break;
                case "15":
                    nome = "quinze";
                    break;
                case "16":
                    nome = "dezesseis";
                    break;
                case "17":
                    nome = "dezessete";
                    break;
                case "18":
                    nome = "dezoito";
                    break;
                case "19":
                    nome = "dezenove";
                    break;
            }

            return nome;
        }

        public new string GetNome()
        {
            return _nome;
        }
    }
}
