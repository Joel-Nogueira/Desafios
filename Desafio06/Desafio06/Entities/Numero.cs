using Desafio06.Enums;

namespace Desafio06.Entities
{
    public abstract class Numero
    {
        private char _numero;
        private string _nome;
        private int _ordem;

        public Numero()
        {
            _numero = '0';
            _ordem = 0;
            _nome = "";
        }

        public Numero(char numero, int ordem)
        {
            _numero = numero;
            _ordem = ordem;
            DecideNome();
        }

        public char GetNumero()
        {
            return _numero;
        }

        public int GetOrdem()
        {
            return _ordem;
        }

        public void SetNome(string nome)
        {
            _nome = nome;
        }

        public string GetNome()
        {
            return _nome;
        }

        private void DecideNome()
        {
            switch ((Ordem)_ordem)
            {
                case Ordem.Unidade:
                    SetNomeUnidade();
                    break;
                case Ordem.Dezena:
                    SetNomeDezena();
                    break;
                case Ordem.Centena:
                    SetNomeCentena();
                    break;
                case Ordem.Milhar:
                    SetNomeMilhar();
                    break;
                case Ordem.DezenaDeMilhar:
                    SetNomeDezenaDeMilhar();
                    break;
                default:
                    SetNome("");
                    break;
            }
        }

        public static bool EhIrregular(string numero)
        {
            int ordem = numero.Length;

            if ((Ordem)ordem == Ordem.Dezena)
                return DezenaEhIrregular(numero[0]);
            if ((Ordem)ordem == Ordem.Centena)
                return CentenaEhIrregular(numero);
            return false;
        }

        private static bool DezenaEhIrregular(char numero)
        {
            return (numero == '1');
        }

        private static bool CentenaEhIrregular(string numero)
        {
            if (numero.Substring(0, 3) == "100")
                return true;

            return false;
        }

        protected virtual void SetNomeUnidade() => SetNome("");
        protected virtual void SetNomeDezena() => SetNome("");
        protected virtual void SetNomeCentena() => SetNome("");
        protected virtual void SetNomeMilhar() => SetNome("");
        protected virtual void SetNomeDezenaDeMilhar() => SetNome("");
    }
}
