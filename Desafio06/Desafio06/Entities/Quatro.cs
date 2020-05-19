namespace Desafio06.Entities
{
    public class Quatro : Numero
    {
        
        public Quatro(char numero, int ordem)
            :base(numero, ordem)
        {
            
        }

        protected override void SetNomeUnidade() => SetNome("quatro");
        protected override void SetNomeDezena() => SetNome("quarenta");
        protected override void SetNomeCentena() => SetNome("quatrocentos");
        protected override void SetNomeMilhar() => SetNome("quatro mil");
    }
}
