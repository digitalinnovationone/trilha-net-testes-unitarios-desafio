using TestesUnitarios.Desafio.Console.Services;

namespace TestesUnitarios.Desafio.Tests;

public class ValidacoesListaTests
{
    private ValidacoesLista _validacoes = new ValidacoesLista();

    [Fact]
    public void DeveRemoverNumerosNegativosDeUmaLista()
    {
        // Arrange
        var lista = new List<int> { 5, -1, -8, 9 };
        var resultadoEsperado = new List<int> { 5, 9 };

        // Act
        var resultado = _validacoes.RemoverNumerosNegativos(lista);

        // Assert
        Assert.Equal(resultadoEsperado, resultado);
    }

    [Fact]
    public void DeveConterONumero9NaLista()
    {
        // Arrange
        var lista = new List<int> { 5, -1, -8, 9 };
        var numeroParaProcurar = 9;

        // Act
        var resultado = _validacoes.ListaContemDeterminadoNumero(lista, numeroParaProcurar);

        // Assert
        Assert.True(resultado);
    }

    [Fact]
    public void NaoDeveConterONumero10NaLista()
    {
        // Arrange
        var lista = new List<int> { 5, -1, -8, 9 };
        var numeroParaProcurar = 10;

        // Act
        var resultado = _validacoes.ListaContemDeterminadoNumero(lista, numeroParaProcurar);

        // Assert
        Assert.False(resultado);
    }

    [Fact]
    public void DeveMultiplicarOsElementosDaListaPor2()
    {
        // Arrange
        var lista = new List<int> { 5, 7, 8, 9 };
        var resultadoEsperado = new List<int> { 10, 14, 16, 18 };
        var numeroParaMultiplicar = 2;
        
        // Act
        var resultadoObtido = _validacoes.MultiplicarNumerosLista(lista, numeroParaMultiplicar);

        // Assert
        Assert.Equal(resultadoEsperado[0], resultadoObtido[0]);
        Assert.Equal(resultadoEsperado[1], resultadoObtido[1]);
        Assert.Equal(resultadoEsperado[2], resultadoObtido[2]);
        Assert.Equal(resultadoEsperado[3], resultadoObtido[3]);
    }   

    [Fact]
    public void DeveRetornar9ComoMaiorNumeroDaLista()
    {
        // Arrange
        var lista = new List<int> { 5, -1, -8, 9 };
        var maiorNumeroListaEsperado = 9;

        // Act
        var maiorNumeroListaObtido = _validacoes.RetornarMaiorNumeroLista(lista);

        // Assert
        Assert.Equal(maiorNumeroListaEsperado, maiorNumeroListaObtido);
    }

    [Fact]
    public void DeveRetornarOitoNegativoComoMenorNumeroDaLista()
    {
        // Arrange
        var lista = new List<int> { 5, -1, -8, 9 };
        var menorNumerodaListaEsperado = -8;

        // Act
        var menorNumeroListaObtido = _validacoes.RetornarMenorNumeroLista(lista);
        
        // Assert
        Assert.Equal(menorNumerodaListaEsperado, menorNumeroListaObtido);
    }
}
