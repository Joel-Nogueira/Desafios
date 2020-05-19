namespace Desafio06.Entities
{
    public class Nove : Numero
    {
        
        public Nove(char numero, int ordem)
            :base(numero, ordem)
        {
            
        }

        protected override void SetNomeUnidade() => SetNome("nove");
        protected override void SetNomeDezena() => SetNome("noventa");
        protected override void SetNomeCentena() => SetNome("novecentos");
        protected override void SetNomeMilhar() => SetNome("nove mil");
    }
}
