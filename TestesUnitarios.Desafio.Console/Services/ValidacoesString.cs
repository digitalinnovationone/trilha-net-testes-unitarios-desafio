namespace TestesUnitarios.Desafio.Console.Services
{
    public class ValidacoesString
    {
        public int RetornarQuantidadeCaracteres(string texto)
        {
            var numeroCaracteres = texto.Length;
            return numeroCaracteres;
        }

        public bool ContemCaractere(string texto, string textoProcurado)
        {
            var contem = texto.Contains(textoProcurado);
            return contem;
        }

        public bool TextoTerminaCom(string texto, string textoProcurado)
        {
            var termina = texto.EndsWith(textoProcurado);
            return termina;
        }
    }
}