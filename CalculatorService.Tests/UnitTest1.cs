namespace CalculatorService.Tests;



public class SomaTests
{
    private readonly CalculadoraService calc = new CalculadoraService();

    [Fact]
    public void TestarSomaDeDoisNumerosPositivos()
    {
        int a = 1;
        int b = 2;

        int resultado = calc.Soma(a, b);

        Assert.Equal(3, resultado);
    }

    [Fact]
    public void TestarSomaDeUmNumeroPosiENeg()
    {
        int a = 1;
        int b = -2;

        int resultado = calc.Soma(a, b);

        Assert.Equal(-1, resultado);
    }

    [Fact]
    public void TestarSomaDeDoisNumNegativos()
    {
        int a = -1;
        int b = -2;

        int resultado = calc.Soma(a, b);

        Assert.Equal(-3, resultado);
    }
}

public class SubtracaoTests
{
    private readonly CalculadoraService calc = new CalculadoraService();

    [Fact]
    public void TestarSubtracaoDeDoisNumPositivos()
    {
        int a = 5;
        int b = 3;

        int resultado = calc.Subtracao(a, b);

        Assert.Equal(2, resultado);
    }

    [Fact]
    public void TestarSubtracaoDeUmNumPositivoEUmNumNegativo()
    {
        int a = -5;
        int b = 3;

        int resultado = calc.Subtracao(a, b);

        Assert.Equal(-8, resultado);
    }

    [Fact]
    public void TestarSubtracaoDeDoisNumNegativo()
    {
        int a = -5;
        int b = -3;

        int resultado = calc.Subtracao(a, b);

        Assert.Equal(-2, resultado);
    }
}

public class MultiplicacaoTests
{
    private readonly CalculadoraService calc = new CalculadoraService();


    [Fact]
    public void TestarMultDeDoisNumPositivos()
    {
        int a = 2;
        int b = 4;

        int resultado = calc.Multiplicacao(a, b);

        Assert.Equal(8, resultado);
    }

    [Fact]
    public void TestarMultDeUmNumPositivoEUmNumNegativo()
    {
        int a = 2;
        int b = -4;

        int resultado = calc.Multiplicacao(a, b);

        Assert.Equal(-8, resultado);
    }

    [Fact]
    public void TestarMultDeDoisNumNegativos()
    {
        int a = -2;
        int b = -4;

        int resultado = calc.Multiplicacao(a, b);

        Assert.Equal(8, resultado);
    }
}

public class DivisaoTests
{
    private readonly CalculadoraService calc = new CalculadoraService();

    [Fact]
    public void TestarDivDeDoisNumPositivos()
    {
        double a = 10;
        double b = 2;

        double resultado = calc.Divisao( a, b);

        Assert.Equal(5, resultado);
    }

    [Fact]
    public void TestarDivNumPositivoEUmNumNegativo()
    {
        double a = 10;
        double b = -2;

        double resultado = calc.Divisao(a, b);

        Assert.Equal(-5, resultado);
    }

    [Fact]
    public void TestarDivDoisNumNegativos()
    {
        double a = -10;
        double b = -2;

        double resultado = calc.Divisao(a, b);

        Assert.Equal(5, resultado);
    }

    [Fact]
    public void TestarDivCom0()
    {
        double a = 0;
        double b = 10;

        double resultado = calc.Divisao(a, b);

        Assert.Equal(0, resultado);
    }

}

public class MediaTests
{
    private readonly CalculadoraService calc = new CalculadoraService();

    [Fact]
    public void TestarMediaDeDoisNumPositivos()
    {
        double[] array1 = new double[2] { 2,6 };

        double resultado = calc.Media(array1);

        Assert.Equal(4, resultado);
    }

    [Fact]
    public void TestarMediaDeUmNumPositivoEUmNumNegativo()
    {
        double[] array1 = new double[2] { -2, 6 };

        double resultado = calc.Media(array1);

        Assert.Equal(2, resultado);
    }

    [Fact]
    public void TestarMediaDeTresNumReais()
    {
        double[] array1 = new double[3] { -2, 6, 8 };

        double resultado = calc.Media(array1);

        Assert.Equal(4, resultado);
    }
}

public class MedianaTests
{
    private readonly CalculadoraService calc = new CalculadoraService();

    [Fact]
    public void TestarMedianaDeNumImpares()
    {

        int[] array1 = new int[4] { -2, 6, 8, 7 };


        int resultado = (int)calc.Mediana(array1);

        Assert.Equal(2, resultado);
    }
}