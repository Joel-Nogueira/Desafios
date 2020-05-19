namespace Desafio06.Entities
{
    public class Oito : Numero
    {
        
        public Oito(char numero, int ordem)
            :base(numero, ordem)
        {
            
        }

        protected override void SetNomeUnidade() => SetNome("oito");
        protected override void SetNomeDezena() => SetNome("oitenta");
        protected override void SetNomeCentena() => SetNome("oitocentos");
        protected override void SetNomeMilhar() => SetNome("oito mil");
    }
}
