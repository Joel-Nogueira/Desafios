namespace Desafio06.Entities
{
    public class Sete : Numero
    {
        
        public Sete(char numero, int ordem)
            :base(numero, ordem)
        {
            
        }

        protected override void SetNomeUnidade() => SetNome("sete");
        protected override void SetNomeDezena() => SetNome("setenta");
        protected override void SetNomeCentena() => SetNome("setecentos");
        protected override void SetNomeMilhar() => SetNome("sete mil");
    }
}
