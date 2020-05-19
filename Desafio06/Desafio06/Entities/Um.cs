namespace Desafio06.Entities
{
    public class Um : Numero
    {
        
        public Um(char numero, int ordem)
            :base(numero, ordem)
        {
            
        }

        protected override void SetNomeUnidade() => SetNome("um");
        protected override void SetNomeCentena() => SetNome("cento");
        protected override void SetNomeMilhar() => SetNome("um mil");
        protected override void SetNomeDezenaDeMilhar() => SetNome("dez mil");
    }
}
