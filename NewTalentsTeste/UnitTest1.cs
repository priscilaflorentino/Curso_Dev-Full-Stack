using NewTalents;

namespace NewTalentsTeste;

public class UnitTest1
{
    public Calculadora construirClasse(string data) {
        Calculadora calc = new Calculadora(data);
        return calc;
    }

    [Theory]
    [InlineData (1,2,3)]
    [InlineData (4,5,9)]
    
    public void Somar(int x, int y, int resultado)
    {
        Calculadora calc = construirClasse("22/09/2024");
        int resultadoCalc = calc.Somar(x,y);
        Assert.Equal(resultado, resultadoCalc);
    }

    [Theory]
    [InlineData (1,2,-1)]
    [InlineData (4,5,-1)]
    
    public void Subtrair(int x, int y, int resultado)
    {
        Calculadora calc = construirClasse("22/09/2024");
        int resultadoCalc = calc.Subtrair(x,y);
        Assert.Equal(resultado, resultadoCalc);
    }

    [Theory]
    [InlineData (1,2,2)]
    [InlineData (4,5,20)]
    
    public void Multiplicar(int x, int y, int resultado)
    {
        Calculadora calc = construirClasse("22/09/2024");
        int resultadoCalc = calc.Multiplicar(x,y);
        Assert.Equal(resultado, resultadoCalc);
    }

    [Theory]
    [InlineData (1,2,0.5)]
    [InlineData (4,5,0.8)]
    
    public void Dividir(int x, int y, float resultado)
    {
        Calculadora calc = construirClasse("22/09/2024");
        float resultadoCalc = calc.Dividir(x,y);
        Assert.Equal(resultado, resultadoCalc);
    }

    [Fact]
    public void DividirPorZero() {
        Calculadora calc = construirClasse("22/09/2024");
        Assert.Throws<DivideByZeroException>(
            () => calc.Dividir(3,0)
        );
    }

    [Fact]
    public void Historico() {
        Calculadora calc = construirClasse("22/09/2024");
        calc.Somar(1,2);
        calc.Somar(2,8);
        calc.Somar(3,7);
        calc.Somar(4,1);
        
        var lista = calc.Historico();
        Assert.NotEmpty(lista);
        Assert.Equal(3, lista.Count);
    }
}