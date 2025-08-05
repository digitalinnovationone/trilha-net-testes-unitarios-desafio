using System;
using System.Collections.Generic;

namespace ProjetoConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==== Validações com Lista ====");

            var numeros = new List<int> { 1, -3, 5, -8, 9 };
            Console.WriteLine("Lista original: " + string.Join(", ", numeros));

            var positivos = ValidacoesLista.RemoverNumerosNegativos(numeros);
            Console.WriteLine("Sem negativos: " + string.Join(", ", positivos));

            bool contem9 = ValidacoesLista.ListaContemDeterminadoNumero(numeros, 9);
            Console.WriteLine("Contém número 9? " + contem9);

            var multiplicados = ValidacoesLista.MultiplicarNumerosLista(numeros, 2);
            Console.WriteLine("Multiplicados por 2: " + string.Join(", ", multiplicados));

            int maior = ValidacoesLista.RetornarMaiorNumeroLista(numeros);
            Console.WriteLine("Maior número: " + maior);

            int menor = ValidacoesLista.RetornarMenorNumeroLista(numeros);
            Console.WriteLine("Menor número: " + menor);

            Console.WriteLine("\n==== Validações com String ====");

            string texto = "Esse é um texto qualquer";
            Console.WriteLine("Texto: " + texto);

            int qtdCaracteres = ValidacoesString.RetornarQuantidadeCaracteres("Matrix");
            Console.WriteLine("Qtd caracteres de 'Matrix': " + qtdCaracteres);

            bool contemPalavra = ValidacoesString.ContemCaractere(texto, "qualquer");
            Console.WriteLine("Contém 'qualquer'? " + contemPalavra);

            bool naoContem = ValidacoesString.ContemCaractere(texto, "teste");
            Console.WriteLine("Contém 'teste'? " + naoContem);

            string fraseFinal = "Começo, meio e fim do texto procurado";
            bool terminaCom = ValidacoesString.TextoTerminaCom(fraseFinal, "procurado");
            Console.WriteLine("Termina com 'procurado'? " + terminaCom);

            Console.WriteLine("\nExecução finalizada.");
        }
    }
}
