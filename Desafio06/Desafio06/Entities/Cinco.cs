namespace Desafio06.Entities
{
    public class Cinco : Numero
    {
        
        public Cinco(char numero, int ordem)
            :base(numero, ordem)
        {
            
        }

        protected override void SetNomeUnidade() => SetNome("cinco");
        protected override void SetNomeDezena() => SetNome("cinquenta");
        protected override void SetNomeCentena() => SetNome("quinhentos");
        protected override void SetNomeMilhar() => SetNome("cinco mil");
    }
}
