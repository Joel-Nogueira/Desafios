namespace Desafio06.Entities
{
    public class Dois : Numero
    {
        
        public Dois(char numero, int ordem)
            :base(numero, ordem)
        {
            
        }

        protected override void SetNomeUnidade() => SetNome("dois");
        protected override void SetNomeDezena() => SetNome("vinte");
        protected override void SetNomeCentena() => SetNome("duzentos");
        protected override void SetNomeMilhar() => SetNome("dois mil");
    }
}
