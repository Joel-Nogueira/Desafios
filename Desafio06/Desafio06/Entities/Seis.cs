namespace Desafio06.Entities
{
    public class Seis : Numero
    {
        
        public Seis(char numero, int ordem)
            :base(numero, ordem)
        {
            
        }

        protected override void SetNomeUnidade() => SetNome("seis");
        protected override void SetNomeDezena() => SetNome("sessenta");
        protected override void SetNomeCentena() => SetNome("seiscentos");
        protected override void SetNomeMilhar() => SetNome("seis mil");
    }
}
