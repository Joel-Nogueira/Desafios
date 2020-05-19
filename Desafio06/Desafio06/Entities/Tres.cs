namespace Desafio06.Entities
{
    public class Tres : Numero
    {
        
        public Tres(char numero, int ordem)
            :base(numero, ordem)
        {
            
        }

        protected override void SetNomeUnidade() => SetNome("três");
        protected override void SetNomeDezena() => SetNome("trinta");
        protected override void SetNomeCentena() => SetNome("trezentos");
        protected override void SetNomeMilhar() => SetNome("tres mil");
    }
}
